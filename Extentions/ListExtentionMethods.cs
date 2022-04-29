using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcane.Liquidador.Extentions
{
    public static class ListExtentionMethods
    {
        public static void SyncTxtboxContent(this List<string> reportList, List<MaterialTextBox> txtboxList)
        {
            reportList.Clear();
            txtboxList.ForEach(txtbox => reportList.Add(txtbox.Text));
        }

        public static void UpdateTxtboxSettingList(this List<MaterialButton> txtSettingList)
        {
            txtSettingList.Clear();
        }
    }
}
