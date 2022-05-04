using MaterialSkin.Controls;
using System;
using System.Collections.Generic;

namespace Arcane.Liquidador.Data
{
    public class HintSettings
    {
        public int SimStep1 { get; }
        public int SimStep2 { get; }
        public int SimStep3 { get; }
        public int SelloutStep1 { get; }
        public int SelloutStep2 { get; }

        public HintSettings(Dictionary<string, MaterialTextBox> txtboxDict)
        {
            SimStep1 = Convert.ToInt32(txtboxDict[nameof(StepTypes.SimStep1)].Text);
            SimStep2 = Convert.ToInt32(txtboxDict[nameof(StepTypes.SimStep2)].Text);
            SimStep3 = Convert.ToInt32(txtboxDict[nameof(StepTypes.SimStep3)].Text);
            SelloutStep1 = Convert.ToInt32(txtboxDict[nameof(StepTypes.SelloutStep1)].Text);
            SelloutStep2 = Convert.ToInt32(txtboxDict[nameof(StepTypes.SelloutStep2)].Text);
        }
    }
}