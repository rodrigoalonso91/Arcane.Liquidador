using Arcane.Itec.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec
{
    public class Employee : IEmployee
    {
        public string Name { get ; set; }
        public int PsrAmount { get; set; }
        public int Salary { get; set; }
    }
}
