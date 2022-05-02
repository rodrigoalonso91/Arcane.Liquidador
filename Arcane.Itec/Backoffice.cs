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
    }
}
