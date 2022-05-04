using Arcane.Itec.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec
{
    public class SalaryCalculator
    {
        public IEmployee _employee;
        public SalaryCalculator(IEmployee employee)
        {
            _employee = employee;
        }
    }
}
