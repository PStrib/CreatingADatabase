
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
            this.btnConferenceBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeBanner
            // 
            this.WelcomeBanner.AutoSize = true;
            this.WelcomeBanner.Font = new System.Drawing.Font("Gazelle", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBanner.Location = new System.Drawing.Point(59, 9);
            this.WelcomeBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeBanner.Name = "WelcomeBanner";
            this.WelcomeBanner.Size = new System.Drawing.Size(187, 44);
            this.WelcomeBanner.TabIndex = 0;
            this.WelcomeBanner.Text = "Simpson\'s";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(20, 84);
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
            this.btnSearchEdit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEdit.Location = new System.Drawing.Point(20, 132);
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
            this.btnBooking.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(20, 180);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(268, 35);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Book an Office";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnConferenceBooking
            // 
            this.btnConferenceBooking.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferenceBooking.Location = new System.Drawing.Point(20, 229);
            this.btnConferenceBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnConferenceBooking.Name = "btnConferenceBooking";
            this.btnConferenceBooking.Size = new System.Drawing.Size(268, 35);
            this.btnConferenceBooking.TabIndex = 8;
            this.btnConferenceBooking.Text = "Book the Conference Suite";
            this.btnConferenceBooking.UseVisualStyleBackColor = true;
            this.btnConferenceBooking.Click += new System.EventHandler(this.btnConferenceBooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gazelle", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Department Store";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConferenceBooking);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnSearchEdit);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.WelcomeBanner);
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
        private System.Windows.Forms.Button btnConferenceBooking;
        private System.Windows.Forms.Label label1;
    }
}