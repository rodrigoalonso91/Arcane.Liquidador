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
using Arcane.Liquidador.Properties;
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

        #region Manage Key Press Events
        private bool IsNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) return true;
            else return false;
        }

        private void Txtbox_DefaultSim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void Txtbox_Obj1Sim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void Txtbox_Obj2Sim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void Txtbox_Obj3Sim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void Txtbox_DefaultSO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void Txtbox_Obj1SO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void Txtbox_Obj2SO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        private void Txtbox_SalesTargetSO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        #endregion
        private void SaveTextBoxValue(string text, string key)
        {
            Settings.Default[key] = text;
            Settings.Default.Save();
        }

        private void Txtbox_DefaultSim_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_DefaultSim.Text, key: "defaultSim");
        }
        private void Txtbox_Obj1Sim_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_Obj1Sim.Text, key: "objSim1");
        }
        private void Txtbox_Obj2Sim_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_Obj2Sim.Text, key: "objSim2");
        }
        private void Txtbox_Obj3Sim_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_Obj3Sim.Text, key: "objSim3");
        }
        private void Txtbox_DefaultSO_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_DefaultSO.Text, key: "defaultSO");
        }
        private void Txtbox_Obj1SO_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_Obj1SO.Text, key: "objSO1");
        }
        private void Txtbox_Obj2SO_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_Obj2SO.Text, key: "objSO2");
        }
        private void Txtbox_SalesTargetSO_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_SalesTargetSO.Text, key: "saleTarget");
        }
        private void Txtbox_volTarget_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_volTarget.Text, key: "volumeTarget");
        }
        private void Txtbox_volPayment_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_volPayment.Text, key: "volumePayment");
        }
        private void Txtbox_PsrReq_TextChanged(object sender, EventArgs e)
        {
            SaveTextBoxValue(Txtbox_PsrReq.Text, key: "psrRequiered");
        }
    }
}
