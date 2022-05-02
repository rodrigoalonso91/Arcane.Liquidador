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
        public CsvReportHandler ReportHandler;
        private AgencyObjectivesDTO Objectives;

        public Backoffice(string[] reportPsrAgency, string[] reportSimPayment, string[] reportSoPayment, AgencyObjectivesDTO agencyObjectives)
        {
            ReportHandler = new CsvReportHandler(reportPsrAgency);
            ReportHandler.HandleSimRemuneration(reportSimPayment);
            ReportHandler.HandleSORemuneration(reportSoPayment, agencyObjectives.ClientSaleTarget);
            Objectives = agencyObjectives;
        }

        public List<NonCompliantClients> GetNonCompliantClients()
        {
            var outputList = new List<NonCompliantClients>();
            foreach (var psr in ReportHandler.GetResults.Values)
            {
                if (!psr.SimOk)
                {
                    var nonCompliant = new NonCompliantClients
                    {
                        PsrCode = psr.Codpsr,
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
                        PsrCode = psr.Codpsr,
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
