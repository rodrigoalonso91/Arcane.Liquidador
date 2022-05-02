using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Liquidador.Data
{
    public class HintSettings
    {
        public int ObjectiveSim1 { get; }
        public int ObjectiveSim2 { get; }
        public int ObjectiveSim3 { get; }
        public int ObjectiveSO1 { get; }
        public int ObjectiveSO2 { get; }

        public HintSettings(Dictionary<string, MaterialTextBox> txtboxDict)
        {
            ObjectiveSim1 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSim1)].Text);
            ObjectiveSim2 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSim2)].Text);
            ObjectiveSim3 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSim3)].Text);
            ObjectiveSO1 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSO1)].Text);
            ObjectiveSO2 = Convert.ToInt32(txtboxDict[nameof(ObjectiveTypes.ObjSO2)].Text);
        }
    }
}
