
namespace CreatingADatabase.GUI
{
    partial class InnerJoinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGenerateSQL = new System.Windows.Forms.Button();
            this.CBoxFirstTable = new System.Windows.Forms.ComboBox();
            this.CBoxSecondTable = new System.Windows.Forms.ComboBox();
            this.CBoxTable1Column = new System.Windows.Forms.ComboBox();
            this.CBoxTable2Column = new System.Windows.Forms.ComboBox();
            this.CBoxField = new System.Windows.Forms.ComboBox();
            this.CBoxCondition = new System.Windows.Forms.ComboBox();
            this.CBoxValue = new System.Windows.Forms.ComboBox();
            this.CheckListTable1 = new System.Windows.Forms.CheckedListBox();
            this.CheckListTable2 = new System.Windows.Forms.CheckedListBox();
            this.TextBoxQuery = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gazelle", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inner Join Query Builder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "This query builder will allow you to select two tables to query within the databa" +
    "se, select the fields to compare based on a condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select First Table:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(154, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Second Table:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(354, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select First Table Column:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(577, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Second Table Column:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(354, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select Field of Interest:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(538, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Condition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(623, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Value:";
            // 
            // BtnGenerateSQL
            // 
            this.BtnGenerateSQL.BackColor = System.Drawing.Color.Purple;
            this.BtnGenerateSQL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateSQL.ForeColor = System.Drawing.Color.Silver;
            this.BtnGenerateSQL.Location = new System.Drawing.Point(703, 136);
            this.BtnGenerateSQL.Name = "BtnGenerateSQL";
            this.BtnGenerateSQL.Size = new System.Drawing.Size(77, 51);
            this.BtnGenerateSQL.TabIndex = 16;
            this.BtnGenerateSQL.Text = "Generate SQL";
            this.BtnGenerateSQL.UseVisualStyleBackColor = false;
            this.BtnGenerateSQL.Click += new System.EventHandler(this.BtnGenerateSQL_Click);
            // 
            // CBoxFirstTable
            // 
            this.CBoxFirstTable.FormattingEnabled = true;
            this.CBoxFirstTable.Location = new System.Drawing.Point(12, 100);
            this.CBoxFirstTable.Name = "CBoxFirstTable";
            this.CBoxFirstTable.Size = new System.Drawing.Size(122, 21);
            this.CBoxFirstTable.TabIndex = 17;
            // 
            // CBoxSecondTable
            // 
            this.CBoxSecondTable.FormattingEnabled = true;
            this.CBoxSecondTable.Location = new System.Drawing.Point(158, 100);
            this.CBoxSecondTable.Name = "CBoxSecondTable";
            this.CBoxSecondTable.Size = new System.Drawing.Size(144, 21);
            this.CBoxSecondTable.TabIndex = 18;
            // 
            // CBoxTable1Column
            // 
            this.CBoxTable1Column.FormattingEnabled = true;
            this.CBoxTable1Column.Location = new System.Drawing.Point(358, 100);
            this.CBoxTable1Column.Name = "CBoxTable1Column";
            this.CBoxTable1Column.Size = new System.Drawing.Size(179, 21);
            this.CBoxTable1Column.TabIndex = 19;
            // 
            // CBoxTable2Column
            // 
            this.CBoxTable2Column.FormattingEnabled = true;
            this.CBoxTable2Column.Location = new System.Drawing.Point(581, 100);
            this.CBoxTable2Column.Name = "CBoxTable2Column";
            this.CBoxTable2Column.Size = new System.Drawing.Size(199, 21);
            this.CBoxTable2Column.TabIndex = 20;
            // 
            // CBoxField
            // 
            this.CBoxField.FormattingEnabled = true;
            this.CBoxField.Location = new System.Drawing.Point(358, 152);
            this.CBoxField.Name = "CBoxField";
            this.CBoxField.Size = new System.Drawing.Size(161, 21);
            this.CBoxField.TabIndex = 21;
            // 
            // CBoxCondition
            // 
            this.CBoxCondition.FormattingEnabled = true;
            this.CBoxCondition.Location = new System.Drawing.Point(542, 152);
            this.CBoxCondition.Name = "CBoxCondition";
            this.CBoxCondition.Size = new System.Drawing.Size(75, 21);
            this.CBoxCondition.TabIndex = 22;
            // 
            // CBoxValue
            // 
            this.CBoxValue.FormattingEnabled = true;
            this.CBoxValue.Location = new System.Drawing.Point(627, 152);
            this.CBoxValue.Name = "CBoxValue";
            this.CBoxValue.Size = new System.Drawing.Size(54, 21);
            this.CBoxValue.TabIndex = 23;
            // 
            // CheckListTable1
            // 
            this.CheckListTable1.FormattingEnabled = true;
            this.CheckListTable1.Location = new System.Drawing.Point(3, 186);
            this.CheckListTable1.Name = "CheckListTable1";
            this.CheckListTable1.Size = new System.Drawing.Size(148, 109);
            this.CheckListTable1.TabIndex = 24;
            // 
            // CheckListTable2
            // 
            this.CheckListTable2.FormattingEnabled = true;
            this.CheckListTable2.Location = new System.Drawing.Point(158, 186);
            this.CheckListTable2.Name = "CheckListTable2";
            this.CheckListTable2.Size = new System.Drawing.Size(148, 109);
            this.CheckListTable2.TabIndex = 25;
            // 
            // TextBoxQuery
            // 
            this.TextBoxQuery.Location = new System.Drawing.Point(325, 186);
            this.TextBoxQuery.Multiline = true;
            this.TextBoxQuery.Name = "TextBoxQuery";
            this.TextBoxQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxQuery.Size = new System.Drawing.Size(356, 109);
            this.TextBoxQuery.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(704, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 51);
            this.button1.TabIndex = 27;
            this.button1.Text = "Execute SQL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(8, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Results:";
            // 
            // DataGridResults
            // 
            this.DataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridResults.Location = new System.Drawing.Point(10, 330);
            this.DataGridResults.Name = "DataGridResults";
            this.DataGridResults.Size = new System.Drawing.Size(783, 114);
            this.DataGridResults.TabIndex = 29;
            // 
            // InnerJoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridResults);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxQuery);
            this.Controls.Add(this.CheckListTable2);
            this.Controls.Add(this.CheckListTable1);
            this.Controls.Add(this.CBoxValue);
            this.Controls.Add(this.CBoxCondition);
            this.Controls.Add(this.CBoxField);
            this.Controls.Add(this.CBoxTable2Column);
            this.Controls.Add(this.CBoxTable1Column);
            this.Controls.Add(this.CBoxSecondTable);
            this.Controls.Add(this.CBoxFirstTable);
            this.Controls.Add(this.BtnGenerateSQL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InnerJoinForm";
            this.Text = "Inner Join Query Builder";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGenerateSQL;
        private System.Windows.Forms.ComboBox CBoxFirstTable;
        private System.Windows.Forms.ComboBox CBoxSecondTable;
        private System.Windows.Forms.ComboBox CBoxTable1Column;
        private System.Windows.Forms.ComboBox CBoxTable2Column;
        private System.Windows.Forms.ComboBox CBoxField;
        private System.Windows.Forms.ComboBox CBoxCondition;
        private System.Windows.Forms.ComboBox CBoxValue;
        private System.Windows.Forms.CheckedListBox CheckListTable1;
        private System.Windows.Forms.CheckedListBox CheckListTable2;
        private System.Windows.Forms.TextBox TextBoxQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DataGridResults;
    }
}