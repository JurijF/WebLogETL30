
namespace WebLogETL30
{
    partial class ImportForm
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
            this.dataGridV_import_Main = new System.Windows.Forms.DataGridView();
            this.btn_import_Load = new System.Windows.Forms.Button();
            this.btn_import_ImportStart = new System.Windows.Forms.Button();
            this.column_import_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_import_DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_import_Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_import_Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_import_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_import_Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_import_Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_import_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridV_import_Main
            // 
            this.dataGridV_import_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_import_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_import_IP,
            this.column_import_DateTime,
            this.column_import_Typ,
            this.column_import_Event,
            this.column_import_Status,
            this.column_import_Nummer,
            this.column_import_Hash});
            this.dataGridV_import_Main.Location = new System.Drawing.Point(12, 43);
            this.dataGridV_import_Main.Name = "dataGridV_import_Main";
            this.dataGridV_import_Main.Size = new System.Drawing.Size(1240, 501);
            this.dataGridV_import_Main.TabIndex = 0;
            // 
            // btn_import_Load
            // 
            this.btn_import_Load.Location = new System.Drawing.Point(1177, 12);
            this.btn_import_Load.Name = "btn_import_Load";
            this.btn_import_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_import_Load.TabIndex = 1;
            this.btn_import_Load.Text = "Datei öffnen";
            this.btn_import_Load.UseVisualStyleBackColor = true;
            this.btn_import_Load.Click += new System.EventHandler(this.btn_import_Load_Click);
            // 
            // btn_import_ImportStart
            // 
            this.btn_import_ImportStart.Location = new System.Drawing.Point(1090, 12);
            this.btn_import_ImportStart.Name = "btn_import_ImportStart";
            this.btn_import_ImportStart.Size = new System.Drawing.Size(81, 23);
            this.btn_import_ImportStart.TabIndex = 2;
            this.btn_import_ImportStart.Text = "Import starten";
            this.btn_import_ImportStart.UseVisualStyleBackColor = true;
            this.btn_import_ImportStart.Click += new System.EventHandler(this.btn_import_ImportStart_Click);
            // 
            // column_import_IP
            // 
            this.column_import_IP.HeaderText = "IP";
            this.column_import_IP.Name = "column_import_IP";
            // 
            // column_import_DateTime
            // 
            this.column_import_DateTime.HeaderText = "DateTime";
            this.column_import_DateTime.Name = "column_import_DateTime";
            this.column_import_DateTime.Width = 150;
            // 
            // column_import_Typ
            // 
            this.column_import_Typ.HeaderText = "Typ";
            this.column_import_Typ.Name = "column_import_Typ";
            // 
            // column_import_Event
            // 
            this.column_import_Event.HeaderText = "Event";
            this.column_import_Event.Name = "column_import_Event";
            this.column_import_Event.Width = 640;
            // 
            // column_import_Status
            // 
            this.column_import_Status.HeaderText = "Status";
            this.column_import_Status.Name = "column_import_Status";
            // 
            // column_import_Nummer
            // 
            this.column_import_Nummer.HeaderText = "Nummer";
            this.column_import_Nummer.Name = "column_import_Nummer";
            // 
            // column_import_Hash
            // 
            this.column_import_Hash.HeaderText = "Hash";
            this.column_import_Hash.Name = "column_import_Hash";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 555);
            this.Controls.Add(this.btn_import_ImportStart);
            this.Controls.Add(this.btn_import_Load);
            this.Controls.Add(this.dataGridV_import_Main);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_import_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridV_import_Main;
        private System.Windows.Forms.Button btn_import_Load;
        private System.Windows.Forms.Button btn_import_ImportStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_import_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_import_DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_import_Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_import_Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_import_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_import_Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_import_Hash;
    }
}