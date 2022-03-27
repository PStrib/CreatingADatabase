
namespace CreatingADatabase.GUI
{
    partial class EditForm
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
            this.lblSelectProj = new System.Windows.Forms.Label();
            this.comboBoxSelectProj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxProjID = new System.Windows.Forms.TextBox();
            this.txtBoxProjTitle = new System.Windows.Forms.TextBox();
            this.txtBoxProjManager = new System.Windows.Forms.TextBox();
            this.txtBoxProjBudget = new System.Windows.Forms.TextBox();
            this.calendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.calendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxProjCompleted = new System.Windows.Forms.CheckBox();
            this.btnEditProj = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectProj
            // 
            this.lblSelectProj.AutoSize = true;
            this.lblSelectProj.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProj.Location = new System.Drawing.Point(17, 15);
            this.lblSelectProj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectProj.Name = "lblSelectProj";
            this.lblSelectProj.Size = new System.Drawing.Size(192, 23);
            this.lblSelectProj.TabIndex = 0;
            this.lblSelectProj.Text = "Select project to edit:";
            // 
            // comboBoxSelectProj
            // 
            this.comboBoxSelectProj.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectProj.FormattingEnabled = true;
            this.comboBoxSelectProj.Location = new System.Drawing.Point(179, 16);
            this.comboBoxSelectProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSelectProj.Name = "comboBoxSelectProj";
            this.comboBoxSelectProj.Size = new System.Drawing.Size(442, 26);
            this.comboBoxSelectProj.TabIndex = 1;
            this.comboBoxSelectProj.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectProj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project ID:";
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
            // txtBoxProjID
            // 
            this.txtBoxProjID.Enabled = false;
            this.txtBoxProjID.Location = new System.Drawing.Point(137, 51);
            this.txtBoxProjID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxProjID.Name = "txtBoxProjID";
            this.txtBoxProjID.Size = new System.Drawing.Size(132, 20);
            this.txtBoxProjID.TabIndex = 6;
            // 
            // txtBoxProjTitle
            // 
            this.txtBoxProjTitle.Location = new System.Drawing.Point(137, 79);
            this.txtBoxProjTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxProjTitle.Name = "txtBoxProjTitle";
            this.txtBoxProjTitle.Size = new System.Drawing.Size(132, 20);
            this.txtBoxProjTitle.TabIndex = 7;
            // 
            // txtBoxProjManager
            // 
            this.txtBoxProjManager.Location = new System.Drawing.Point(137, 107);
            this.txtBoxProjManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxProjManager.Name = "txtBoxProjManager";
            this.txtBoxProjManager.Size = new System.Drawing.Size(132, 20);
            this.txtBoxProjManager.TabIndex = 8;
            // 
            // txtBoxProjBudget
            // 
            this.txtBoxProjBudget.Location = new System.Drawing.Point(137, 134);
            this.txtBoxProjBudget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxProjBudget.Name = "txtBoxProjBudget";
            this.txtBoxProjBudget.Size = new System.Drawing.Size(132, 20);
            this.txtBoxProjBudget.TabIndex = 9;
            // 
            // calendarStartDate
            // 
            this.calendarStartDate.Location = new System.Drawing.Point(125, 205);
            this.calendarStartDate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.calendarStartDate.Name = "calendarStartDate";
            this.calendarStartDate.TabIndex = 10;
            // 
            // calendarEndDate
            // 
            this.calendarEndDate.Location = new System.Drawing.Point(438, 205);
            this.calendarEndDate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.calendarEndDate.Name = "calendarEndDate";
            this.calendarEndDate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Project Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Project End Date";
            // 
            // checkBoxProjCompleted
            // 
            this.checkBoxProjCompleted.AutoSize = true;
            this.checkBoxProjCompleted.Location = new System.Drawing.Point(34, 353);
            this.checkBoxProjCompleted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxProjCompleted.Name = "checkBoxProjCompleted";
            this.checkBoxProjCompleted.Size = new System.Drawing.Size(118, 17);
            this.checkBoxProjCompleted.TabIndex = 14;
            this.checkBoxProjCompleted.Text = "Project Completed?";
            this.checkBoxProjCompleted.UseVisualStyleBackColor = true;
            // 
            // btnEditProj
            // 
            this.btnEditProj.Location = new System.Drawing.Point(320, 383);
            this.btnEditProj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditProj.Name = "btnEditProj";
            this.btnEditProj.Size = new System.Drawing.Size(70, 18);
            this.btnEditProj.TabIndex = 15;
            this.btnEditProj.Text = "Edit Project";
            this.btnEditProj.UseVisualStyleBackColor = true;
            this.btnEditProj.Click += new System.EventHandler(this.btnEditProj_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(410, 383);
            this.btnCancelEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(64, 18);
            this.btnCancelEdit.TabIndex = 16;
            this.btnCancelEdit.Text = "Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 410);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnEditProj);
            this.Controls.Add(this.checkBoxProjCompleted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calendarEndDate);
            this.Controls.Add(this.calendarStartDate);
            this.Controls.Add(this.txtBoxProjBudget);
            this.Controls.Add(this.txtBoxProjManager);
            this.Controls.Add(this.txtBoxProjTitle);
            this.Controls.Add(this.txtBoxProjID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProjectTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectProj);
            this.Controls.Add(this.lblSelectProj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectProj;
        private System.Windows.Forms.ComboBox comboBoxSelectProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxProjID;
        private System.Windows.Forms.TextBox txtBoxProjTitle;
        private System.Windows.Forms.TextBox txtBoxProjManager;
        private System.Windows.Forms.TextBox txtBoxProjBudget;
        private System.Windows.Forms.MonthCalendar calendarStartDate;
        private System.Windows.Forms.MonthCalendar calendarEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxProjCompleted;
        private System.Windows.Forms.Button btnEditProj;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}