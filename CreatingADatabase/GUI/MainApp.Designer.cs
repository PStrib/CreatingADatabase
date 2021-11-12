
namespace CreatingADatabase.GUI
{
    partial class MainApp
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
            this.WelcomeBanner = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeBanner
            // 
            this.WelcomeBanner.AutoSize = true;
            this.WelcomeBanner.Font = new System.Drawing.Font("Gazelle", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBanner.Location = new System.Drawing.Point(11, 7);
            this.WelcomeBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeBanner.Name = "WelcomeBanner";
            this.WelcomeBanner.Size = new System.Drawing.Size(345, 30);
            this.WelcomeBanner.TabIndex = 0;
            this.WelcomeBanner.Text = "Simpson\'s Department Store";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Gazelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(103, 39);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(140, 35);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 244);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.WelcomeBanner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainApp";
            this.Text = "Simpson\'s Department Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeBanner;
        private System.Windows.Forms.Button btnAddClient;
    }
}