
namespace CreatingADatabase.GUI
{
    partial class AddProjectForm
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
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxProjTitle = new System.Windows.Forms.TextBox();
            this.txtBoxProjManager = new System.Windows.Forms.TextBox();
            this.txtBoxProjBudget = new System.Windows.Forms.TextBox();
            this.calendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.calendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddProj = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkBoxProjCompleted = new System.Windows.Forms.CheckBox();
            this.lboxAvailableEmployees = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lboxSelectedEmployees = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(17, 80);
            this.lblProjectTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(95, 20);
            this.lblProjectTitle.TabIndex = 3;
            this.lblProjectTitle.Text = "Project Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Project Manager:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project Budget";
            // 
            // txtBoxProjTitle
            // 
            this.txtBoxProjTitle.Location = new System.Drawing.Point(137, 79);
            this.txtBoxProjTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxProjTitle.Name = "txtBoxProjTitle";
            this.txtBoxProjTitle.Size = new System.Drawing.Size(132, 20);
            this.txtBoxProjTitle.TabIndex = 7;
            // 
            // txtBoxProjManager
            // 
            this.txtBoxProjManager.Location = new System.Drawing.Point(137, 107);
            this.txtBoxProjManager.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxProjManager.Name = "txtBoxProjManager";
            this.txtBoxProjManager.Size = new System.Drawing.Size(132, 20);
            this.txtBoxProjManager.TabIndex = 8;
            // 
            // txtBoxProjBudget
            // 
            this.txtBoxProjBudget.Location = new System.Drawing.Point(137, 134);
            this.txtBoxProjBudget.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxProjBudget.Name = "txtBoxProjBudget";
            this.txtBoxProjBudget.Size = new System.Drawing.Size(132, 20);
            this.txtBoxProjBudget.TabIndex = 9;
            // 
            // calendarStartDate
            // 
            this.calendarStartDate.Location = new System.Drawing.Point(397, 80);
            this.calendarStartDate.Margin = new System.Windows.Forms.Padding(7);
            this.calendarStartDate.Name = "calendarStartDate";
            this.calendarStartDate.TabIndex = 10;
            // 
            // calendarEndDate
            // 
            this.calendarEndDate.Location = new System.Drawing.Point(638, 79);
            this.calendarEndDate.Margin = new System.Windows.Forms.Padding(7);
            this.calendarEndDate.Name = "calendarEndDate";
            this.calendarEndDate.TabIndex = 11;
            this.calendarEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Project Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Project End Date";
            // 
            // btnAddProj
            // 
            this.btnAddProj.Location = new System.Drawing.Point(714, 545);
            this.btnAddProj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Size = new System.Drawing.Size(74, 23);
            this.btnAddProj.TabIndex = 15;
            this.btnAddProj.Text = "Add Project";
            this.btnAddProj.UseVisualStyleBackColor = true;
            this.btnAddProj.Click += new System.EventHandler(this.btnAddProj_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(792, 545);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // checkBoxProjCompleted
            // 
            this.checkBoxProjCompleted.AutoSize = true;
            this.checkBoxProjCompleted.Location = new System.Drawing.Point(270, 224);
            this.checkBoxProjCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxProjCompleted.Name = "checkBoxProjCompleted";
            this.checkBoxProjCompleted.Size = new System.Drawing.Size(118, 17);
            this.checkBoxProjCompleted.TabIndex = 14;
            this.checkBoxProjCompleted.Text = "Project Completed?";
            this.checkBoxProjCompleted.UseVisualStyleBackColor = true;
            this.checkBoxProjCompleted.CheckedChanged += new System.EventHandler(this.checkBoxProjCompleted_CheckedChanged);
            // 
            // lboxAvailableEmployees
            // 
            this.lboxAvailableEmployees.FormattingEnabled = true;
            this.lboxAvailableEmployees.Location = new System.Drawing.Point(12, 394);
            this.lboxAvailableEmployees.Name = "lboxAvailableEmployees";
            this.lboxAvailableEmployees.Size = new System.Drawing.Size(185, 173);
            this.lboxAvailableEmployees.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gazelle", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Available Employees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gazelle", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Selected Employees";
            // 
            // lboxSelectedEmployees
            // 
            this.lboxSelectedEmployees.FormattingEnabled = true;
            this.lboxSelectedEmployees.Location = new System.Drawing.Point(258, 394);
            this.lboxSelectedEmployees.Name = "lboxSelectedEmployees";
            this.lboxSelectedEmployees.Size = new System.Drawing.Size(185, 173);
            this.lboxSelectedEmployees.TabIndex = 19;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Gazelle", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(212, 432);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 40);
            this.btnSelect.TabIndex = 21;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Font = new System.Drawing.Font("Gazelle", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselect.Location = new System.Drawing.Point(203, 478);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(40, 40);
            this.btnDeselect.TabIndex = 22;
            this.btnDeselect.Text = "<";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 579);
            this.Controls.Add(this.btnDeselect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lboxSelectedEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxAvailableEmployees);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddProj);
            this.Controls.Add(this.checkBoxProjCompleted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calendarEndDate);
            this.Controls.Add(this.calendarStartDate);
            this.Controls.Add(this.txtBoxProjBudget);
            this.Controls.Add(this.txtBoxProjManager);
            this.Controls.Add(this.txtBoxProjTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProjectTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProjectForm";
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxProjTitle;
        private System.Windows.Forms.TextBox txtBoxProjManager;
        private System.Windows.Forms.TextBox txtBoxProjBudget;
        private System.Windows.Forms.MonthCalendar calendarStartDate;
        private System.Windows.Forms.MonthCalendar calendarEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddProj;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkBoxProjCompleted;
        private System.Windows.Forms.ListBox lboxAvailableEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lboxSelectedEmployees;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDeselect;
    }
}