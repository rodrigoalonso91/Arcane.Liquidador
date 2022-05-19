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
        private int AllVolumes { get; set; }
        private int AllVolumesRewards { get; set; }
        private int AllEmployeeSalary { get; set; }

        public SalaryCalculator(CommissionValue commission, CommisionRules rules)
        {
            Commission = commission;
            Rules = rules;
        }

        public Dictionary<string, Employee> GetEmployeesSalary(Dictionary<string, PSR> agencyPsr)
        {
            var employeesNames = agencyPsr.Values.Select(x => x.WalkerName).Distinct();
            var employees = new Dictionary<string, Employee>();

            var AllVolumes = agencyPsr.Values.Select(x => x.MonthlySale).Aggregate((result, value) => result + value);

            foreach (var name in employeesNames)
            {
                var psrFromThisEmployee = agencyPsr.Values.Where(psr => psr.WalkerName == name);
                var totalClients = psrFromThisEmployee.Count();

                var simOkAmount = psrFromThisEmployee.Where(psr => psr.SimOk).Count();
                TotalSimAmount += simOkAmount;

                var selloutOkAmount = psrFromThisEmployee.Where(psr => psr.SelloutOk).Count();
                TotalSelloutAmount += selloutOkAmount;

                var totalVolume = psrFromThisEmployee.Select(x => x.MonthlySale)
                                                     .Aggregate((result, value) => result + value);

                var simReward = CalculateSimReward(simOkAmount);
                TotalSimReward += simReward;

                var selloutReward = CalculateSOReward(selloutOkAmount);
                TotalSelloutReward += selloutReward;

                var volumeReward = CalculateVolumenReward(totalVolume, AllVolumes, simOkAmount, selloutOkAmount);
                AllVolumesRewards += volumeReward;

                var totalSalary = simReward + selloutReward + volumeReward;
                AllEmployeeSalary += totalSalary;

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
                VolumeAmount = AllVolumes,
                VolumeReward = "$ " + AllVolumesRewards,
                TotalSalary = "$ " + AllEmployeeSalary
            });
            return employees;
        }

        private int CalculateSimReward(int simsOk)
        {
            if (simsOk >= Rules.SimStep3) return simsOk * Commission.SimStep3;
            if (simsOk >= Rules.SimStep2) return simsOk * Commission.SimStep2;
            if (simsOk >= Rules.SimStep1) return simsOk * Commission.SimStep1;
            else return simsOk * Commission.DefaultSim;
        }

        private int CalculateSOReward(int selloutOk)
        {
            if (selloutOk >= Rules.SelloutStep2) return selloutOk * Commission.SelloutStep2;
            if (selloutOk >= Rules.SelloutStep1) return selloutOk * Commission.SelloutStep1;
            else return selloutOk * Commission.DefaultSellout;
        }

        private int CalculateVolumenReward(int employeeVolume, int finalVol, int simOk, int selloutOk)
        {
            if (simOk < Rules.RequieredPSR || selloutOk < Rules.RequieredPSR) return 0;

            long multiplyResult = (long)employeeVolume * Commission.VolumePayment;
            double divisionResult = Math.Round((double)multiplyResult / finalVol);
            return (int)divisionResult;
        }
    }
}