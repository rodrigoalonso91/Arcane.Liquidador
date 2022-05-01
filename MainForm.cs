using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arcane.Claro.Utils;
using Arcane.Liquidador.Abstractions;
using Arcane.Liquidador.Data;
using Arcane.Liquidador.Extentions;
using Arcane.Liquidador.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Arcane.Liquidador
{
    public partial class MainForm : MaterialForm
    {
        private bool _isStartUp = true;
        private List<string> ReportList { get; set; } = new List<string>();
        private List<MaterialTextBox> TxtboxObjectivesList { get; set; } = new List<MaterialTextBox>();
        private Dictionary<string, MaterialTextBox> TxtboxSettingsDict { get; set; } = new Dictionary<string, MaterialTextBox>();
        private IPsrObjectives ClientObjectives { get; set; }

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

            FillTxtboxReportList();
            FillTxtboxSettingsDict();
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

        #region Manage load and save settings
        private void MainForm_Load(object sender, EventArgs e)
        {
            _isStartUp = false;
            Switch_DarkMode.Checked = Settings.Default.darkMode;

            // Txtbox Hints
            Txtbox_Obj1Sim.Hint = Settings.Default.objSim1_hint;
            Txtbox_Obj2Sim.Hint = Settings.Default.objSim2_hint;
            Txtbox_Obj3Sim.Hint = Settings.Default.objSim3_hint;

            Txtbox_Obj1SO.Hint = Settings.Default.objSO1_hint;
            Txtbox_Obj2SO.Hint = Settings.Default.objSO2_hint;

            //Txtbox Settings Values
            TxtboxSettings_ObjSim1.Text = Utils.ExtractNumber(Settings.Default.objSim1_hint);
            TxtboxSettings_ObjSim2.Text = Utils.ExtractNumber(Settings.Default.objSim2_hint);
            TxtboxSettings_ObjSim3.Text = Utils.ExtractNumber(Settings.Default.objSim3_hint);

            TxtboxSettings_ObjSO1.Text = Utils.ExtractNumber(Settings.Default.objSO1_hint);
            TxtboxSettings_ObjSO2.Text = Utils.ExtractNumber(Settings.Default.objSO2_hint);

            // Txtbox Values
            Txtbox_DefaultSim.Text = Settings.Default.defaultSim_text;
            Txtbox_Obj1Sim.Text = Settings.Default.objSim1_text;
            Txtbox_Obj2Sim.Text = Settings.Default.objSim2_text;
            Txtbox_Obj3Sim.Text = Settings.Default.objSim3_text;

            Txtbox_DefaultSO.Text = Settings.Default.defaultSo_text;
            Txtbox_Obj1SO.Text = Settings.Default.objSO1_text;
            Txtbox_Obj2SO.Text = Settings.Default.objSO2_text;
            Txtbox_SalesTargetSO.Text = Settings.Default.saleTarget_text;

            Txtbox_volTarget.Text = Settings.Default.volumeTarget_text;
            Txtbox_volPayment.Text = Settings.Default.volumePayment_text;
            Txtbox_PsrReq.Text = Settings.Default.psrRequiered_text;
        }

        private void Txtbox_DefaultSim_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.defaultSim_text = Txtbox_DefaultSim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj1Sim_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.objSim1_text = Txtbox_Obj1Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj2Sim_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.objSim2_text = Txtbox_Obj2Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj3Sim_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.objSim3_text = Txtbox_Obj3Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_DefaultSO_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.defaultSo_text = Txtbox_DefaultSO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj1SO_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.objSO1_text = Txtbox_Obj1SO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj2SO_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.objSO2_text = Txtbox_Obj2SO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_SalesTargetSO_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.saleTarget_text = Txtbox_SalesTargetSO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_volTarget_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.volumeTarget_text = Txtbox_volTarget.Text;
            Settings.Default.Save();
        }
        private void Txtbox_volPayment_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.volumePayment_text = Txtbox_volPayment.Text;
            Settings.Default.Save();
        }
        private void Txtbox_PsrReq_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.psrRequiered_text = Txtbox_PsrReq.Text;
            Settings.Default.Save();
        }

        #endregion

        private void FillTxtboxReportList()
        {
            TxtboxObjectivesList.Add(TxtBox_ReportAgency);
            TxtboxObjectivesList.Add(Txtbox_ReportSim);
            TxtboxObjectivesList.Add(Txtbox_ReportSO);
        }
        private void FillTxtboxSettingsDict()
        {
            TxtboxSettingsDict.Clear();

            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.ObjSim1), TxtboxSettings_ObjSim1);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.ObjSim2), TxtboxSettings_ObjSim2);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.ObjSim3), TxtboxSettings_ObjSim3);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.ObjSO1), TxtboxSettings_ObjSO1);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.ObjSO2), TxtboxSettings_ObjSO2);
        }

        private string ValidateFile()
        {
            ReportList.SyncTxtboxContent(TxtboxObjectivesList);

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return string.Empty;

            var filePath = openFileDialog1.FileName;
            if (ReportList.Contains(filePath))
            {
                MessageBox.Show(Warnings.AlreadySelectedFile, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void TxtboxSettings_ObjSim1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsNumber(e);
        }
        #endregion

        private void BtnSave_ObjSettings_Click(object sender, EventArgs e)
        {
            FillTxtboxSettingsDict();

            if (IsSomeTxtEmpty())
            {
                MessageBox.Show(Warnings.EmptyFields, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ValidateObjectiveRules();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userConfirmation = MessageBox.Show(Warnings.ConfirmSave, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (userConfirmation is DialogResult.No) return;

            FillHintsForSim();
            FillHintsForSellout();
            SaveAndReloadForm(sender, e);
        }

        private bool IsSomeTxtEmpty()
        {
            return !TxtboxSettingsDict.Values.All(txtbox => !string.IsNullOrEmpty(txtbox.Text));
        }

        private void ValidateObjectiveRules()
        {
            var settingObjectives = new PsrObjectives(TxtboxSettingsDict);

            var isObj3LessThanObj2 = settingObjectives.ObjectiveSim3 <= settingObjectives.ObjectiveSim2;
            var isObj3LessThanObj1 = settingObjectives.ObjectiveSim3 <= settingObjectives.ObjectiveSim1;

            if (isObj3LessThanObj2 || isObj3LessThanObj1)
            {
                throw new ArgumentException(Erros.Error_Obj3);
            }

            var isObj1GreatherThanObj2 = settingObjectives.ObjectiveSim1 >= settingObjectives.ObjectiveSim2;
            var isObj1GreatherThanObj3 = settingObjectives.ObjectiveSim1 >= settingObjectives.ObjectiveSim3;

            if (isObj1GreatherThanObj2 || isObj1GreatherThanObj3)
            {
                throw new ArgumentException(Erros.Error_Obj1);
            }

            isObj1GreatherThanObj2 = settingObjectives.ObjectiveSO1 >= settingObjectives.ObjectiveSO2;

            if (isObj1GreatherThanObj2)
            {
                throw new ArgumentException(Erros.Error_Obj1);
            }
        }

        private void SaveAndReloadForm(object sender, EventArgs e)
        {
            Settings.Default.Save();
            MainForm_Load(sender, e);
        }

        private void FillHintsForSellout()
        {
            Settings.Default.objSO1_hint = Utils.MakeHintText(TxtboxSettings_ObjSO1.Text, "SO");
            Settings.Default.objSO2_hint = Utils.MakeHintText(TxtboxSettings_ObjSO2.Text, "SO");
        }

        private void FillHintsForSim()
        {
            Settings.Default.objSim1_hint = Utils.MakeHintText(TxtboxSettings_ObjSim1.Text, "Sim");
            Settings.Default.objSim2_hint = Utils.MakeHintText(TxtboxSettings_ObjSim2.Text, "Sim");
            Settings.Default.objSim3_hint = Utils.MakeHintText(TxtboxSettings_ObjSim3.Text, "Sim");
        }
    }
}
