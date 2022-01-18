
namespace CreatingADatabase.GUI
{
    partial class OfficeHire
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
            this.CBoxClients = new System.Windows.Forms.ComboBox();
            this.CBoxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGVColJanuary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColFebruary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColMarch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColApril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColJune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColJuly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColAugust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColSeptember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColNovember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColDecember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBoxClients
            // 
            this.CBoxClients.FormattingEnabled = true;
            this.CBoxClients.Location = new System.Drawing.Point(15, 25);
            this.CBoxClients.Name = "CBoxClients";
            this.CBoxClients.Size = new System.Drawing.Size(314, 21);
            this.CBoxClients.TabIndex = 2;
            // 
            // CBoxYear
            // 
            this.CBoxYear.FormattingEnabled = true;
            this.CBoxYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.CBoxYear.Location = new System.Drawing.Point(15, 66);
            this.CBoxYear.Name = "CBoxYear";
            this.CBoxYear.Size = new System.Drawing.Size(120, 21);
            this.CBoxYear.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVColJanuary,
            this.DGVColFebruary,
            this.DGVColMarch,
            this.DGVColApril,
            this.DGVColMay,
            this.DGVColJune,
            this.DGVColJuly,
            this.DGVColAugust,
            this.DGVColSeptember,
            this.DGVColNovember,
            this.DGVColDecember});
            this.dataGridView1.Location = new System.Drawing.Point(20, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 328);
            this.dataGridView1.TabIndex = 6;
            // 
            // DGVColJanuary
            // 
            this.DGVColJanuary.HeaderText = "January";
            this.DGVColJanuary.Name = "DGVColJanuary";
            this.DGVColJanuary.ReadOnly = true;
            // 
            // DGVColFebruary
            // 
            this.DGVColFebruary.HeaderText = "February";
            this.DGVColFebruary.Name = "DGVColFebruary";
            this.DGVColFebruary.ReadOnly = true;
            // 
            // DGVColMarch
            // 
            this.DGVColMarch.HeaderText = "March";
            this.DGVColMarch.Name = "DGVColMarch";
            this.DGVColMarch.ReadOnly = true;
            // 
            // DGVColApril
            // 
            this.DGVColApril.HeaderText = "April";
            this.DGVColApril.Name = "DGVColApril";
            this.DGVColApril.ReadOnly = true;
            // 
            // DGVColMay
            // 
            this.DGVColMay.HeaderText = "May";
            this.DGVColMay.Name = "DGVColMay";
            this.DGVColMay.ReadOnly = true;
            // 
            // DGVColJune
            // 
            this.DGVColJune.HeaderText = "June";
            this.DGVColJune.Name = "DGVColJune";
            this.DGVColJune.ReadOnly = true;
            // 
            // DGVColJuly
            // 
            this.DGVColJuly.HeaderText = "July";
            this.DGVColJuly.Name = "DGVColJuly";
            this.DGVColJuly.ReadOnly = true;
            // 
            // DGVColAugust
            // 
            this.DGVColAugust.HeaderText = "August";
            this.DGVColAugust.Name = "DGVColAugust";
            this.DGVColAugust.ReadOnly = true;
            // 
            // DGVColSeptember
            // 
            this.DGVColSeptember.HeaderText = "September";
            this.DGVColSeptember.Name = "DGVColSeptember";
            this.DGVColSeptember.ReadOnly = true;
            // 
            // DGVColNovember
            // 
            this.DGVColNovember.HeaderText = "November";
            this.DGVColNovember.Name = "DGVColNovember";
            this.DGVColNovember.ReadOnly = true;
            // 
            // DGVColDecember
            // 
            this.DGVColDecember.HeaderText = "December";
            this.DGVColDecember.Name = "DGVColDecember";
            this.DGVColDecember.ReadOnly = true;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.btnBackToMenu.Location = new System.Drawing.Point(994, 24);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(150, 38);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Back to main menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // OfficeHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 464);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxYear);
            this.Controls.Add(this.CBoxClients);
            this.Name = "OfficeHire";
            this.Text = "OfficeHire";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBoxClients;
        private System.Windows.Forms.ComboBox CBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColJanuary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColFebruary;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColMarch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColApril;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColJune;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColJuly;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColAugust;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColSeptember;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColNovember;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColDecember;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}