using Arcane.Itec.Data;
using Arcane.Itec.DTO;
using Arcane.Itec.ItecUtils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arcane.Itec
{
    public class SalaryCalculator
    {
        private readonly CommissionValue Commission;
        private readonly CommisionRules Rules;
        private int TotalSimAmount { get; set; }
        private int TotalSimReward { get; set; }
        private int TotalSelloutAmount { get; set; }
        private int TotalSelloutReward { get; set; }
        private int TotalVolumes { get; set; }
        private int TotalVolumeRewards { get; set; }
        private int TotalEmployeeSalarys { get; set; }

        public SalaryCalculator(CommissionValue commission, CommisionRules rules)
        {
            Commission = commission;
            Rules = rules;
        }

        public Dictionary<string, Employee> GetEmployeesSalary(Dictionary<string, PSR> agencyPsr)
        {
            var employeesNames = agencyPsr.Values.Select(x => x.WalkerName).Distinct();
            var employees = new Dictionary<string, Employee>();

            TotalVolumes = agencyPsr.Values.Select(x => x.MonthlySale)
                                         .Aggregate((result, value) => result + value);

            foreach (var name in employeesNames)
            {
                var psrFromThisEmployee = agencyPsr.Values.Where(psr => psr.WalkerName == name);
                var totalClients = psrFromThisEmployee.Count();

                var simOkAmount = psrFromThisEmployee.Where(psr => psr.SimOk).Count();
                TotalSimAmount += simOkAmount;

                var selloutOkAmount = psrFromThisEmployee.Where(psr => psr.SelloutOk).Count();
                TotalSelloutAmount += selloutOkAmount;

                var totalVolume = psrFromThisEmployee.Select(x => x.MonthlySale).Aggregate((result, value) => result + value);

                var simReward = CalculateSimReward(simOkAmount);
                var selloutReward = CalculateSOReward(selloutOkAmount);
                var volumeReward = CalculateVolumenReward(totalVolume, TotalVolumes, simOkAmount, selloutOkAmount);


                var totalSalary = simReward + selloutReward + volumeReward;
                TotalEmployeeSalarys += totalSalary;

                employees.Add(name, new Employee()
                {
                    Name = name,
                    PsrAmount = totalClients,
                    SimAmount = simOkAmount,
                    SimReward = "$ " + simReward,
                    SimPercentage = Utils.GetEfectivity(totalClients, simOkAmount),
                    SelloutAmount = selloutOkAmount,
                    SelloutReward = "$ " + selloutReward,
                    SelloutPercentage = Utils.GetEfectivity(totalClients, selloutOkAmount),
                    VolumeAmount = totalVolume,
                    VolumeReward = "$ " + volumeReward,
                    TotalSalary = "$ " + totalSalary
                });
            }
            employees.Add("Total", new Employee
            {
                Name = "Total",
                PsrAmount = agencyPsr.Values.Count,
                SimAmount = TotalSimAmount,
                SimReward = "$ " + TotalSimReward,
                SimPercentage = Utils.GetEfectivity(agencyPsr.Values.Count, TotalSimAmount),
                SelloutAmount = TotalSelloutAmount,
                SelloutReward = "$ " + TotalSelloutReward,
                SelloutPercentage = Utils.GetEfectivity(agencyPsr.Values.Count, TotalSelloutAmount),
                VolumeAmount = TotalVolumes,
                VolumeReward = "$ " + TotalVolumeRewards,
                TotalSalary = "$ " + TotalEmployeeSalarys
            });
            return employees;
        }

        private int CalculateSimReward(int simsOk)
        {
            int reward;
            if (simsOk >= Rules.SimStep3) reward = simsOk * Commission.SimStep3;
            if (simsOk >= Rules.SimStep2) reward = simsOk * Commission.SimStep2;
            if (simsOk >= Rules.SimStep1) reward = simsOk * Commission.SimStep1;
            else reward = simsOk * Commission.DefaultSim;

            TotalSimReward += reward;
            return reward;
        }

        private int CalculateSOReward(int selloutOk)
        {
            int reward;
            if (selloutOk >= Rules.SelloutStep2) reward = selloutOk * Commission.SelloutStep2;
            if (selloutOk >= Rules.SelloutStep1) reward = selloutOk * Commission.SelloutStep1;
            else reward = selloutOk * Commission.DefaultSellout;

            TotalSelloutReward += reward;
            return reward;
        }

        private int CalculateVolumenReward(int employeeVolume, int finalVol, int simOk, int selloutOk)
        {
            if (simOk < Rules.RequieredPSR || selloutOk < Rules.RequieredPSR) return 0;

            long multiplyResult = (long)employeeVolume * Commission.VolumePayment;
            var reward = (int)Math.Round((double)multiplyResult / finalVol);

            TotalVolumeRewards += reward;

            return reward;
        }
    }
}