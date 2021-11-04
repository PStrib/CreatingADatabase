
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
            this.btnSearchTool = new System.Windows.Forms.Button();
            this.btnEditProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeBanner
            // 
            this.WelcomeBanner.AutoSize = true;
            this.WelcomeBanner.Font = new System.Drawing.Font("Gazelle", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBanner.Location = new System.Drawing.Point(11, 7);
            this.WelcomeBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeBanner.Name = "WelcomeBanner";
            this.WelcomeBanner.Size = new System.Drawing.Size(412, 30);
            this.WelcomeBanner.TabIndex = 0;
            this.WelcomeBanner.Text = "Project Management Application";
            // 
            // btnSearchTool
            // 
            this.btnSearchTool.Font = new System.Drawing.Font("Gazelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTool.Location = new System.Drawing.Point(95, 43);
            this.btnSearchTool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchTool.Name = "btnSearchTool";
            this.btnSearchTool.Size = new System.Drawing.Size(140, 35);
            this.btnSearchTool.TabIndex = 1;
            this.btnSearchTool.Text = "Search Tool";
            this.btnSearchTool.UseVisualStyleBackColor = true;
            this.btnSearchTool.Click += new System.EventHandler(this.btnSearchTool_Click);
            // 
            // btnEditProject
            // 
            this.btnEditProject.Font = new System.Drawing.Font("Gazelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProject.Location = new System.Drawing.Point(95, 82);
            this.btnEditProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.Size = new System.Drawing.Size(140, 35);
            this.btnEditProject.TabIndex = 2;
            this.btnEditProject.Text = "Edit Project";
            this.btnEditProject.UseVisualStyleBackColor = true;
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Font = new System.Drawing.Font("Gazelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Location = new System.Drawing.Point(95, 121);
            this.btnAddProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(140, 35);
            this.btnAddProject.TabIndex = 3;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 191);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnEditProject);
            this.Controls.Add(this.btnSearchTool);
            this.Controls.Add(this.WelcomeBanner);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainApp";
            this.Text = "MainApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeBanner;
        private System.Windows.Forms.Button btnSearchTool;
        private System.Windows.Forms.Button btnEditProject;
        private System.Windows.Forms.Button btnAddProject;
    }
}