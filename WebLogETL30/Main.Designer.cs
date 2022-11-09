
namespace WebLogETL30
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_main_Import = new System.Windows.Forms.Button();
            this.dataGrid_main_MainGrid = new System.Windows.Forms.DataGridView();
            this.btn_main_Settings = new System.Windows.Forms.Button();
            this.grpBox_main_Main = new System.Windows.Forms.GroupBox();
            this.tabCon_main_MainTabCon = new System.Windows.Forms.TabControl();
            this.tabPage_main_FirstAnalyse = new System.Windows.Forms.TabPage();
            this.btn_main_LoadData_FirstAnalyse = new System.Windows.Forms.Button();
            this.grpBox_main_Attributes = new System.Windows.Forms.GroupBox();
            this.cb_main_Nummer = new System.Windows.Forms.CheckBox();
            this.cb_main_Status = new System.Windows.Forms.CheckBox();
            this.cb_main_Event = new System.Windows.Forms.CheckBox();
            this.cb_main_Method = new System.Windows.Forms.CheckBox();
            this.cb_main_Time = new System.Windows.Forms.CheckBox();
            this.cb_main_IP = new System.Windows.Forms.CheckBox();
            this.tabPage_main_SecondAnalyse = new System.Windows.Forms.TabPage();
            this.btn_main_LoadData_SecondAnalyse = new System.Windows.Forms.Button();
            this.tabPage_main_ThirdAnalyse = new System.Windows.Forms.TabPage();
            this.cb_main_Head = new System.Windows.Forms.CheckBox();
            this.cb_main_Post = new System.Windows.Forms.CheckBox();
            this.cb_main_Get = new System.Windows.Forms.CheckBox();
            this.btn_main_LoadData_ThirdAnalyse = new System.Windows.Forms.Button();
            this.tabPage_main_FourthAnalyse = new System.Windows.Forms.TabPage();
            this.lb_main_ErrorCode = new System.Windows.Forms.Label();
            this.btn_main_LoadData_FourthAnalyse = new System.Windows.Forms.Button();
            this.tb_main_Error = new System.Windows.Forms.TextBox();
            this.grpBox_main_IP = new System.Windows.Forms.GroupBox();
            this.tb_main_IP = new System.Windows.Forms.TextBox();
            this.cb_main_Date = new System.Windows.Forms.CheckBox();
            this.grpBox_main_ZeitRaum = new System.Windows.Forms.GroupBox();
            this.dTPicker_main_DateUntil = new System.Windows.Forms.DateTimePicker();
            this.dTPicker_main_TimeUntil = new System.Windows.Forms.DateTimePicker();
            this.lb_main_Until = new System.Windows.Forms.Label();
            this.lb_main_From = new System.Windows.Forms.Label();
            this.dTPicker_main_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dTPicker_main_TimeFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_main_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_main_MainGrid)).BeginInit();
            this.grpBox_main_Main.SuspendLayout();
            this.tabCon_main_MainTabCon.SuspendLayout();
            this.tabPage_main_FirstAnalyse.SuspendLayout();
            this.grpBox_main_Attributes.SuspendLayout();
            this.tabPage_main_SecondAnalyse.SuspendLayout();
            this.tabPage_main_ThirdAnalyse.SuspendLayout();
            this.tabPage_main_FourthAnalyse.SuspendLayout();
            this.grpBox_main_IP.SuspendLayout();
            this.grpBox_main_ZeitRaum.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_main_Import
            // 
            this.btn_main_Import.Location = new System.Drawing.Point(1176, 12);
            this.btn_main_Import.Name = "btn_main_Import";
            this.btn_main_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_main_Import.TabIndex = 0;
            this.btn_main_Import.Text = "Importer";
            this.btn_main_Import.UseVisualStyleBackColor = true;
            this.btn_main_Import.Click += new System.EventHandler(this.btn_main_Import_Click);
            // 
            // dataGrid_main_MainGrid
            // 
            this.dataGrid_main_MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_main_MainGrid.Location = new System.Drawing.Point(12, 44);
            this.dataGrid_main_MainGrid.Name = "dataGrid_main_MainGrid";
            this.dataGrid_main_MainGrid.Size = new System.Drawing.Size(1240, 501);
            this.dataGrid_main_MainGrid.TabIndex = 1;
            // 
            // btn_main_Settings
            // 
            this.btn_main_Settings.Location = new System.Drawing.Point(12, 15);
            this.btn_main_Settings.Name = "btn_main_Settings";
            this.btn_main_Settings.Size = new System.Drawing.Size(80, 23);
            this.btn_main_Settings.TabIndex = 2;
            this.btn_main_Settings.Text = "Einstellungen";
            this.btn_main_Settings.UseVisualStyleBackColor = true;
            this.btn_main_Settings.Click += new System.EventHandler(this.btn_main_Settings_Click);
            // 
            // grpBox_main_Main
            // 
            this.grpBox_main_Main.Controls.Add(this.tabCon_main_MainTabCon);
            this.grpBox_main_Main.Controls.Add(this.grpBox_main_IP);
            this.grpBox_main_Main.Controls.Add(this.cb_main_Date);
            this.grpBox_main_Main.Controls.Add(this.grpBox_main_ZeitRaum);
            this.grpBox_main_Main.Location = new System.Drawing.Point(12, 551);
            this.grpBox_main_Main.Name = "grpBox_main_Main";
            this.grpBox_main_Main.Size = new System.Drawing.Size(1243, 274);
            this.grpBox_main_Main.TabIndex = 3;
            this.grpBox_main_Main.TabStop = false;
            this.grpBox_main_Main.Text = "Filter";
            // 
            // tabCon_main_MainTabCon
            // 
            this.tabCon_main_MainTabCon.Controls.Add(this.tabPage_main_FirstAnalyse);
            this.tabCon_main_MainTabCon.Controls.Add(this.tabPage_main_SecondAnalyse);
            this.tabCon_main_MainTabCon.Controls.Add(this.tabPage_main_ThirdAnalyse);
            this.tabCon_main_MainTabCon.Controls.Add(this.tabPage_main_FourthAnalyse);
            this.tabCon_main_MainTabCon.Location = new System.Drawing.Point(0, 19);
            this.tabCon_main_MainTabCon.Name = "tabCon_main_MainTabCon";
            this.tabCon_main_MainTabCon.SelectedIndex = 0;
            this.tabCon_main_MainTabCon.Size = new System.Drawing.Size(1240, 102);
            this.tabCon_main_MainTabCon.TabIndex = 0;
            // 
            // tabPage_main_FirstAnalyse
            // 
            this.tabPage_main_FirstAnalyse.Controls.Add(this.btn_main_LoadData_FirstAnalyse);
            this.tabPage_main_FirstAnalyse.Controls.Add(this.grpBox_main_Attributes);
            this.tabPage_main_FirstAnalyse.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main_FirstAnalyse.Name = "tabPage_main_FirstAnalyse";
            this.tabPage_main_FirstAnalyse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main_FirstAnalyse.Size = new System.Drawing.Size(1232, 76);
            this.tabPage_main_FirstAnalyse.TabIndex = 0;
            this.tabPage_main_FirstAnalyse.Text = "Analyse 1";
            this.tabPage_main_FirstAnalyse.UseVisualStyleBackColor = true;
            // 
            // btn_main_LoadData_FirstAnalyse
            // 
            this.btn_main_LoadData_FirstAnalyse.Location = new System.Drawing.Point(1111, 29);
            this.btn_main_LoadData_FirstAnalyse.Name = "btn_main_LoadData_FirstAnalyse";
            this.btn_main_LoadData_FirstAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btn_main_LoadData_FirstAnalyse.TabIndex = 7;
            this.btn_main_LoadData_FirstAnalyse.Text = "Daten laden";
            this.btn_main_LoadData_FirstAnalyse.UseVisualStyleBackColor = true;
            this.btn_main_LoadData_FirstAnalyse.Click += new System.EventHandler(this.btn_main_LoadData_FirstAnalyse_Click);
            // 
            // grpBox_main_Attributes
            // 
            this.grpBox_main_Attributes.Controls.Add(this.cb_main_Nummer);
            this.grpBox_main_Attributes.Controls.Add(this.cb_main_Status);
            this.grpBox_main_Attributes.Controls.Add(this.cb_main_Event);
            this.grpBox_main_Attributes.Controls.Add(this.cb_main_Method);
            this.grpBox_main_Attributes.Controls.Add(this.cb_main_Time);
            this.grpBox_main_Attributes.Controls.Add(this.cb_main_IP);
            this.grpBox_main_Attributes.Location = new System.Drawing.Point(6, 6);
            this.grpBox_main_Attributes.Name = "grpBox_main_Attributes";
            this.grpBox_main_Attributes.Size = new System.Drawing.Size(1056, 59);
            this.grpBox_main_Attributes.TabIndex = 5;
            this.grpBox_main_Attributes.TabStop = false;
            this.grpBox_main_Attributes.Text = "Attribute";
            // 
            // cb_main_Nummer
            // 
            this.cb_main_Nummer.AutoSize = true;
            this.cb_main_Nummer.Checked = true;
            this.cb_main_Nummer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Nummer.Location = new System.Drawing.Point(501, 26);
            this.cb_main_Nummer.Name = "cb_main_Nummer";
            this.cb_main_Nummer.Size = new System.Drawing.Size(65, 17);
            this.cb_main_Nummer.TabIndex = 5;
            this.cb_main_Nummer.Text = "Nummer";
            this.cb_main_Nummer.UseVisualStyleBackColor = true;
            // 
            // cb_main_Status
            // 
            this.cb_main_Status.AutoSize = true;
            this.cb_main_Status.Checked = true;
            this.cb_main_Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Status.Location = new System.Drawing.Point(405, 26);
            this.cb_main_Status.Name = "cb_main_Status";
            this.cb_main_Status.Size = new System.Drawing.Size(56, 17);
            this.cb_main_Status.TabIndex = 4;
            this.cb_main_Status.Text = "Status";
            this.cb_main_Status.UseVisualStyleBackColor = true;
            // 
            // cb_main_Event
            // 
            this.cb_main_Event.AutoSize = true;
            this.cb_main_Event.Checked = true;
            this.cb_main_Event.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Event.Location = new System.Drawing.Point(306, 26);
            this.cb_main_Event.Name = "cb_main_Event";
            this.cb_main_Event.Size = new System.Drawing.Size(54, 17);
            this.cb_main_Event.TabIndex = 3;
            this.cb_main_Event.Text = "Event";
            this.cb_main_Event.UseVisualStyleBackColor = true;
            // 
            // cb_main_Method
            // 
            this.cb_main_Method.AutoSize = true;
            this.cb_main_Method.Checked = true;
            this.cb_main_Method.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Method.Location = new System.Drawing.Point(208, 26);
            this.cb_main_Method.Name = "cb_main_Method";
            this.cb_main_Method.Size = new System.Drawing.Size(68, 17);
            this.cb_main_Method.TabIndex = 2;
            this.cb_main_Method.Text = "Methode";
            this.cb_main_Method.UseVisualStyleBackColor = true;
            // 
            // cb_main_Time
            // 
            this.cb_main_Time.AutoSize = true;
            this.cb_main_Time.Checked = true;
            this.cb_main_Time.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Time.Location = new System.Drawing.Point(102, 26);
            this.cb_main_Time.Name = "cb_main_Time";
            this.cb_main_Time.Size = new System.Drawing.Size(77, 17);
            this.cb_main_Time.TabIndex = 1;
            this.cb_main_Time.Text = "Timestamp";
            this.cb_main_Time.UseVisualStyleBackColor = true;
            // 
            // cb_main_IP
            // 
            this.cb_main_IP.AutoSize = true;
            this.cb_main_IP.Checked = true;
            this.cb_main_IP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_IP.Location = new System.Drawing.Point(6, 26);
            this.cb_main_IP.Name = "cb_main_IP";
            this.cb_main_IP.Size = new System.Drawing.Size(36, 17);
            this.cb_main_IP.TabIndex = 0;
            this.cb_main_IP.Text = "IP";
            this.cb_main_IP.UseVisualStyleBackColor = true;
            // 
            // tabPage_main_SecondAnalyse
            // 
            this.tabPage_main_SecondAnalyse.Controls.Add(this.btn_main_LoadData_SecondAnalyse);
            this.tabPage_main_SecondAnalyse.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main_SecondAnalyse.Name = "tabPage_main_SecondAnalyse";
            this.tabPage_main_SecondAnalyse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main_SecondAnalyse.Size = new System.Drawing.Size(1232, 76);
            this.tabPage_main_SecondAnalyse.TabIndex = 1;
            this.tabPage_main_SecondAnalyse.Text = "Analyse 2";
            this.tabPage_main_SecondAnalyse.UseVisualStyleBackColor = true;
            // 
            // btn_main_LoadData_SecondAnalyse
            // 
            this.btn_main_LoadData_SecondAnalyse.Location = new System.Drawing.Point(1151, 28);
            this.btn_main_LoadData_SecondAnalyse.Name = "btn_main_LoadData_SecondAnalyse";
            this.btn_main_LoadData_SecondAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btn_main_LoadData_SecondAnalyse.TabIndex = 0;
            this.btn_main_LoadData_SecondAnalyse.Text = "Daten laden";
            this.btn_main_LoadData_SecondAnalyse.UseVisualStyleBackColor = true;
            this.btn_main_LoadData_SecondAnalyse.Click += new System.EventHandler(this.btn_main_LoadData_SecondAnalyse_Click);
            // 
            // tabPage_main_ThirdAnalyse
            // 
            this.tabPage_main_ThirdAnalyse.Controls.Add(this.cb_main_Head);
            this.tabPage_main_ThirdAnalyse.Controls.Add(this.cb_main_Post);
            this.tabPage_main_ThirdAnalyse.Controls.Add(this.cb_main_Get);
            this.tabPage_main_ThirdAnalyse.Controls.Add(this.btn_main_LoadData_ThirdAnalyse);
            this.tabPage_main_ThirdAnalyse.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main_ThirdAnalyse.Name = "tabPage_main_ThirdAnalyse";
            this.tabPage_main_ThirdAnalyse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main_ThirdAnalyse.Size = new System.Drawing.Size(1232, 76);
            this.tabPage_main_ThirdAnalyse.TabIndex = 2;
            this.tabPage_main_ThirdAnalyse.Text = "Analyse 3";
            this.tabPage_main_ThirdAnalyse.UseVisualStyleBackColor = true;
            // 
            // cb_main_Head
            // 
            this.cb_main_Head.AutoSize = true;
            this.cb_main_Head.Checked = true;
            this.cb_main_Head.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Head.Location = new System.Drawing.Point(215, 29);
            this.cb_main_Head.Name = "cb_main_Head";
            this.cb_main_Head.Size = new System.Drawing.Size(56, 17);
            this.cb_main_Head.TabIndex = 3;
            this.cb_main_Head.Text = "HEAD";
            this.cb_main_Head.UseVisualStyleBackColor = true;
            // 
            // cb_main_Post
            // 
            this.cb_main_Post.AutoSize = true;
            this.cb_main_Post.Checked = true;
            this.cb_main_Post.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Post.Location = new System.Drawing.Point(119, 29);
            this.cb_main_Post.Name = "cb_main_Post";
            this.cb_main_Post.Size = new System.Drawing.Size(55, 17);
            this.cb_main_Post.TabIndex = 2;
            this.cb_main_Post.Text = "POST";
            this.cb_main_Post.UseVisualStyleBackColor = true;
            // 
            // cb_main_Get
            // 
            this.cb_main_Get.AutoSize = true;
            this.cb_main_Get.Checked = true;
            this.cb_main_Get.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_main_Get.Location = new System.Drawing.Point(23, 29);
            this.cb_main_Get.Name = "cb_main_Get";
            this.cb_main_Get.Size = new System.Drawing.Size(48, 17);
            this.cb_main_Get.TabIndex = 1;
            this.cb_main_Get.Text = "GET";
            this.cb_main_Get.UseVisualStyleBackColor = true;
            // 
            // btn_main_LoadData_ThirdAnalyse
            // 
            this.btn_main_LoadData_ThirdAnalyse.Location = new System.Drawing.Point(1151, 29);
            this.btn_main_LoadData_ThirdAnalyse.Name = "btn_main_LoadData_ThirdAnalyse";
            this.btn_main_LoadData_ThirdAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btn_main_LoadData_ThirdAnalyse.TabIndex = 0;
            this.btn_main_LoadData_ThirdAnalyse.Text = "Daten laden";
            this.btn_main_LoadData_ThirdAnalyse.UseVisualStyleBackColor = true;
            this.btn_main_LoadData_ThirdAnalyse.Click += new System.EventHandler(this.btn_main_LoadData_ThirdAnalyse_Click);
            // 
            // tabPage_main_FourthAnalyse
            // 
            this.tabPage_main_FourthAnalyse.Controls.Add(this.lb_main_ErrorCode);
            this.tabPage_main_FourthAnalyse.Controls.Add(this.btn_main_LoadData_FourthAnalyse);
            this.tabPage_main_FourthAnalyse.Controls.Add(this.tb_main_Error);
            this.tabPage_main_FourthAnalyse.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main_FourthAnalyse.Name = "tabPage_main_FourthAnalyse";
            this.tabPage_main_FourthAnalyse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main_FourthAnalyse.Size = new System.Drawing.Size(1232, 76);
            this.tabPage_main_FourthAnalyse.TabIndex = 3;
            this.tabPage_main_FourthAnalyse.Text = "Analyse 4";
            this.tabPage_main_FourthAnalyse.UseVisualStyleBackColor = true;
            // 
            // lb_main_ErrorCode
            // 
            this.lb_main_ErrorCode.AutoSize = true;
            this.lb_main_ErrorCode.Location = new System.Drawing.Point(10, 34);
            this.lb_main_ErrorCode.Name = "lb_main_ErrorCode";
            this.lb_main_ErrorCode.Size = new System.Drawing.Size(57, 13);
            this.lb_main_ErrorCode.TabIndex = 2;
            this.lb_main_ErrorCode.Text = "Error Code";
            // 
            // btn_main_LoadData_FourthAnalyse
            // 
            this.btn_main_LoadData_FourthAnalyse.Location = new System.Drawing.Point(1151, 31);
            this.btn_main_LoadData_FourthAnalyse.Name = "btn_main_LoadData_FourthAnalyse";
            this.btn_main_LoadData_FourthAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btn_main_LoadData_FourthAnalyse.TabIndex = 1;
            this.btn_main_LoadData_FourthAnalyse.Text = "Daten laden";
            this.btn_main_LoadData_FourthAnalyse.UseVisualStyleBackColor = true;
            this.btn_main_LoadData_FourthAnalyse.Click += new System.EventHandler(this.btn_main_LoadData_FourthAnalyse_Click);
            // 
            // tb_main_Error
            // 
            this.tb_main_Error.Location = new System.Drawing.Point(80, 31);
            this.tb_main_Error.Name = "tb_main_Error";
            this.tb_main_Error.Size = new System.Drawing.Size(1065, 20);
            this.tb_main_Error.TabIndex = 0;
            // 
            // grpBox_main_IP
            // 
            this.grpBox_main_IP.Controls.Add(this.tb_main_IP);
            this.grpBox_main_IP.Location = new System.Drawing.Point(4, 192);
            this.grpBox_main_IP.Name = "grpBox_main_IP";
            this.grpBox_main_IP.Size = new System.Drawing.Size(1232, 59);
            this.grpBox_main_IP.TabIndex = 6;
            this.grpBox_main_IP.TabStop = false;
            this.grpBox_main_IP.Text = "IP";
            // 
            // tb_main_IP
            // 
            this.tb_main_IP.Location = new System.Drawing.Point(6, 28);
            this.tb_main_IP.Name = "tb_main_IP";
            this.tb_main_IP.Size = new System.Drawing.Size(1220, 20);
            this.tb_main_IP.TabIndex = 2;
            // 
            // cb_main_Date
            // 
            this.cb_main_Date.AutoSize = true;
            this.cb_main_Date.Location = new System.Drawing.Point(1083, 153);
            this.cb_main_Date.Name = "cb_main_Date";
            this.cb_main_Date.Size = new System.Drawing.Size(118, 17);
            this.cb_main_Date.TabIndex = 7;
            this.cb_main_Date.Text = "Zeitraum-Filter aktiv";
            this.cb_main_Date.UseVisualStyleBackColor = true;
            this.cb_main_Date.CheckedChanged += new System.EventHandler(this.cb_main_Date_CheckedChanged);
            // 
            // grpBox_main_ZeitRaum
            // 
            this.grpBox_main_ZeitRaum.Controls.Add(this.dTPicker_main_DateUntil);
            this.grpBox_main_ZeitRaum.Controls.Add(this.dTPicker_main_TimeUntil);
            this.grpBox_main_ZeitRaum.Controls.Add(this.lb_main_Until);
            this.grpBox_main_ZeitRaum.Controls.Add(this.lb_main_From);
            this.grpBox_main_ZeitRaum.Controls.Add(this.dTPicker_main_DateFrom);
            this.grpBox_main_ZeitRaum.Controls.Add(this.dTPicker_main_TimeFrom);
            this.grpBox_main_ZeitRaum.Enabled = false;
            this.grpBox_main_ZeitRaum.Location = new System.Drawing.Point(4, 127);
            this.grpBox_main_ZeitRaum.Name = "grpBox_main_ZeitRaum";
            this.grpBox_main_ZeitRaum.Size = new System.Drawing.Size(1062, 59);
            this.grpBox_main_ZeitRaum.TabIndex = 4;
            this.grpBox_main_ZeitRaum.TabStop = false;
            this.grpBox_main_ZeitRaum.Text = "Zeitraum";
            // 
            // dTPicker_main_DateUntil
            // 
            this.dTPicker_main_DateUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_main_DateUntil.Location = new System.Drawing.Point(733, 22);
            this.dTPicker_main_DateUntil.Name = "dTPicker_main_DateUntil";
            this.dTPicker_main_DateUntil.ShowCheckBox = true;
            this.dTPicker_main_DateUntil.Size = new System.Drawing.Size(134, 20);
            this.dTPicker_main_DateUntil.TabIndex = 8;
            // 
            // dTPicker_main_TimeUntil
            // 
            this.dTPicker_main_TimeUntil.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPicker_main_TimeUntil.Location = new System.Drawing.Point(873, 22);
            this.dTPicker_main_TimeUntil.Name = "dTPicker_main_TimeUntil";
            this.dTPicker_main_TimeUntil.ShowCheckBox = true;
            this.dTPicker_main_TimeUntil.Size = new System.Drawing.Size(152, 20);
            this.dTPicker_main_TimeUntil.TabIndex = 9;
            // 
            // lb_main_Until
            // 
            this.lb_main_Until.AutoSize = true;
            this.lb_main_Until.Location = new System.Drawing.Point(705, 28);
            this.lb_main_Until.Name = "lb_main_Until";
            this.lb_main_Until.Size = new System.Drawing.Size(24, 13);
            this.lb_main_Until.TabIndex = 3;
            this.lb_main_Until.Text = "Bis:";
            // 
            // lb_main_From
            // 
            this.lb_main_From.AutoSize = true;
            this.lb_main_From.Location = new System.Drawing.Point(10, 27);
            this.lb_main_From.Name = "lb_main_From";
            this.lb_main_From.Size = new System.Drawing.Size(29, 13);
            this.lb_main_From.TabIndex = 2;
            this.lb_main_From.Text = "Von:";
            // 
            // dTPicker_main_DateFrom
            // 
            this.dTPicker_main_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPicker_main_DateFrom.Location = new System.Drawing.Point(55, 22);
            this.dTPicker_main_DateFrom.Name = "dTPicker_main_DateFrom";
            this.dTPicker_main_DateFrom.ShowCheckBox = true;
            this.dTPicker_main_DateFrom.Size = new System.Drawing.Size(134, 20);
            this.dTPicker_main_DateFrom.TabIndex = 0;
            // 
            // dTPicker_main_TimeFrom
            // 
            this.dTPicker_main_TimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPicker_main_TimeFrom.Location = new System.Drawing.Point(195, 22);
            this.dTPicker_main_TimeFrom.Name = "dTPicker_main_TimeFrom";
            this.dTPicker_main_TimeFrom.ShowCheckBox = true;
            this.dTPicker_main_TimeFrom.Size = new System.Drawing.Size(152, 20);
            this.dTPicker_main_TimeFrom.TabIndex = 1;
            // 
            // btn_main_Load
            // 
            this.btn_main_Load.Location = new System.Drawing.Point(1095, 12);
            this.btn_main_Load.Name = "btn_main_Load";
            this.btn_main_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_main_Load.TabIndex = 4;
            this.btn_main_Load.Text = "Daten laden";
            this.btn_main_Load.UseVisualStyleBackColor = true;
            this.btn_main_Load.Click += new System.EventHandler(this.btn_main_Load_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 835);
            this.Controls.Add(this.btn_main_Load);
            this.Controls.Add(this.grpBox_main_Main);
            this.Controls.Add(this.btn_main_Settings);
            this.Controls.Add(this.dataGrid_main_MainGrid);
            this.Controls.Add(this.btn_main_Import);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_main_MainGrid)).EndInit();
            this.grpBox_main_Main.ResumeLayout(false);
            this.grpBox_main_Main.PerformLayout();
            this.tabCon_main_MainTabCon.ResumeLayout(false);
            this.tabPage_main_FirstAnalyse.ResumeLayout(false);
            this.grpBox_main_Attributes.ResumeLayout(false);
            this.grpBox_main_Attributes.PerformLayout();
            this.tabPage_main_SecondAnalyse.ResumeLayout(false);
            this.tabPage_main_ThirdAnalyse.ResumeLayout(false);
            this.tabPage_main_ThirdAnalyse.PerformLayout();
            this.tabPage_main_FourthAnalyse.ResumeLayout(false);
            this.tabPage_main_FourthAnalyse.PerformLayout();
            this.grpBox_main_IP.ResumeLayout(false);
            this.grpBox_main_IP.PerformLayout();
            this.grpBox_main_ZeitRaum.ResumeLayout(false);
            this.grpBox_main_ZeitRaum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_main_Import;
        private System.Windows.Forms.DataGridView dataGrid_main_MainGrid;
        private System.Windows.Forms.Button btn_main_Settings;
        private System.Windows.Forms.GroupBox grpBox_main_Main;
        private System.Windows.Forms.Button btn_main_Load;
        private System.Windows.Forms.TabControl tabCon_main_MainTabCon;
        private System.Windows.Forms.TabPage tabPage_main_FirstAnalyse;
        private System.Windows.Forms.TabPage tabPage_main_SecondAnalyse;
        private System.Windows.Forms.TabPage tabPage_main_ThirdAnalyse;
        private System.Windows.Forms.TabPage tabPage_main_FourthAnalyse;
        private System.Windows.Forms.DateTimePicker dTPicker_main_TimeFrom;
        private System.Windows.Forms.DateTimePicker dTPicker_main_DateFrom;
        private System.Windows.Forms.CheckBox cb_main_Date;
        private System.Windows.Forms.GroupBox grpBox_main_ZeitRaum;
        private System.Windows.Forms.Label lb_main_Until;
        private System.Windows.Forms.Label lb_main_From;
        private System.Windows.Forms.Button btn_main_LoadData_FirstAnalyse;
        private System.Windows.Forms.GroupBox grpBox_main_IP;
        private System.Windows.Forms.TextBox tb_main_IP;
        private System.Windows.Forms.GroupBox grpBox_main_Attributes;
        private System.Windows.Forms.CheckBox cb_main_Nummer;
        private System.Windows.Forms.CheckBox cb_main_Status;
        private System.Windows.Forms.CheckBox cb_main_Event;
        private System.Windows.Forms.CheckBox cb_main_Method;
        private System.Windows.Forms.CheckBox cb_main_Time;
        private System.Windows.Forms.CheckBox cb_main_IP;
        private System.Windows.Forms.DateTimePicker dTPicker_main_DateUntil;
        private System.Windows.Forms.DateTimePicker dTPicker_main_TimeUntil;
        private System.Windows.Forms.Button btn_main_LoadData_SecondAnalyse;
        private System.Windows.Forms.Button btn_main_LoadData_ThirdAnalyse;
        private System.Windows.Forms.CheckBox cb_main_Head;
        private System.Windows.Forms.CheckBox cb_main_Post;
        private System.Windows.Forms.CheckBox cb_main_Get;
        private System.Windows.Forms.Label lb_main_ErrorCode;
        private System.Windows.Forms.Button btn_main_LoadData_FourthAnalyse;
        private System.Windows.Forms.TextBox tb_main_Error;
    }
}

