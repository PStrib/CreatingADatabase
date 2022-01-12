
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
            this.LBoxClients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBoxClients
            // 
            this.LBoxClients.FormattingEnabled = true;
            this.LBoxClients.Location = new System.Drawing.Point(43, 114);
            this.LBoxClients.Name = "LBoxClients";
            this.LBoxClients.Size = new System.Drawing.Size(312, 30);
            this.LBoxClients.TabIndex = 0;
            // 
            // OfficeHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBoxClients);
            this.Name = "OfficeHire";
            this.Text = "OfficeHire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBoxClients;
    }
}