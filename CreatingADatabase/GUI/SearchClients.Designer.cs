
namespace CreatingADatabase.GUI
{
    partial class SearchClients
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
            this.ClientDatagrid = new System.Windows.Forms.DataGridView();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.txtClientSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientDatagrid
            // 
            this.ClientDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDatagrid.Location = new System.Drawing.Point(11, 157);
            this.ClientDatagrid.Margin = new System.Windows.Forms.Padding(2);
            this.ClientDatagrid.Name = "ClientDatagrid";
            this.ClientDatagrid.RowTemplate.Height = 24;
            this.ClientDatagrid.Size = new System.Drawing.Size(778, 282);
            this.ClientDatagrid.TabIndex = 5;
            this.ClientDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDataGrid_CellClick);
            // 
            // btnSearchClients
            // 
            this.btnSearchClients.Location = new System.Drawing.Point(113, 51);
            this.btnSearchClients.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchClients.Name = "btnSearchClients";
            this.btnSearchClients.Size = new System.Drawing.Size(574, 19);
            this.btnSearchClients.TabIndex = 8;
            this.btnSearchClients.Text = "Search";
            this.btnSearchClients.UseVisualStyleBackColor = true;
            this.btnSearchClients.Click += new System.EventHandler(this.btnSearchClients_Click);
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Location = new System.Drawing.Point(188, 27);
            this.txtClientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.Size = new System.Drawing.Size(500, 20);
            this.txtClientSearch.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Business name or client number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Double click on a cell to edit it";
            // 
            // SearchClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchClients);
            this.Controls.Add(this.txtClientSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientDatagrid);
            this.Name = "SearchClients";
            this.Text = "SearchClients";
            this.Load += new System.EventHandler(this.SearchClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientDatagrid;
        private System.Windows.Forms.Button btnSearchClients;
        private System.Windows.Forms.TextBox txtClientSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}