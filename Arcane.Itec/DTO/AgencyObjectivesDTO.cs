using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Itec.DTO
{
    public class AgencyObjectivesDTO
    {
        public int DefaultSim { get; set; }
        public int ObjectiveSim1 { get; set; }
        public int ObjectiveSim2 { get; set; }
        public int ObjectiveSim3 { get; set; }
        public int DefaultSellout { get; set; }
        public int ObjectiveSO1 { get; set; }
        public int ObjectiveSO2 { get; set; }
        public int ClientSaleTarget { get; set; }
        public int VolumeTarget { get; set; }
        public int VolumePayment { get; set; }
    }
}
