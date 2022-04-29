using Arcane.Liquidador.Abstractions;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Liquidador.Data
{
    public class PsrObjectives : IPsrObjectives
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

        public PsrObjectives() { }
        public PsrObjectives(Dictionary<string, MaterialTextBox> txtboxDict)
        {
            ObjectiveSim1 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSim1)].Text);
            ObjectiveSim2 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSim2)].Text);
            ObjectiveSim3 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSim3)].Text);
            ObjectiveSO1 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSO1)].Text);
            ObjectiveSO2 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSO2)].Text);
        }
    }
}
