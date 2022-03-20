
namespace CreatingADatabase.GUI
{
    partial class ConferenceHire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceHire));
            this.numBoxDays = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.TBStaffName = new System.Windows.Forms.TextBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.DGVAvailability = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxClients = new System.Windows.Forms.ComboBox();
            this.DTPViewStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCateringReqs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailability)).BeginInit();
            this.SuspendLayout();
            // 
            // numBoxDays
            // 
            this.numBoxDays.Location = new System.Drawing.Point(218, 225);
            this.numBoxDays.Name = "numBoxDays";
            this.numBoxDays.Size = new System.Drawing.Size(60, 20);
            this.numBoxDays.TabIndex = 44;
            this.numBoxDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Staff Name:";
            // 
            // TBStaffName
            // 
            this.TBStaffName.Location = new System.Drawing.Point(218, 352);
            this.TBStaffName.Name = "TBStaffName";
            this.TBStaffName.Size = new System.Drawing.Size(198, 20);
            this.TBStaffName.TabIndex = 42;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.Location = new System.Drawing.Point(218, 378);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(116, 28);
            this.btnAddBooking.TabIndex = 41;
            this.btnAddBooking.Text = "Update Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Location = new System.Drawing.Point(218, 177);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(134, 20);
            this.DTPStartDate.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "How many days?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Make a new booking:";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.btnBackToMenu.Location = new System.Drawing.Point(11, 14);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(53, 26);
            this.btnBackToMenu.TabIndex = 31;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // DGVAvailability
            // 
            this.DGVAvailability.AllowUserToAddRows = false;
            this.DGVAvailability.AllowUserToDeleteRows = false;
            this.DGVAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAvailability.Location = new System.Drawing.Point(18, 113);
            this.DGVAvailability.Name = "DGVAvailability";
            this.DGVAvailability.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVAvailability.Size = new System.Drawing.Size(179, 293);
            this.DGVAvailability.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Client:";
            // 
            // CBoxClients
            // 
            this.CBoxClients.FormattingEnabled = true;
            this.CBoxClients.Location = new System.Drawing.Point(218, 132);
            this.CBoxClients.Name = "CBoxClients";
            this.CBoxClients.Size = new System.Drawing.Size(201, 21);
            this.CBoxClients.TabIndex = 26;
            // 
            // DTPViewStart
            // 
            this.DTPViewStart.Location = new System.Drawing.Point(18, 77);
            this.DTPViewStart.Name = "DTPViewStart";
            this.DTPViewStart.Size = new System.Drawing.Size(137, 20);
            this.DTPViewStart.TabIndex = 46;
            this.DTPViewStart.ValueChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "View From:";
            // 
            // txtCateringReqs
            // 
            this.txtCateringReqs.Location = new System.Drawing.Point(218, 267);
            this.txtCateringReqs.Multiline = true;
            this.txtCateringReqs.Name = "txtCateringReqs";
            this.txtCateringReqs.Size = new System.Drawing.Size(198, 53);
            this.txtCateringReqs.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Catering Requirements:";
            // 
            // ConferenceHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCateringReqs);
            this.Controls.Add(this.DTPViewStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numBoxDays);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBStaffName);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.DTPStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.DGVAvailability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConferenceHire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conference Hire";
            this.Load += new System.EventHandler(this.btnSearch_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAvailability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBoxDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBStaffName;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.DataGridView DGVAvailability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxClients;
        private System.Windows.Forms.DateTimePicker DTPViewStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCateringReqs;
        private System.Windows.Forms.Label label4;
    }
}