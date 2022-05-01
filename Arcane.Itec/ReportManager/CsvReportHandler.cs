using Arcane.Itec.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec.ReportManager
{
    public class CsvReportHandler
    { 
        public static Dictionary<string, PSR> GetPsrFromReport(string[] reportPsrAgency)
        {
            var psrFromAgency = new Dictionary<string, PSR>();
            var reportLength = reportPsrAgency.Length;

            for (int i = (int)ReportAgencyIndexs.ReportStartIndex; i < reportLength; i++)
            {
                var reportFields = reportPsrAgency[i].Split(';');

                var client = new PSR
                {
                    Codpsr = reportFields[((int)ReportAgencyIndexs.PsrCode)],
                    ClientName = reportFields[((int)ReportAgencyIndexs.PsrName)],
                    Address = reportFields[((int)ReportAgencyIndexs.Address)],
                    NumberAddress = reportFields[((int)ReportAgencyIndexs.AddressNum)],
                    WalkerName = reportFields[((int)ReportAgencyIndexs.WalkerName)]
                };
                psrFromAgency[client.Codpsr] = client;
            }

            return psrFromAgency;
        }
    }
}
