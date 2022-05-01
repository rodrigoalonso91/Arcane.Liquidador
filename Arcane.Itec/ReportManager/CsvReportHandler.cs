using Arcane.Itec.Data;
using Arcane.Itec.ItecUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec.ReportManager
{
    public class CsvReportHandler
    {
        private Dictionary<string, PSR> PsrFromAgency;
        public Dictionary<string, PSR> GetResults => PsrFromAgency;


        public static Dictionary<string, PSR> ExtractAgencyPsr(string[] reportPsrAgency)
        {
            var psrFromAgency = new Dictionary<string, PSR>();
            var reportLength = reportPsrAgency.Length;

            for (int i = (int)ReportAgencyIndexs.ReportStartIndex; i < reportLength; i++)
            {
                var reportFields = reportPsrAgency[i].Split(';');

                var client = new PSR
                {
                    Codpsr = reportFields[(int)ReportAgencyIndexs.PsrCode],
                    ClientName = reportFields[(int)ReportAgencyIndexs.PsrName],
                    Address = reportFields[(int)ReportAgencyIndexs.Address],
                    NumberAddress = reportFields[(int)ReportAgencyIndexs.AddressNum],
                    WalkerName = reportFields[(int)ReportAgencyIndexs.WalkerName]
                };
                psrFromAgency[client.Codpsr] = client;
            }

            return psrFromAgency;
        }

        public Dictionary<string, PSR> ExtractInfoRemuneration(string[] reportSimPaying)
        {
            if (PsrFromAgency is null) throw new FieldAccessException(message: "No se encontraron PSR de la agencia, intente invocar primero a 'GetPsrFromReport'");

            var reportLength = reportSimPaying.Length;
            for (int i = (int)ReportSimPaymentIndexs.ReportStartIndex; i < reportLength; i++)
            {
                var reportFields = reportSimPaying[i].Split(';');
                var psrCode = Utils.NormalizePsrCode(reportFields, ((int)ReportSimPaymentIndexs.PsrCode));

                var commision = reportFields[(int)ReportSimPaymentIndexs.SimCommision];
                commision = Utils.ExtractNumber(commision);

                if (PsrFromAgency.ContainsKey(psrCode) && !string.IsNullOrWhiteSpace(commision))
                {
                    PsrFromAgency[psrCode].SimOk = true;
                }
            }
            return PsrFromAgency;
        }
    }
}
