
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
            this.CBoxYear.Location = new System.Drawing.Point(12, 65);
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
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year:";
            // 
            // OfficeHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxYear);
            this.Controls.Add(this.CBoxClients);
            this.Name = "OfficeHire";
            this.Text = "OfficeHire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBoxClients;
        private System.Windows.Forms.ComboBox CBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}