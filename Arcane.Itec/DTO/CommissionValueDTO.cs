using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec.DTO
{
    public class CommissionValueDTO
    {
        public int DefaultSim { get; set; }
        public int SimStep1 { get; set; }
        public int SimStep2 { get; set; }
        public int SimStep3 { get; set; }
        public int DefaultSellout { get; set; }
        public int SelloutStep1 { get; set; }
        public int SelloutStep2 { get; set; }
        public int SaleTarget { get; set; }
        public int VolumeTarget { get; set; }
        public int VolumePayment { get; set; }
    }
}
