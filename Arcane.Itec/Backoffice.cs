using Arcane.Itec.Data;
using Arcane.Itec.DTO;
using Arcane.Itec.ReportManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec
{
    public class Backoffice
    {
        public CsvReportHandler _reportHandler;
        private CommissionValueDTO _commissions;

        public Backoffice(string[] reportPsrAgency, string[] reportSimPayment, string[] reportSoPayment, CommissionValueDTO commisionValues)
        {
            _commissions = commisionValues;
            _reportHandler = new CsvReportHandler(reportPsrAgency);
            _reportHandler.HandleSimRemuneration(reportSimPayment);
            _reportHandler.HandleSORemuneration(reportSoPayment, _commissions.SaleTarget);
        }

        public List<NonCompliantClients> GetNonCompliantClients()
        {
            var outputList = new List<NonCompliantClients>();
            foreach (var psr in _reportHandler.GetPSRs.Values)
            {
                if (!psr.SimOk)
                {
                    var nonCompliant = new NonCompliantClients
                    {
                        Id = psr.Id,
                        WalkerName = psr.WalkerName,
                        ClientName = psr.ClientName,
                        Sale = "No aplica",
                        Type = "SIM"
                    };
                    outputList.Add(nonCompliant);
                }
                if (!psr.SelloutOk)
                {
                    var nonCompliant = new NonCompliantClients
                    {
                        Id = psr.Id,
                        WalkerName = psr.WalkerName,
                        ClientName = psr.ClientName,
                        Sale = psr.MonthlySale.ToString(),
                        Type = "SELLOUT"
                    };
                    outputList.Add(nonCompliant);
                }
            }
            return outputList;
        }
    }
}
