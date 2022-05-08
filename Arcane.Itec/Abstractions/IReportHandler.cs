using Arcane.Itec.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec.Abstractions
{
    public interface IReportHandler
    {
        Dictionary<string, PSR> GetPSRs();
        Dictionary<string, PSR> HandleAgencyPsr(string[] reportPsrAgency);
        Dictionary<string, PSR> HandleSimRemuneration(string[] reportSimPaying);
        Dictionary<string, PSR> HandleSORemuneration(string[] reportSOPaying, int sellTargetSO);
    }
}
