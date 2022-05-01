﻿using Arcane.Itec.Data;
using Arcane.Itec.ItecUtils;
using System.Collections.Generic;

namespace Arcane.Itec.ReportManager
{
    public class CsvReportHandler
    {
        private readonly Dictionary<string, PSR> PsrFromAgency;
        public Dictionary<string, PSR> GetResults => PsrFromAgency;

        public CsvReportHandler(string[] reportPsrAgency)
        {
            PsrFromAgency = new Dictionary<string, PSR>();
            ExtractAgencyPsr(reportPsrAgency);
        }

        private void ExtractAgencyPsr(string[] reportPsrAgency)
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
        }

        public Dictionary<string, PSR> ExtractSimRemuneration(string[] reportSimPaying)
        {
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

        public Dictionary<string, PSR> ExtractSORemuneration(string[] reportSOPaying, int sellTargetSO)
        {
            var reportLength = reportSOPaying.Length;

            for (int i = (int)ReportSOPaymentIndexs.ReportStartIndex; i < reportLength; i++)
            {
                var reportFiels = reportSOPaying[i].Split(';');
                var psrCode = Utils.NormalizePsrCode(reportFiels, (int)ReportSOPaymentIndexs.PsrCode);
                var monthlySale = reportFiels[(int)ReportSOPaymentIndexs.TotalSale];

                if (PsrFromAgency.ContainsKey(psrCode))
                {
                    PsrFromAgency[psrCode].MonthlySale = int.Parse(monthlySale);
                    PsrFromAgency[psrCode].SelloutOk = PsrFromAgency[psrCode].MonthlySale >= sellTargetSO;
                }
            }
            return PsrFromAgency;
        }
    }
}