using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arcane.Liquidador.Extentions;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Arcane.Liquidador
{
    public partial class MainForm : MaterialForm
    {
        private List<string> reportList = new List<string>();
        private List<MaterialTextBox> txtboxList = new List<MaterialTextBox>();

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(primary: Color.FromArgb(139, 181, 157),
                                                              darkPrimary: Color.FromArgb(92, 120, 104),
                                                              lightPrimary: Color.FromArgb(146, 165, 154),
                                                              accent: Color.FromArgb(241, 167, 173),
                                                              TextShade.BLACK);

            FillTxtboxList();
        }

        private void FillTxtboxList()
        {
            txtboxList.Add(TxtBox_ReportAgency);
            txtboxList.Add(Txtbox_ReportSim);
            txtboxList.Add(Txtbox_ReportSO);
        }

        private string ValidateFile()
        {
            reportList.SyncTxtboxContent(txtboxList);

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return string.Empty;

            var filePath = openFileDialog1.FileName;
            if (reportList.Contains(filePath))
            {
                MessageBox.Show("Este archivo ya fue seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }

            return filePath;
        }

        private void BtnAdd_ReportAgency_Click(object sender, EventArgs e)
        {
            TxtBox_ReportAgency.Text = ValidateFile();
        }

        private void BtnAdd_ReportSim_Click(object sender, EventArgs e)
        {
            Txtbox_ReportSim.Text = ValidateFile();
        }

        private void BtnAdd_ReportSO_Click(object sender, EventArgs e)
        {
            Txtbox_ReportSO.Text = ValidateFile();
        }
    }
}
