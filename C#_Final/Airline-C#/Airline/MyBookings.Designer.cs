namespace Airline
{
    partial class MyBookings
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet = new Airline.App_Data.AirlineDataSet();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Unbook = new System.Windows.Forms.Button();
            this.bookTableAdapter = new Airline.App_Data.AirlineDataSetTableAdapters.BookTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.flightNoDataGridViewTextBoxColumn,
            this.ticketTypeDataGridViewTextBoxColumn,
            this.bookTimeDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.airlineDataSet;
            // 
            // airlineDataSet
            // 
            this.airlineDataSet.DataSetName = "AirlineDataSet";
            this.airlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(14, 17);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(116, 23);
            this.textBox_Search.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(148, 15);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(87, 26);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Unbook
            // 
            this.button_Unbook.Location = new System.Drawing.Point(283, 15);
            this.button_Unbook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Unbook.Name = "button_Unbook";
            this.button_Unbook.Size = new System.Drawing.Size(87, 26);
            this.button_Unbook.TabIndex = 3;
            this.button_Unbook.Text = "Unbook";
            this.button_Unbook.UseVisualStyleBackColor = true;
            this.button_Unbook.Click += new System.EventHandler(this.button_Unbook_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightNoDataGridViewTextBoxColumn
            // 
            this.flightNoDataGridViewTextBoxColumn.DataPropertyName = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.HeaderText = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.Name = "flightNoDataGridViewTextBoxColumn";
            this.flightNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ticketTypeDataGridViewTextBoxColumn
            // 
            this.ticketTypeDataGridViewTextBoxColumn.DataPropertyName = "TicketType";
            this.ticketTypeDataGridViewTextBoxColumn.HeaderText = "TicketType";
            this.ticketTypeDataGridViewTextBoxColumn.Name = "ticketTypeDataGridViewTextBoxColumn";
            this.ticketTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTimeDataGridViewTextBoxColumn
            // 
            this.bookTimeDataGridViewTextBoxColumn.DataPropertyName = "BookTime";
            this.bookTimeDataGridViewTextBoxColumn.HeaderText = "BookTime";
            this.bookTimeDataGridViewTextBoxColumn.Name = "bookTimeDataGridViewTextBoxColumn";
            this.bookTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // MyBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 461);
            this.Controls.Add(this.button_Unbook);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  My Bookings";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Unbook;
        private App_Data.AirlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private App_Data.AirlineDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
    }
}