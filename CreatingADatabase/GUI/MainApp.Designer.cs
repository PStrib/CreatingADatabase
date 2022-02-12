
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.WelcomeBanner = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnSearchEdit = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeBanner
            // 
            this.WelcomeBanner.AutoSize = true;
            this.WelcomeBanner.Font = new System.Drawing.Font("Gazelle", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBanner.Location = new System.Drawing.Point(8, 7);
            this.WelcomeBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeBanner.Name = "WelcomeBanner";
            this.WelcomeBanner.Size = new System.Drawing.Size(345, 30);
            this.WelcomeBanner.TabIndex = 0;
            this.WelcomeBanner.Text = "Simpson\'s Department Store";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Gazelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(41, 42);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(268, 35);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnSearchEdit
            // 
            this.btnSearchEdit.Font = new System.Drawing.Font("Gazelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEdit.Location = new System.Drawing.Point(41, 81);
            this.btnSearchEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchEdit.Name = "btnSearchEdit";
            this.btnSearchEdit.Size = new System.Drawing.Size(268, 35);
            this.btnSearchEdit.TabIndex = 6;
            this.btnSearchEdit.Text = "Search/Edit client details";
            this.btnSearchEdit.UseVisualStyleBackColor = true;
            this.btnSearchEdit.Click += new System.EventHandler(this.btnSearchEdit_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Gazelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(41, 120);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(268, 35);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Make A Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 244);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnSearchEdit);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.WelcomeBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simpson\'s Department Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeBanner;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnSearchEdit;
        private System.Windows.Forms.Button btnBooking;
    }
}