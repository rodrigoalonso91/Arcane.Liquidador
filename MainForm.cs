﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arcane.Itec;
using Arcane.Itec.DTO;
using Arcane.Itec.Extentions;
using Arcane.Itec.ItecUtils;
using Arcane.Itec.ReportManager;
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
        private List<string> TxtboxPathsList { get; set; } = new List<string>();
        private List<MaterialTextBox> TxtboxReportsList { get; set; } = new List<MaterialTextBox>();
        private Dictionary<string, MaterialTextBox> TxtboxSettingsDict { get; set; } = new Dictionary<string, MaterialTextBox>();

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
            Settings.Default.DarkMode = Switch_DarkMode.Checked;
            Settings.Default.Save();
        }

        #region Manage load and save settings
        private void MainForm_Load(object sender, EventArgs e)
        {
            _isStartUp = false;
            Switch_DarkMode.Checked = Settings.Default.DarkMode;

            // Txtbox Hints
            Txtbox_Step1Sim.Hint = Settings.Default.SimStep1_hint;
            Txtbox_Step2Sim.Hint = Settings.Default.SimStep2_hint;
            Txtbox_Step3Sim.Hint = Settings.Default.SimStep3_hint;

            Txtbox_Step1SO.Hint = Settings.Default.SOStep1_hint;
            Txtbox_Step2SO.Hint = Settings.Default.SOStep2_hint;

            //Txtbox Settings Values
            TxtboxSettings_SimStep1.Text = Utils.ExtractNumber(Settings.Default.SimStep1_hint);
            TxtboxSettings_SimStep2.Text = Utils.ExtractNumber(Settings.Default.SimStep2_hint);
            TxtboxSettings_SimStep3.Text = Utils.ExtractNumber(Settings.Default.SimStep3_hint);

            TxtboxSettings_SelloutStep1.Text = Utils.ExtractNumber(Settings.Default.SOStep1_hint);
            TxtboxSettings_SelloutStep2.Text = Utils.ExtractNumber(Settings.Default.SOStep2_hint);

            // Txtbox Values
            Txtbox_DefaultSim.Text = Settings.Default.defaultSim_text;
            Txtbox_Step1Sim.Text = Settings.Default.SimStep1_text;
            Txtbox_Step2Sim.Text = Settings.Default.SimStep2_text;
            Txtbox_Step3Sim.Text = Settings.Default.SimStep3_text;

            Txtbox_DefaultSO.Text = Settings.Default.defaultSo_text;
            Txtbox_Step1SO.Text = Settings.Default.SOStep1_text;
            Txtbox_Step2SO.Text = Settings.Default.SOStep2_text;
            Txtbox_SalesTargetSO.Text = Settings.Default.SaleTarget_text;

            Txtbox_VolTarget.Text = Settings.Default.VolumeTarget_text;
            Txtbox_VolPayment.Text = Settings.Default.VolumePayment_text;
            Txtbox_PsrRequiered.Text = Settings.Default.PsrRequiered_text;
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
            Settings.Default.SimStep1_text = Txtbox_Step1Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj2Sim_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.SimStep2_text = Txtbox_Step2Sim.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj3Sim_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.SimStep3_text = Txtbox_Step3Sim.Text;
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
            Settings.Default.SOStep1_text = Txtbox_Step1SO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_Obj2SO_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.SOStep2_text = Txtbox_Step2SO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_SalesTargetSO_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.SaleTarget_text = Txtbox_SalesTargetSO.Text;
            Settings.Default.Save();
        }
        private void Txtbox_volTarget_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.VolumeTarget_text = Txtbox_VolTarget.Text;
            Settings.Default.Save();
        }
        private void Txtbox_volPayment_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.VolumePayment_text = Txtbox_VolPayment.Text;
            Settings.Default.Save();
        }
        private void Txtbox_PsrReq_TextChanged(object sender, EventArgs e)
        {
            if (_isStartUp) return;
            Settings.Default.PsrRequiered_text = Txtbox_PsrRequiered.Text;
            Settings.Default.Save();
        }

        #endregion

        private void FillTxtboxReportList()
        {
            TxtboxReportsList.Add(TxtBox_ReportAgency);
            TxtboxReportsList.Add(Txtbox_ReportSim);
            TxtboxReportsList.Add(Txtbox_ReportSO);
        }
        private void FillTxtboxSettingsDict()
        {
            TxtboxSettingsDict.Clear();

            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.SimStep1), TxtboxSettings_SimStep1);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.SimStep2), TxtboxSettings_SimStep2);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.SimStep3), TxtboxSettings_SimStep3);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.SelloutStep1), TxtboxSettings_SelloutStep1);
            TxtboxSettingsDict.Add(nameof(ObjectiveTypes.SelloutStep2), TxtboxSettings_SelloutStep2);
        }
        private string ValidateFile()
        {
            TxtboxPathsList.SyncTxtboxContent(TxtboxReportsList);

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return string.Empty;

            var filePath = openFileDialog1.FileName;
            if (TxtboxPathsList.Contains(filePath))
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



        private bool IsSomeTxtEmpty()
        {
            return !TxtboxSettingsDict.Values.All(txtbox => !string.IsNullOrEmpty(txtbox.Text));
        }

        private void ValidateObjectiveRules()
        {
            var settingObjectives = new HintSettings(TxtboxSettingsDict);

            var isObj3LessThanObj2 = settingObjectives.SimStep3 <= settingObjectives.SimStep2;
            var isObj3LessThanObj1 = settingObjectives.SimStep3 <= settingObjectives.SimStep1;

            if (isObj3LessThanObj2 || isObj3LessThanObj1)
            {
                throw new ArgumentException(Erros.Error_Step3);
            }

            var isObj1GreatherThanObj2 = settingObjectives.SimStep1 >= settingObjectives.SimStep2;
            var isObj1GreatherThanObj3 = settingObjectives.SimStep1 >= settingObjectives.SimStep3;

            if (isObj1GreatherThanObj2 || isObj1GreatherThanObj3)
            {
                throw new ArgumentException(Erros.Error_Step1);
            }

            isObj1GreatherThanObj2 = settingObjectives.SelloutStep1 >= settingObjectives.SelloutStep2;

            if (isObj1GreatherThanObj2)
            {
                throw new ArgumentException(Erros.Error_Step1);
            }
        }

        private void SaveAndReloadForm(object sender, EventArgs e)
        {
            Settings.Default.Save();
            MainForm_Load(sender, e);
        }

        private void FillHintsForSellout()
        {
            Settings.Default.SOStep1_hint = Utils.MakeHintText(TxtboxSettings_SelloutStep1.Text, "SO");
            Settings.Default.SOStep2_hint = Utils.MakeHintText(TxtboxSettings_SelloutStep2.Text, "SO");
        }

        private void FillHintsForSim()
        {
            Settings.Default.SimStep1_hint = Utils.MakeHintText(TxtboxSettings_SimStep1.Text, "Sim");
            Settings.Default.SimStep2_hint = Utils.MakeHintText(TxtboxSettings_SimStep2.Text, "Sim");
            Settings.Default.SimStep3_hint = Utils.MakeHintText(TxtboxSettings_SimStep3.Text, "Sim");
        }

        private void Btn_GetPaymentsResults_Click(object sender, EventArgs e)
        {
            if (AnyReportMissing())
            {
                MessageBox.Show(Warnings.ReportMissing, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var allObjValues = GetValuesFromObjTxtBox();
            if (allObjValues.Exists(item => string.IsNullOrEmpty(item)))
            {
                MessageBox.Show(Warnings.EmptyFields, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] reportPsrAgency = File.ReadAllLines(TxtBox_ReportAgency.Text);
            string[] reportPayingSim = File.ReadAllLines(Txtbox_ReportSim.Text);
            string[] reportPayingSO = File.ReadAllLines(Txtbox_ReportSO.Text);

            var listObjValues = allObjValues.ConvertValuesToInt();
            var objectivesDTO = new AgencyObjectivesDTO
            {
                DefaultSim = listObjValues[(int)ObjectiveIndex.DefaultSim],
                ObjectiveSim1 = listObjValues[(int)ObjectiveIndex.Obj1Sim],
                ObjectiveSim2 = listObjValues[(int)ObjectiveIndex.Obj2Sim],
                ObjectiveSim3 = listObjValues[(int)ObjectiveIndex.Obj3Sim],
                DefaultSellout = listObjValues[(int)ObjectiveIndex.DefaultSO],
                ObjectiveSO1 = listObjValues[(int)ObjectiveIndex.Obj1SO],
                ObjectiveSO2 = listObjValues[(int)ObjectiveIndex.Obj2SO],
                ClientSaleTarget = listObjValues[(int)ObjectiveIndex.SaleTarget],
                VolumeTarget = listObjValues[(int)ObjectiveIndex.VolTarget],
                VolumePayment = listObjValues[(int)ObjectiveIndex.VolPayment]
            };

            var backoffice = new Backoffice(reportPsrAgency, reportPayingSim, reportPayingSO, objectivesDTO);


            GridControl_Clients.DataSource = backoffice.GetNonCompliantClients();
            TabControl_Main.SelectedTab = TabPage_Pagos;
        }

        private bool AnyReportMissing()
        {
            TxtboxPathsList.SyncTxtboxContent(TxtboxReportsList);
            return TxtboxPathsList.Exists(item => string.IsNullOrEmpty(item));
        }

        private List<string> GetValuesFromObjTxtBox()
        {
            var output = new List<string>();
            output.Insert((int)ObjectiveIndex.DefaultSim, Txtbox_DefaultSim.Text);
            output.Insert((int)ObjectiveIndex.Obj1Sim, Txtbox_Step1Sim.Text);
            output.Insert((int)ObjectiveIndex.Obj2Sim, Txtbox_Step2Sim.Text);
            output.Insert((int)ObjectiveIndex.Obj3Sim, Txtbox_Step3Sim.Text);
            output.Insert((int)ObjectiveIndex.DefaultSO, Txtbox_DefaultSO.Text);
            output.Insert((int)ObjectiveIndex.Obj1SO, Txtbox_Step1SO.Text);
            output.Insert((int)ObjectiveIndex.Obj2SO, Txtbox_Step2SO.Text);
            output.Insert((int)ObjectiveIndex.SaleTarget, Txtbox_SalesTargetSO.Text);
            output.Insert((int)ObjectiveIndex.VolTarget, Txtbox_VolTarget.Text);
            output.Insert((int)ObjectiveIndex.VolPayment, Txtbox_VolPayment.Text);
            output.Insert((int)ObjectiveIndex.PsrRequiered, Txtbox_PsrRequiered.Text);

            return output;
        }

        private void BtnSave_StepsSettings_Click(object sender, EventArgs e)
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
    }
}
