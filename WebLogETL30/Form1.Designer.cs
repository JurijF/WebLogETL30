
namespace WebLogETL30
{
    partial class Form1
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
            this.ImportFormBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbNummer = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.cbEvent = new System.Windows.Forms.CheckBox();
            this.cbMeth = new System.Windows.Forms.CheckBox();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbIP = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.cbDt = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbGet = new System.Windows.Forms.CheckBox();
            this.cbPost = new System.Windows.Forms.CheckBox();
            this.cbHead = new System.Windows.Forms.CheckBox();
            this.tbError = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportFormBtn
            // 
            this.ImportFormBtn.Location = new System.Drawing.Point(1176, 12);
            this.ImportFormBtn.Name = "ImportFormBtn";
            this.ImportFormBtn.Size = new System.Drawing.Size(75, 23);
            this.ImportFormBtn.TabIndex = 0;
            this.ImportFormBtn.Text = "Importer";
            this.ImportFormBtn.UseVisualStyleBackColor = true;
            this.ImportFormBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 501);
            this.dataGridView1.TabIndex = 1;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(12, 15);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(80, 23);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.Text = "Einstellungen";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cbDt);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 551);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 102);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 76);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Analyse 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1111, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Daten laden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbNummer);
            this.groupBox3.Controls.Add(this.cbStatus);
            this.groupBox3.Controls.Add(this.cbEvent);
            this.groupBox3.Controls.Add(this.cbMeth);
            this.groupBox3.Controls.Add(this.cbTime);
            this.groupBox3.Controls.Add(this.cbIP);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1056, 59);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attribute";
            // 
            // cbNummer
            // 
            this.cbNummer.AutoSize = true;
            this.cbNummer.Checked = true;
            this.cbNummer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNummer.Location = new System.Drawing.Point(501, 26);
            this.cbNummer.Name = "cbNummer";
            this.cbNummer.Size = new System.Drawing.Size(65, 17);
            this.cbNummer.TabIndex = 5;
            this.cbNummer.Text = "Nummer";
            this.cbNummer.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Location = new System.Drawing.Point(405, 26);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(56, 17);
            this.cbStatus.TabIndex = 4;
            this.cbStatus.Text = "Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // cbEvent
            // 
            this.cbEvent.AutoSize = true;
            this.cbEvent.Checked = true;
            this.cbEvent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEvent.Location = new System.Drawing.Point(306, 26);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(54, 17);
            this.cbEvent.TabIndex = 3;
            this.cbEvent.Text = "Event";
            this.cbEvent.UseVisualStyleBackColor = true;
            // 
            // cbMeth
            // 
            this.cbMeth.AutoSize = true;
            this.cbMeth.Checked = true;
            this.cbMeth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMeth.Location = new System.Drawing.Point(208, 26);
            this.cbMeth.Name = "cbMeth";
            this.cbMeth.Size = new System.Drawing.Size(68, 17);
            this.cbMeth.TabIndex = 2;
            this.cbMeth.Text = "Methode";
            this.cbMeth.UseVisualStyleBackColor = true;
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Checked = true;
            this.cbTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTime.Location = new System.Drawing.Point(102, 26);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(77, 17);
            this.cbTime.TabIndex = 1;
            this.cbTime.Text = "Timestamp";
            this.cbTime.UseVisualStyleBackColor = true;
            // 
            // cbIP
            // 
            this.cbIP.AutoSize = true;
            this.cbIP.Checked = true;
            this.cbIP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIP.Location = new System.Drawing.Point(6, 26);
            this.cbIP.Name = "cbIP";
            this.cbIP.Size = new System.Drawing.Size(36, 17);
            this.cbIP.TabIndex = 0;
            this.cbIP.Text = "IP";
            this.cbIP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analyse 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbHead);
            this.tabPage3.Controls.Add(this.cbPost);
            this.tabPage3.Controls.Add(this.cbGet);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 76);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Analyse 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.tbError);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1232, 76);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Analyse 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbIP);
            this.groupBox4.Location = new System.Drawing.Point(4, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1232, 59);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IP";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(6, 28);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(1220, 20);
            this.tbIP.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(4, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1062, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zeitraum";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(733, 22);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowCheckBox = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker3.TabIndex = 8;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(873, 22);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowCheckBox = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker4.TabIndex = 9;
            // 
            // cbDt
            // 
            this.cbDt.AutoSize = true;
            this.cbDt.Location = new System.Drawing.Point(1083, 153);
            this.cbDt.Name = "cbDt";
            this.cbDt.Size = new System.Drawing.Size(118, 17);
            this.cbDt.TabIndex = 7;
            this.cbDt.Text = "Zeitraum-Filter aktiv";
            this.cbDt.UseVisualStyleBackColor = true;
            this.cbDt.CheckedChanged += new System.EventHandler(this.cbDt_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Von:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(195, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1095, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Daten laden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1151, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Daten laden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1151, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Daten laden";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbGet
            // 
            this.cbGet.AutoSize = true;
            this.cbGet.Checked = true;
            this.cbGet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGet.Location = new System.Drawing.Point(23, 29);
            this.cbGet.Name = "cbGet";
            this.cbGet.Size = new System.Drawing.Size(48, 17);
            this.cbGet.TabIndex = 1;
            this.cbGet.Text = "GET";
            this.cbGet.UseVisualStyleBackColor = true;
            // 
            // cbPost
            // 
            this.cbPost.AutoSize = true;
            this.cbPost.Checked = true;
            this.cbPost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPost.Location = new System.Drawing.Point(119, 29);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(55, 17);
            this.cbPost.TabIndex = 2;
            this.cbPost.Text = "POST";
            this.cbPost.UseVisualStyleBackColor = true;
            // 
            // cbHead
            // 
            this.cbHead.AutoSize = true;
            this.cbHead.Checked = true;
            this.cbHead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHead.Location = new System.Drawing.Point(215, 29);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(56, 17);
            this.cbHead.TabIndex = 3;
            this.cbHead.Text = "HEAD";
            this.cbHead.UseVisualStyleBackColor = true;
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(80, 31);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(1065, 20);
            this.tbError.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1151, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Daten laden";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Error Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 835);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ImportFormBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportFormBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox cbDt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbNummer;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.CheckBox cbEvent;
        private System.Windows.Forms.CheckBox cbMeth;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.CheckBox cbIP;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox cbHead;
        private System.Windows.Forms.CheckBox cbPost;
        private System.Windows.Forms.CheckBox cbGet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbError;
    }
}

