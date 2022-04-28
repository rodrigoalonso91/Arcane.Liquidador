
namespace Arcane.Liquidador
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Dgv_Payments = new MaterialSkin.Controls.MaterialTabControl();
            this.TabPage_Home = new System.Windows.Forms.TabPage();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.Btn_GetPaymentsResults = new MaterialSkin.Controls.MaterialButton();
            this.MDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.MDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.BtnAdd_ReportSO = new MaterialSkin.Controls.MaterialButton();
            this.Txtbox_DefaultSim = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnAdd_ReportSim = new MaterialSkin.Controls.MaterialButton();
            this.Txtbox_DefaultSO = new MaterialSkin.Controls.MaterialTextBox();
            this.BtnAdd_ReportAgency = new MaterialSkin.Controls.MaterialButton();
            this.Txtbox_Obj1Sim = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtbox_ReportSO = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtbox_Obj2Sim = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtbox_ReportSim = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtbox_Obj3Sim = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtBox_ReportAgency = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtbox_SalesTargetSO = new MaterialSkin.Controls.MaterialTextBox();
            this.MCard_ReportView = new MaterialSkin.Controls.MaterialCard();
            this.PicBox_Logo = new System.Windows.Forms.PictureBox();
            this.MLTxtBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.Lbl_FormatDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox9 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox10 = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtbox_Obj1SO = new MaterialSkin.Controls.MaterialTextBox();
            this.Txtbox_Obj2SO = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox11 = new MaterialSkin.Controls.MaterialTextBox();
            this.TabPage_Pagos = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabPage_Settings = new System.Windows.Forms.TabPage();
            this.ImgList_Menu = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Dgv_Payments.SuspendLayout();
            this.TabPage_Home.SuspendLayout();
            this.MCard_ReportView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Logo)).BeginInit();
            this.TabPage_Pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Payments
            // 
            this.Dgv_Payments.Controls.Add(this.TabPage_Home);
            this.Dgv_Payments.Controls.Add(this.TabPage_Pagos);
            this.Dgv_Payments.Controls.Add(this.TabPage_Settings);
            this.Dgv_Payments.Depth = 0;
            this.Dgv_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Payments.ImageList = this.ImgList_Menu;
            this.Dgv_Payments.Location = new System.Drawing.Point(3, 94);
            this.Dgv_Payments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgv_Payments.MouseState = MaterialSkin.MouseState.HOVER;
            this.Dgv_Payments.Multiline = true;
            this.Dgv_Payments.Name = "Dgv_Payments";
            this.Dgv_Payments.SelectedIndex = 0;
            this.Dgv_Payments.Size = new System.Drawing.Size(1144, 574);
            this.Dgv_Payments.TabIndex = 0;
            // 
            // TabPage_Home
            // 
            this.TabPage_Home.Controls.Add(this.materialDivider2);
            this.TabPage_Home.Controls.Add(this.Btn_GetPaymentsResults);
            this.TabPage_Home.Controls.Add(this.MDivider1);
            this.TabPage_Home.Controls.Add(this.MDivider2);
            this.TabPage_Home.Controls.Add(this.BtnAdd_ReportSO);
            this.TabPage_Home.Controls.Add(this.Txtbox_DefaultSim);
            this.TabPage_Home.Controls.Add(this.BtnAdd_ReportSim);
            this.TabPage_Home.Controls.Add(this.Txtbox_DefaultSO);
            this.TabPage_Home.Controls.Add(this.BtnAdd_ReportAgency);
            this.TabPage_Home.Controls.Add(this.Txtbox_Obj1Sim);
            this.TabPage_Home.Controls.Add(this.Txtbox_ReportSO);
            this.TabPage_Home.Controls.Add(this.Txtbox_Obj2Sim);
            this.TabPage_Home.Controls.Add(this.Txtbox_ReportSim);
            this.TabPage_Home.Controls.Add(this.Txtbox_Obj3Sim);
            this.TabPage_Home.Controls.Add(this.TxtBox_ReportAgency);
            this.TabPage_Home.Controls.Add(this.Txtbox_SalesTargetSO);
            this.TabPage_Home.Controls.Add(this.MCard_ReportView);
            this.TabPage_Home.Controls.Add(this.materialTextBox9);
            this.TabPage_Home.Controls.Add(this.materialTextBox10);
            this.TabPage_Home.Controls.Add(this.Txtbox_Obj1SO);
            this.TabPage_Home.Controls.Add(this.Txtbox_Obj2SO);
            this.TabPage_Home.Controls.Add(this.materialTextBox11);
            this.TabPage_Home.ImageKey = "home_FILL0_wght400_GRAD0_opsz48.png";
            this.TabPage_Home.Location = new System.Drawing.Point(4, 39);
            this.TabPage_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage_Home.Name = "TabPage_Home";
            this.TabPage_Home.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage_Home.Size = new System.Drawing.Size(1136, 531);
            this.TabPage_Home.TabIndex = 0;
            this.TabPage_Home.Text = "Home";
            this.TabPage_Home.UseVisualStyleBackColor = true;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(65, 430);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(474, 10);
            this.materialDivider2.TabIndex = 0;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // Btn_GetPaymentsResults
            // 
            this.Btn_GetPaymentsResults.AutoSize = false;
            this.Btn_GetPaymentsResults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_GetPaymentsResults.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Btn_GetPaymentsResults.Depth = 0;
            this.Btn_GetPaymentsResults.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetPaymentsResults.HighEmphasis = true;
            this.Btn_GetPaymentsResults.Icon = null;
            this.Btn_GetPaymentsResults.Location = new System.Drawing.Point(65, 466);
            this.Btn_GetPaymentsResults.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btn_GetPaymentsResults.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btn_GetPaymentsResults.Name = "Btn_GetPaymentsResults";
            this.Btn_GetPaymentsResults.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Btn_GetPaymentsResults.Size = new System.Drawing.Size(472, 70);
            this.Btn_GetPaymentsResults.TabIndex = 0;
            this.Btn_GetPaymentsResults.Text = "Calcular Resultados";
            this.Btn_GetPaymentsResults.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Btn_GetPaymentsResults.UseAccentColor = false;
            this.Btn_GetPaymentsResults.UseVisualStyleBackColor = true;
            // 
            // MDivider1
            // 
            this.MDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MDivider1.Depth = 0;
            this.MDivider1.Location = new System.Drawing.Point(65, 202);
            this.MDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.MDivider1.Name = "MDivider1";
            this.MDivider1.Size = new System.Drawing.Size(474, 10);
            this.MDivider1.TabIndex = 0;
            this.MDivider1.Text = "materialDivider1";
            // 
            // MDivider2
            // 
            this.MDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MDivider2.Depth = 0;
            this.MDivider2.Location = new System.Drawing.Point(65, 346);
            this.MDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.MDivider2.Name = "MDivider2";
            this.MDivider2.Size = new System.Drawing.Size(474, 10);
            this.MDivider2.TabIndex = 0;
            this.MDivider2.Text = "materialDivider1";
            // 
            // BtnAdd_ReportSO
            // 
            this.BtnAdd_ReportSO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd_ReportSO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAdd_ReportSO.Depth = 0;
            this.BtnAdd_ReportSO.HighEmphasis = true;
            this.BtnAdd_ReportSO.Icon = null;
            this.BtnAdd_ReportSO.Location = new System.Drawing.Point(451, 139);
            this.BtnAdd_ReportSO.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnAdd_ReportSO.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd_ReportSO.Name = "BtnAdd_ReportSO";
            this.BtnAdd_ReportSO.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd_ReportSO.Size = new System.Drawing.Size(88, 36);
            this.BtnAdd_ReportSO.TabIndex = 0;
            this.BtnAdd_ReportSO.Text = "Agregar";
            this.BtnAdd_ReportSO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAdd_ReportSO.UseAccentColor = false;
            this.BtnAdd_ReportSO.UseVisualStyleBackColor = true;
            this.BtnAdd_ReportSO.Click += new System.EventHandler(this.BtnAdd_ReportSO_Click);
            // 
            // Txtbox_DefaultSim
            // 
            this.Txtbox_DefaultSim.AnimateReadOnly = false;
            this.Txtbox_DefaultSim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_DefaultSim.Depth = 0;
            this.Txtbox_DefaultSim.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_DefaultSim.Hint = "Default Sim";
            this.Txtbox_DefaultSim.LeadingIcon = null;
            this.Txtbox_DefaultSim.Location = new System.Drawing.Point(65, 225);
            this.Txtbox_DefaultSim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_DefaultSim.MaxLength = 50;
            this.Txtbox_DefaultSim.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_DefaultSim.Multiline = false;
            this.Txtbox_DefaultSim.Name = "Txtbox_DefaultSim";
            this.Txtbox_DefaultSim.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_DefaultSim.TabIndex = 3;
            this.Txtbox_DefaultSim.Text = "";
            this.Txtbox_DefaultSim.TrailingIcon = null;
            this.Txtbox_DefaultSim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_DefaultSim_KeyPress);
            // 
            // BtnAdd_ReportSim
            // 
            this.BtnAdd_ReportSim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd_ReportSim.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAdd_ReportSim.Depth = 0;
            this.BtnAdd_ReportSim.HighEmphasis = true;
            this.BtnAdd_ReportSim.Icon = null;
            this.BtnAdd_ReportSim.Location = new System.Drawing.Point(451, 82);
            this.BtnAdd_ReportSim.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnAdd_ReportSim.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd_ReportSim.Name = "BtnAdd_ReportSim";
            this.BtnAdd_ReportSim.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd_ReportSim.Size = new System.Drawing.Size(88, 36);
            this.BtnAdd_ReportSim.TabIndex = 0;
            this.BtnAdd_ReportSim.Text = "Agregar";
            this.BtnAdd_ReportSim.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAdd_ReportSim.UseAccentColor = false;
            this.BtnAdd_ReportSim.UseVisualStyleBackColor = true;
            this.BtnAdd_ReportSim.Click += new System.EventHandler(this.BtnAdd_ReportSim_Click);
            // 
            // Txtbox_DefaultSO
            // 
            this.Txtbox_DefaultSO.AnimateReadOnly = false;
            this.Txtbox_DefaultSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_DefaultSO.Depth = 0;
            this.Txtbox_DefaultSO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_DefaultSO.Hint = "Default SO";
            this.Txtbox_DefaultSO.LeadingIcon = null;
            this.Txtbox_DefaultSO.Location = new System.Drawing.Point(65, 284);
            this.Txtbox_DefaultSO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_DefaultSO.MaxLength = 50;
            this.Txtbox_DefaultSO.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_DefaultSO.Multiline = false;
            this.Txtbox_DefaultSO.Name = "Txtbox_DefaultSO";
            this.Txtbox_DefaultSO.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_DefaultSO.TabIndex = 7;
            this.Txtbox_DefaultSO.Text = "";
            this.Txtbox_DefaultSO.TrailingIcon = null;
            this.Txtbox_DefaultSO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_DefaultSO_KeyPress);
            // 
            // BtnAdd_ReportAgency
            // 
            this.BtnAdd_ReportAgency.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd_ReportAgency.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAdd_ReportAgency.Depth = 0;
            this.BtnAdd_ReportAgency.HighEmphasis = true;
            this.BtnAdd_ReportAgency.Icon = null;
            this.BtnAdd_ReportAgency.Location = new System.Drawing.Point(451, 25);
            this.BtnAdd_ReportAgency.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnAdd_ReportAgency.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd_ReportAgency.Name = "BtnAdd_ReportAgency";
            this.BtnAdd_ReportAgency.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd_ReportAgency.Size = new System.Drawing.Size(88, 36);
            this.BtnAdd_ReportAgency.TabIndex = 0;
            this.BtnAdd_ReportAgency.Text = "Agregar";
            this.BtnAdd_ReportAgency.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAdd_ReportAgency.UseAccentColor = false;
            this.BtnAdd_ReportAgency.UseVisualStyleBackColor = true;
            this.BtnAdd_ReportAgency.Click += new System.EventHandler(this.BtnAdd_ReportAgency_Click);
            // 
            // Txtbox_Obj1Sim
            // 
            this.Txtbox_Obj1Sim.AnimateReadOnly = false;
            this.Txtbox_Obj1Sim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_Obj1Sim.Depth = 0;
            this.Txtbox_Obj1Sim.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_Obj1Sim.Hint = "+100 Sim";
            this.Txtbox_Obj1Sim.LeadingIcon = null;
            this.Txtbox_Obj1Sim.Location = new System.Drawing.Point(185, 225);
            this.Txtbox_Obj1Sim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_Obj1Sim.MaxLength = 50;
            this.Txtbox_Obj1Sim.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_Obj1Sim.Multiline = false;
            this.Txtbox_Obj1Sim.Name = "Txtbox_Obj1Sim";
            this.Txtbox_Obj1Sim.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_Obj1Sim.TabIndex = 4;
            this.Txtbox_Obj1Sim.Text = "";
            this.Txtbox_Obj1Sim.TrailingIcon = null;
            this.Txtbox_Obj1Sim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_Obj1Sim_KeyPress);
            // 
            // Txtbox_ReportSO
            // 
            this.Txtbox_ReportSO.AnimateReadOnly = false;
            this.Txtbox_ReportSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_ReportSO.Depth = 0;
            this.Txtbox_ReportSO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_ReportSO.Hint = "Reporte Objetivo Sellout";
            this.Txtbox_ReportSO.LeadingIcon = null;
            this.Txtbox_ReportSO.Location = new System.Drawing.Point(65, 134);
            this.Txtbox_ReportSO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_ReportSO.MaxLength = 50;
            this.Txtbox_ReportSO.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_ReportSO.Multiline = false;
            this.Txtbox_ReportSO.Name = "Txtbox_ReportSO";
            this.Txtbox_ReportSO.Size = new System.Drawing.Size(365, 50);
            this.Txtbox_ReportSO.TabIndex = 2;
            this.Txtbox_ReportSO.Text = "";
            this.Txtbox_ReportSO.TrailingIcon = null;
            // 
            // Txtbox_Obj2Sim
            // 
            this.Txtbox_Obj2Sim.AnimateReadOnly = false;
            this.Txtbox_Obj2Sim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_Obj2Sim.Depth = 0;
            this.Txtbox_Obj2Sim.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_Obj2Sim.Hint = "+120 Sim";
            this.Txtbox_Obj2Sim.LeadingIcon = null;
            this.Txtbox_Obj2Sim.Location = new System.Drawing.Point(304, 225);
            this.Txtbox_Obj2Sim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_Obj2Sim.MaxLength = 50;
            this.Txtbox_Obj2Sim.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_Obj2Sim.Multiline = false;
            this.Txtbox_Obj2Sim.Name = "Txtbox_Obj2Sim";
            this.Txtbox_Obj2Sim.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_Obj2Sim.TabIndex = 5;
            this.Txtbox_Obj2Sim.Text = "";
            this.Txtbox_Obj2Sim.TrailingIcon = null;
            this.Txtbox_Obj2Sim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_Obj2Sim_KeyPress);
            // 
            // Txtbox_ReportSim
            // 
            this.Txtbox_ReportSim.AnimateReadOnly = false;
            this.Txtbox_ReportSim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_ReportSim.Depth = 0;
            this.Txtbox_ReportSim.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_ReportSim.Hint = "Reporte Objetivos Sim";
            this.Txtbox_ReportSim.LeadingIcon = null;
            this.Txtbox_ReportSim.Location = new System.Drawing.Point(65, 77);
            this.Txtbox_ReportSim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_ReportSim.MaxLength = 50;
            this.Txtbox_ReportSim.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_ReportSim.Multiline = false;
            this.Txtbox_ReportSim.Name = "Txtbox_ReportSim";
            this.Txtbox_ReportSim.Size = new System.Drawing.Size(365, 50);
            this.Txtbox_ReportSim.TabIndex = 1;
            this.Txtbox_ReportSim.Text = "";
            this.Txtbox_ReportSim.TrailingIcon = null;
            // 
            // Txtbox_Obj3Sim
            // 
            this.Txtbox_Obj3Sim.AnimateReadOnly = false;
            this.Txtbox_Obj3Sim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_Obj3Sim.Depth = 0;
            this.Txtbox_Obj3Sim.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_Obj3Sim.Hint = "+150 Sim";
            this.Txtbox_Obj3Sim.LeadingIcon = null;
            this.Txtbox_Obj3Sim.Location = new System.Drawing.Point(425, 225);
            this.Txtbox_Obj3Sim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_Obj3Sim.MaxLength = 50;
            this.Txtbox_Obj3Sim.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_Obj3Sim.Multiline = false;
            this.Txtbox_Obj3Sim.Name = "Txtbox_Obj3Sim";
            this.Txtbox_Obj3Sim.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_Obj3Sim.TabIndex = 6;
            this.Txtbox_Obj3Sim.Text = "";
            this.Txtbox_Obj3Sim.TrailingIcon = null;
            this.Txtbox_Obj3Sim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_Obj3Sim_KeyPress);
            // 
            // TxtBox_ReportAgency
            // 
            this.TxtBox_ReportAgency.AnimateReadOnly = false;
            this.TxtBox_ReportAgency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_ReportAgency.Depth = 0;
            this.TxtBox_ReportAgency.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBox_ReportAgency.Hint = "Reporte PSR de la agencia";
            this.TxtBox_ReportAgency.LeadingIcon = null;
            this.TxtBox_ReportAgency.Location = new System.Drawing.Point(65, 19);
            this.TxtBox_ReportAgency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBox_ReportAgency.MaxLength = 50;
            this.TxtBox_ReportAgency.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtBox_ReportAgency.Multiline = false;
            this.TxtBox_ReportAgency.Name = "TxtBox_ReportAgency";
            this.TxtBox_ReportAgency.Size = new System.Drawing.Size(365, 50);
            this.TxtBox_ReportAgency.TabIndex = 0;
            this.TxtBox_ReportAgency.Tag = "";
            this.TxtBox_ReportAgency.Text = "";
            this.TxtBox_ReportAgency.TrailingIcon = null;
            // 
            // Txtbox_SalesTargetSO
            // 
            this.Txtbox_SalesTargetSO.AnimateReadOnly = false;
            this.Txtbox_SalesTargetSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_SalesTargetSO.Depth = 0;
            this.Txtbox_SalesTargetSO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_SalesTargetSO.Hint = "Obj. Venta";
            this.Txtbox_SalesTargetSO.LeadingIcon = null;
            this.Txtbox_SalesTargetSO.Location = new System.Drawing.Point(425, 284);
            this.Txtbox_SalesTargetSO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_SalesTargetSO.MaxLength = 50;
            this.Txtbox_SalesTargetSO.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_SalesTargetSO.Multiline = false;
            this.Txtbox_SalesTargetSO.Name = "Txtbox_SalesTargetSO";
            this.Txtbox_SalesTargetSO.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_SalesTargetSO.TabIndex = 10;
            this.Txtbox_SalesTargetSO.Text = "";
            this.Txtbox_SalesTargetSO.TrailingIcon = null;
            this.Txtbox_SalesTargetSO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_SalesTargetSO_KeyPress);
            // 
            // MCard_ReportView
            // 
            this.MCard_ReportView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MCard_ReportView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MCard_ReportView.Controls.Add(this.PicBox_Logo);
            this.MCard_ReportView.Controls.Add(this.MLTxtBox1);
            this.MCard_ReportView.Controls.Add(this.Lbl_FormatDescription);
            this.MCard_ReportView.Depth = 0;
            this.MCard_ReportView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MCard_ReportView.Location = new System.Drawing.Point(600, 23);
            this.MCard_ReportView.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.MCard_ReportView.MouseState = MaterialSkin.MouseState.HOVER;
            this.MCard_ReportView.Name = "MCard_ReportView";
            this.MCard_ReportView.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.MCard_ReportView.Size = new System.Drawing.Size(463, 512);
            this.MCard_ReportView.TabIndex = 0;
            // 
            // PicBox_Logo
            // 
            this.PicBox_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_Logo.Image")));
            this.PicBox_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("PicBox_Logo.InitialImage")));
            this.PicBox_Logo.Location = new System.Drawing.Point(128, 316);
            this.PicBox_Logo.Name = "PicBox_Logo";
            this.PicBox_Logo.Size = new System.Drawing.Size(199, 172);
            this.PicBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_Logo.TabIndex = 2;
            this.PicBox_Logo.TabStop = false;
            // 
            // MLTxtBox1
            // 
            this.MLTxtBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MLTxtBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MLTxtBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MLTxtBox1.Depth = 0;
            this.MLTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MLTxtBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MLTxtBox1.Location = new System.Drawing.Point(17, 57);
            this.MLTxtBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.MLTxtBox1.Name = "MLTxtBox1";
            this.MLTxtBox1.Size = new System.Drawing.Size(392, 227);
            this.MLTxtBox1.TabIndex = 0;
            this.MLTxtBox1.Text = resources.GetString("MLTxtBox1.Text");
            // 
            // Lbl_FormatDescription
            // 
            this.Lbl_FormatDescription.AutoSize = true;
            this.Lbl_FormatDescription.Depth = 0;
            this.Lbl_FormatDescription.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_FormatDescription.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.Lbl_FormatDescription.Location = new System.Drawing.Point(17, 15);
            this.Lbl_FormatDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lbl_FormatDescription.Name = "Lbl_FormatDescription";
            this.Lbl_FormatDescription.Size = new System.Drawing.Size(278, 29);
            this.Lbl_FormatDescription.TabIndex = 0;
            this.Lbl_FormatDescription.Text = "Formato de plantilla excel";
            // 
            // materialTextBox9
            // 
            this.materialTextBox9.AnimateReadOnly = false;
            this.materialTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox9.Depth = 0;
            this.materialTextBox9.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox9.Hint = "Volumen Obj.";
            this.materialTextBox9.LeadingIcon = null;
            this.materialTextBox9.Location = new System.Drawing.Point(65, 368);
            this.materialTextBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTextBox9.MaxLength = 50;
            this.materialTextBox9.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox9.Multiline = false;
            this.materialTextBox9.Name = "materialTextBox9";
            this.materialTextBox9.Size = new System.Drawing.Size(131, 50);
            this.materialTextBox9.TabIndex = 11;
            this.materialTextBox9.Text = "";
            this.materialTextBox9.TrailingIcon = null;
            // 
            // materialTextBox10
            // 
            this.materialTextBox10.AnimateReadOnly = false;
            this.materialTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox10.Depth = 0;
            this.materialTextBox10.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox10.Hint = "A pagar";
            this.materialTextBox10.LeadingIcon = null;
            this.materialTextBox10.Location = new System.Drawing.Point(236, 368);
            this.materialTextBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTextBox10.MaxLength = 50;
            this.materialTextBox10.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox10.Multiline = false;
            this.materialTextBox10.Name = "materialTextBox10";
            this.materialTextBox10.Size = new System.Drawing.Size(131, 50);
            this.materialTextBox10.TabIndex = 12;
            this.materialTextBox10.Text = "";
            this.materialTextBox10.TrailingIcon = null;
            // 
            // Txtbox_Obj1SO
            // 
            this.Txtbox_Obj1SO.AnimateReadOnly = false;
            this.Txtbox_Obj1SO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_Obj1SO.Depth = 0;
            this.Txtbox_Obj1SO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_Obj1SO.Hint = "+120 SO";
            this.Txtbox_Obj1SO.LeadingIcon = null;
            this.Txtbox_Obj1SO.Location = new System.Drawing.Point(185, 284);
            this.Txtbox_Obj1SO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_Obj1SO.MaxLength = 50;
            this.Txtbox_Obj1SO.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_Obj1SO.Multiline = false;
            this.Txtbox_Obj1SO.Name = "Txtbox_Obj1SO";
            this.Txtbox_Obj1SO.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_Obj1SO.TabIndex = 8;
            this.Txtbox_Obj1SO.Text = "";
            this.Txtbox_Obj1SO.TrailingIcon = null;
            this.Txtbox_Obj1SO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_Obj1SO_KeyPress);
            // 
            // Txtbox_Obj2SO
            // 
            this.Txtbox_Obj2SO.AnimateReadOnly = false;
            this.Txtbox_Obj2SO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtbox_Obj2SO.Depth = 0;
            this.Txtbox_Obj2SO.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txtbox_Obj2SO.Hint = "+150 SO";
            this.Txtbox_Obj2SO.LeadingIcon = null;
            this.Txtbox_Obj2SO.Location = new System.Drawing.Point(304, 284);
            this.Txtbox_Obj2SO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbox_Obj2SO.MaxLength = 50;
            this.Txtbox_Obj2SO.MouseState = MaterialSkin.MouseState.OUT;
            this.Txtbox_Obj2SO.Multiline = false;
            this.Txtbox_Obj2SO.Name = "Txtbox_Obj2SO";
            this.Txtbox_Obj2SO.Size = new System.Drawing.Size(114, 50);
            this.Txtbox_Obj2SO.TabIndex = 9;
            this.Txtbox_Obj2SO.Text = "";
            this.Txtbox_Obj2SO.TrailingIcon = null;
            this.Txtbox_Obj2SO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbox_Obj2SO_KeyPress);
            // 
            // materialTextBox11
            // 
            this.materialTextBox11.AnimateReadOnly = false;
            this.materialTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox11.Depth = 0;
            this.materialTextBox11.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox11.Hint = "PSR Req.";
            this.materialTextBox11.LeadingIcon = null;
            this.materialTextBox11.Location = new System.Drawing.Point(407, 368);
            this.materialTextBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTextBox11.MaxLength = 50;
            this.materialTextBox11.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox11.Multiline = false;
            this.materialTextBox11.Name = "materialTextBox11";
            this.materialTextBox11.Size = new System.Drawing.Size(131, 50);
            this.materialTextBox11.TabIndex = 13;
            this.materialTextBox11.Text = "";
            this.materialTextBox11.TrailingIcon = null;
            // 
            // TabPage_Pagos
            // 
            this.TabPage_Pagos.Controls.Add(this.dataGridView1);
            this.TabPage_Pagos.ImageKey = "payments_FILL0_wght400_GRAD-25_opsz48.png";
            this.TabPage_Pagos.Location = new System.Drawing.Point(4, 39);
            this.TabPage_Pagos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage_Pagos.Name = "TabPage_Pagos";
            this.TabPage_Pagos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage_Pagos.Size = new System.Drawing.Size(1136, 531);
            this.TabPage_Pagos.TabIndex = 1;
            this.TabPage_Pagos.Text = "Pagos";
            this.TabPage_Pagos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1130, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // TabPage_Settings
            // 
            this.TabPage_Settings.ImageKey = "settings_FILL0_wght400_GRAD-25_opsz48.png";
            this.TabPage_Settings.Location = new System.Drawing.Point(4, 39);
            this.TabPage_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage_Settings.Name = "TabPage_Settings";
            this.TabPage_Settings.Size = new System.Drawing.Size(1136, 531);
            this.TabPage_Settings.TabIndex = 2;
            this.TabPage_Settings.Text = "Configuración";
            this.TabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // ImgList_Menu
            // 
            this.ImgList_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList_Menu.ImageStream")));
            this.ImgList_Menu.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList_Menu.Images.SetKeyName(0, "payments_FILL0_wght400_GRAD-25_opsz48.png");
            this.ImgList_Menu.Images.SetKeyName(1, "settings_FILL0_wght400_GRAD-25_opsz48.png");
            this.ImgList_Menu.Images.SetKeyName(2, "home_FILL0_wght400_GRAD0_opsz48.png");
            this.ImgList_Menu.Images.SetKeyName(3, "Icono.jpg");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 672);
            this.Controls.Add(this.Dgv_Payments);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.Dgv_Payments;
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 94, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidador - By Rodrigo Alonso";
            this.Dgv_Payments.ResumeLayout(false);
            this.TabPage_Home.ResumeLayout(false);
            this.TabPage_Home.PerformLayout();
            this.MCard_ReportView.ResumeLayout(false);
            this.MCard_ReportView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Logo)).EndInit();
            this.TabPage_Pagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl Dgv_Payments;
        private System.Windows.Forms.TabPage TabPage_Home;
        private System.Windows.Forms.TabPage TabPage_Pagos;
        private System.Windows.Forms.ImageList ImgList_Menu;
        private System.Windows.Forms.TabPage TabPage_Settings;
        private MaterialSkin.Controls.MaterialTextBox TxtBox_ReportAgency;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_ReportSO;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_ReportSim;
        private MaterialSkin.Controls.MaterialButton BtnAdd_ReportAgency;
        private MaterialSkin.Controls.MaterialButton BtnAdd_ReportSO;
        private MaterialSkin.Controls.MaterialButton BtnAdd_ReportSim;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_DefaultSim;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_Obj2SO;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_Obj1SO;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_SalesTargetSO;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_Obj3Sim;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_Obj2Sim;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_Obj1Sim;
        private MaterialSkin.Controls.MaterialTextBox Txtbox_DefaultSO;
        private MaterialSkin.Controls.MaterialCard MCard_ReportView;
        private MaterialSkin.Controls.MaterialDivider MDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox11;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox10;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox9;
        private MaterialSkin.Controls.MaterialButton Btn_GetPaymentsResults;
        private MaterialSkin.Controls.MaterialDivider MDivider1;
        private MaterialSkin.Controls.MaterialLabel Lbl_FormatDescription;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MLTxtBox1;
        private System.Windows.Forms.PictureBox PicBox_Logo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

