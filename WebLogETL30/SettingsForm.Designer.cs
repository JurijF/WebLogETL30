
namespace WebLogETL30
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_settings_CreateNewDB = new System.Windows.Forms.Button();
            this.btn_settings_SelectDB = new System.Windows.Forms.Button();
            this.lb_settings_SelectedDB = new System.Windows.Forms.Label();
            this.txtBox_settings_SelectedDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_settings_CreateNewDB
            // 
            this.btn_settings_CreateNewDB.Location = new System.Drawing.Point(12, 41);
            this.btn_settings_CreateNewDB.Name = "btn_settings_CreateNewDB";
            this.btn_settings_CreateNewDB.Size = new System.Drawing.Size(345, 41);
            this.btn_settings_CreateNewDB.TabIndex = 0;
            this.btn_settings_CreateNewDB.Text = "Neue Datenbank erstellen";
            this.btn_settings_CreateNewDB.UseVisualStyleBackColor = true;
            this.btn_settings_CreateNewDB.Click += new System.EventHandler(this.btn_settings_CreateNewDB_Click);
            // 
            // btn_settings_SelectDB
            // 
            this.btn_settings_SelectDB.Location = new System.Drawing.Point(12, 100);
            this.btn_settings_SelectDB.Name = "btn_settings_SelectDB";
            this.btn_settings_SelectDB.Size = new System.Drawing.Size(345, 41);
            this.btn_settings_SelectDB.TabIndex = 1;
            this.btn_settings_SelectDB.Text = "Datenbank wählen";
            this.btn_settings_SelectDB.UseVisualStyleBackColor = true;
            this.btn_settings_SelectDB.Click += new System.EventHandler(this.btn_settings_SelectDB_Click);
            // 
            // lb_settings_SelectedDB
            // 
            this.lb_settings_SelectedDB.AutoSize = true;
            this.lb_settings_SelectedDB.Location = new System.Drawing.Point(12, 153);
            this.lb_settings_SelectedDB.Name = "lb_settings_SelectedDB";
            this.lb_settings_SelectedDB.Size = new System.Drawing.Size(111, 13);
            this.lb_settings_SelectedDB.TabIndex = 2;
            this.lb_settings_SelectedDB.Text = "Gewählte Datenbank:";
            // 
            // txtBox_settings_SelectedDB
            // 
            this.txtBox_settings_SelectedDB.Location = new System.Drawing.Point(15, 169);
            this.txtBox_settings_SelectedDB.Name = "txtBox_settings_SelectedDB";
            this.txtBox_settings_SelectedDB.ReadOnly = true;
            this.txtBox_settings_SelectedDB.Size = new System.Drawing.Size(342, 20);
            this.txtBox_settings_SelectedDB.TabIndex = 3;
            this.txtBox_settings_SelectedDB.Text = "KEINE";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 201);
            this.Controls.Add(this.txtBox_settings_SelectedDB);
            this.Controls.Add(this.lb_settings_SelectedDB);
            this.Controls.Add(this.btn_settings_SelectDB);
            this.Controls.Add(this.btn_settings_CreateNewDB);
            this.Name = "SettingsForm";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_settings_CreateNewDB;
        private System.Windows.Forms.Button btn_settings_SelectDB;
        private System.Windows.Forms.Label lb_settings_SelectedDB;
        private System.Windows.Forms.TextBox txtBox_settings_SelectedDB;
    }
}