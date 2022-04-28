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
        private bool isStartUp = true;

        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = SetTheme();
            materialSkinManager.ColorScheme = new ColorScheme(primary: Color.FromArgb(139, 181, 157),
                                                              darkPrimary: Color.FromArgb(92, 120, 104),
                                                              lightPrimary: Color.FromArgb(146, 165, 154),
                                                              accent: Color.FromArgb(241, 167, 173),
                                                              TextShade.BLACK);

            FillTxtboxList();
        }

        private MaterialSkinManager.Themes SetTheme()
        {
            if (Switch_DarkMode.Checked) return MaterialSkinManager.Themes.DARK;
            else return MaterialSkinManager.Themes.LIGHT;
        }

        private void Switch_DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkinManager.Instance.Theme = SetTheme();
        }

        private void Switch_DarkMode_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default.darkMode = Switch_DarkMode.Checked;
            Settings.Default.Save();
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

        #region Manage load and save settings
        private void MainForm_Load(object sender, EventArgs e)
        {
            isStartUp = false;
            Switch_DarkMode.Checked = Settings.Default.darkMode;

            Txtbox_DefaultSim.Text = Settings.Default.defaultSim;
            Txtbox_Obj1Sim.Text = Settings.Default.objSim1;
            Txtbox_Obj2Sim.Text = Settings.Default.objSim2;
            Txtbox_Obj3Sim.Text = Settings.Default.objSim3;

            Txtbox_DefaultSO.Text = Settings.Default.defaultSo;
            Txtbox_Obj1SO.Text = Settings.Default.objSO1;
            Txtbox_Obj2SO.Text = Settings.Default.objSO2;
            Txtbox_SalesTargetSO.Text = Settings.Default.saleTarget;

            Txtbox_volTarget.Text = Settings.Default.volumeTarget;
            Txtbox_volPayment.Text = Settings.Default.volumePayment;
            Txtbox_PsrReq.Text = Settings.Default.psrRequiered;
        }

        private void Txtbox_DefaultSim_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.defaultSim = Txtbox_DefaultSim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj1Sim_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.objSim1 = Txtbox_Obj1Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj2Sim_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.objSim2 = Txtbox_Obj2Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj3Sim_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.objSim3 = Txtbox_Obj3Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_DefaultSO_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.defaultSo = Txtbox_DefaultSO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj1SO_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.objSO1 = Txtbox_Obj1SO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj2SO_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.objSO2 = Txtbox_Obj2SO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_SalesTargetSO_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.saleTarget = Txtbox_SalesTargetSO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_volTarget_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.volumeTarget = Txtbox_volTarget.Text;
            Settings.Default.Save();
        }
        private void Txtbox_volPayment_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.volumePayment = Txtbox_volPayment.Text;
            Settings.Default.Save();
        }
        private void Txtbox_PsrReq_TextChanged(object sender, EventArgs e)
        {
            if (isStartUp) return;
            Settings.Default.psrRequiered = Txtbox_PsrReq.Text;
            Settings.Default.Save();
        }

        #endregion
    }
}
