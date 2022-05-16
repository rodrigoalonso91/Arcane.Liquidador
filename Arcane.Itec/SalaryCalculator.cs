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

        public SalaryCalculator(CommissionValue commission, CommisionRules rules)
        {
            Commission = commission;
            Rules = rules;
        }

        public Dictionary<string, Employee> GetEmployeesSalary(Dictionary<string, PSR> agencyPsr)
        {
            var employeesNames = agencyPsr.Values.Select(x => x.WalkerName).Distinct();
            var employees = new Dictionary<string, Employee>();

            var totalSimAmount = 0;
            var totalSimReward = 0;
            var totalSelloutAmount = 0;
            var totalSelloutReward = 0;

            var allVolumes = agencyPsr.Values.Select(x => x.MonthlySale).Aggregate((result, value) => result + value);
            var allVolumesRewards = 0;
            var allEmployeeSalary = 0;


            foreach (var name in employeesNames)
            {
                var psrFromThisEmployee = agencyPsr.Values.Where(psr => psr.WalkerName == name);
                var totalClients = psrFromThisEmployee.Count();

                var simOkAmount = psrFromThisEmployee.Where(psr => psr.SimOk).Count();
                totalSimAmount += simOkAmount;

                var selloutOkAmount = psrFromThisEmployee.Where(psr => psr.SelloutOk).Count();
                totalSelloutAmount += selloutOkAmount;

                var totalVolume = psrFromThisEmployee.Select(x => x.MonthlySale)
                                                     .Aggregate((result, value) => result + value);

                var simReward = CalculateSimReward(simOkAmount);
                totalSimReward += simReward;

                var selloutReward = CalculateSOReward(selloutOkAmount);
                totalSelloutReward += selloutReward;

                var volumeReward = CalculateVolumenReward(totalVolume, allVolumes, simOkAmount, selloutOkAmount);
                allVolumesRewards += volumeReward;

                var totalSalary = simReward + selloutReward + volumeReward;
                allEmployeeSalary += totalSalary;

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
                SimAmount = totalSimAmount,
                SimReward = "$ " + totalSimReward,
                SimPercentage = Utils.GetEfectivity(agencyPsr.Values.Count, totalSimAmount),
                SelloutAmount = totalSelloutAmount,
                SelloutReward = "$ " + totalSelloutReward,
                SelloutPercentage = Utils.GetEfectivity(agencyPsr.Values.Count, totalSelloutAmount),
                VolumeAmount = allVolumes,
                VolumeReward = "$ " + allVolumesRewards,
                TotalSalary = "$ " + allEmployeeSalary
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