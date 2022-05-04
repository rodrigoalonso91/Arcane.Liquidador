using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec.Abstractions
{
    public interface IEmployee
    {
        string Name { get; set; }
        int PsrAmount { get; set; }
        int Salary { get; set; }
    }
}
