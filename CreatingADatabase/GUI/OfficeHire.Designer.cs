
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
            this.DGVAvailability = new System.Windows.Forms.DataGridView();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.TBStaffName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numBoxMonths = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // CBoxClients
            // 
            this.CBoxClients.FormattingEnabled = true;
            this.CBoxClients.Location = new System.Drawing.Point(383, 128);
            this.CBoxClients.Name = "CBoxClients";
            this.CBoxClients.Size = new System.Drawing.Size(201, 21);
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
            this.CBoxYear.Location = new System.Drawing.Point(19, 63);
            this.CBoxYear.Name = "CBoxYear";
            this.CBoxYear.Size = new System.Drawing.Size(120, 21);
            this.CBoxYear.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year:";
            // 
            // DGVAvailability
            // 
            this.DGVAvailability.AllowUserToAddRows = false;
            this.DGVAvailability.AllowUserToDeleteRows = false;
            this.DGVAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAvailability.Location = new System.Drawing.Point(19, 109);
            this.DGVAvailability.Name = "DGVAvailability";
            this.DGVAvailability.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVAvailability.Size = new System.Drawing.Size(355, 293);
            this.DGVAvailability.TabIndex = 6;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 10);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(53, 26);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(152, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Room Number:";
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTable.Location = new System.Drawing.Point(383, 374);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(102, 28);
            this.btnRefreshTable.TabIndex = 12;
            this.btnRefreshTable.Text = "Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Make a new booking:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "How many months?";
            // 
            // CBoxRoomNo
            // 
            this.CBoxRoomNo.FormattingEnabled = true;
            this.CBoxRoomNo.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.CBoxRoomNo.Location = new System.Drawing.Point(383, 259);
            this.CBoxRoomNo.Name = "CBoxRoomNo";
            this.CBoxRoomNo.Size = new System.Drawing.Size(201, 21);
            this.CBoxRoomNo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Room No.";
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Location = new System.Drawing.Point(383, 173);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(201, 20);
            this.DTPStartDate.TabIndex = 20;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.Location = new System.Drawing.Point(383, 338);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(116, 28);
            this.btnAddBooking.TabIndex = 22;
            this.btnAddBooking.Text = "Update Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // TBStaffName
            // 
            this.TBStaffName.Location = new System.Drawing.Point(385, 304);
            this.TBStaffName.Name = "TBStaffName";
            this.TBStaffName.Size = new System.Drawing.Size(198, 20);
            this.TBStaffName.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Staff Name:";
            // 
            // numBoxMonths
            // 
            this.numBoxMonths.Location = new System.Drawing.Point(383, 221);
            this.numBoxMonths.Name = "numBoxMonths";
            this.numBoxMonths.Size = new System.Drawing.Size(60, 20);
            this.numBoxMonths.TabIndex = 25;
            // 
            // OfficeHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 417);
            this.Controls.Add(this.numBoxMonths);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBStaffName);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.DTPStartDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBoxRoomNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.DGVAvailability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxYear);
            this.Controls.Add(this.CBoxClients);
            this.Name = "OfficeHire";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfficeHire";
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBoxClients;
        private System.Windows.Forms.ComboBox CBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVAvailability;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxRoomNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.TextBox TBStaffName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numBoxMonths;
    }
}