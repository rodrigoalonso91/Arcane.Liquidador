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

            foreach (var name in employeesNames)
            {
                var psrFromThisEmployee = agencyPsr.Values.Where(psr => psr.WalkerName == name);
                var totalClients = psrFromThisEmployee.Count();
                var simOkAmount = psrFromThisEmployee.Where(psr => psr.SimOk).Count();
                var selloutOkAmount = psrFromThisEmployee.Where(psr => psr.SelloutOk).Count();
                var totalVolume = psrFromThisEmployee.Select(x => x.MonthlySale)
                                                     .Aggregate((result, value) => result + value);

                employees.Add(name, new Employee()
                {
                    Name = name,
                    PsrAmount = totalClients,
                    SimAmount = simOkAmount,
                    SimReward = CalculateSimReward(simOkAmount),
                    SimPercentage = Utils.GetEfectivity(totalClients, simOkAmount),
                    SelloutAmount = selloutOkAmount,
                    SelloutReward = CalculateSOReward(selloutOkAmount),
                    SelloutPercentage = Utils.GetEfectivity(totalClients, selloutOkAmount),
                    VolumeAmount = totalVolume,
                    VolumeReward = CalculateVolumenReward(totalVolume, simOkAmount, selloutOkAmount),
                });
                employees[name].TotalSalary = employees[name].SimReward + employees[name].SelloutReward + employees[name].VolumeReward;
            }
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

        private int CalculateVolumenReward(int employeeVolume, int simOk, int selloutOk)
        {
            if (simOk < Rules.RequieredPSR || selloutOk < Rules.RequieredPSR) return 0;

            long multiplyResult = (long)employeeVolume * Commission.VolumePayment;
            double divisionResult = Math.Round((double)multiplyResult / Commission.VolumeTarget);
            return (int)divisionResult;
        }
    }
}