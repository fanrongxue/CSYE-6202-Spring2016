namespace Airline
{
    partial class Flights
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
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Book = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.airlineDataSet = new Airline.App_Data.AirlineDataSet();
            this.flightInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightInfoTableAdapter = new Airline.App_Data.AirlineDataSetTableAdapters.FlightInfoTableAdapter();
            this.flightNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavingAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyPlusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_Class = new System.Windows.Forms.ComboBox();
            this.button_Detail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // button_Book
            // 
            this.button_Book.Location = new System.Drawing.Point(440, 15);
            this.button_Book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Book.Name = "button_Book";
            this.button_Book.Size = new System.Drawing.Size(87, 26);
            this.button_Book.TabIndex = 3;
            this.button_Book.Text = "Book";
            this.button_Book.UseVisualStyleBackColor = true;
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
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
            this.flightNoDataGridViewTextBoxColumn,
            this.carrierNameDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.leavingAtDataGridViewTextBoxColumn,
            this.arrivalAtDataGridViewTextBoxColumn,
            this.economyDataGridViewTextBoxColumn,
            this.economyPlusDataGridViewTextBoxColumn,
            this.businessDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightInfoBindingSource;
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
            // airlineDataSet
            // 
            this.airlineDataSet.DataSetName = "AirlineDataSet";
            this.airlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightInfoBindingSource
            // 
            this.flightInfoBindingSource.DataMember = "FlightInfo";
            this.flightInfoBindingSource.DataSource = this.airlineDataSet;
            // 
            // flightInfoTableAdapter
            // 
            this.flightInfoTableAdapter.ClearBeforeFill = true;
            // 
            // flightNoDataGridViewTextBoxColumn
            // 
            this.flightNoDataGridViewTextBoxColumn.DataPropertyName = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.HeaderText = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.Name = "flightNoDataGridViewTextBoxColumn";
            this.flightNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carrierNameDataGridViewTextBoxColumn
            // 
            this.carrierNameDataGridViewTextBoxColumn.DataPropertyName = "CarrierName";
            this.carrierNameDataGridViewTextBoxColumn.HeaderText = "CarrierName";
            this.carrierNameDataGridViewTextBoxColumn.Name = "carrierNameDataGridViewTextBoxColumn";
            this.carrierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "Start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leavingAtDataGridViewTextBoxColumn
            // 
            this.leavingAtDataGridViewTextBoxColumn.DataPropertyName = "LeavingAt";
            this.leavingAtDataGridViewTextBoxColumn.HeaderText = "LeavingAt";
            this.leavingAtDataGridViewTextBoxColumn.Name = "leavingAtDataGridViewTextBoxColumn";
            this.leavingAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalAtDataGridViewTextBoxColumn
            // 
            this.arrivalAtDataGridViewTextBoxColumn.DataPropertyName = "ArrivalAt";
            this.arrivalAtDataGridViewTextBoxColumn.HeaderText = "ArrivalAt";
            this.arrivalAtDataGridViewTextBoxColumn.Name = "arrivalAtDataGridViewTextBoxColumn";
            this.arrivalAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economyDataGridViewTextBoxColumn
            // 
            this.economyDataGridViewTextBoxColumn.DataPropertyName = "Economy";
            this.economyDataGridViewTextBoxColumn.HeaderText = "Economy";
            this.economyDataGridViewTextBoxColumn.Name = "economyDataGridViewTextBoxColumn";
            this.economyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economyPlusDataGridViewTextBoxColumn
            // 
            this.economyPlusDataGridViewTextBoxColumn.DataPropertyName = "EconomyPlus";
            this.economyPlusDataGridViewTextBoxColumn.HeaderText = "EconomyPlus";
            this.economyPlusDataGridViewTextBoxColumn.Name = "economyPlusDataGridViewTextBoxColumn";
            this.economyPlusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessDataGridViewTextBoxColumn
            // 
            this.businessDataGridViewTextBoxColumn.DataPropertyName = "Business";
            this.businessDataGridViewTextBoxColumn.HeaderText = "Business";
            this.businessDataGridViewTextBoxColumn.Name = "businessDataGridViewTextBoxColumn";
            this.businessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comboBox_Class
            // 
            this.comboBox_Class.FormattingEnabled = true;
            this.comboBox_Class.Items.AddRange(new object[] {
            "Economy",
            "EconomyPlus",
            "Business"});
            this.comboBox_Class.Location = new System.Drawing.Point(298, 15);
            this.comboBox_Class.Name = "comboBox_Class";
            this.comboBox_Class.Size = new System.Drawing.Size(121, 25);
            this.comboBox_Class.TabIndex = 4;
            // 
            // button_Detail
            // 
            this.button_Detail.Location = new System.Drawing.Point(751, 15);
            this.button_Detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Detail.Name = "button_Detail";
            this.button_Detail.Size = new System.Drawing.Size(87, 26);
            this.button_Detail.TabIndex = 5;
            this.button_Detail.Text = "See Detail";
            this.button_Detail.UseVisualStyleBackColor = true;
            this.button_Detail.Click += new System.EventHandler(this.button_Detail_Click);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 461);
            this.Controls.Add(this.button_Detail);
            this.Controls.Add(this.comboBox_Class);
            this.Controls.Add(this.button_Book);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Flights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Book;
        private App_Data.AirlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource flightInfoBindingSource;
        private App_Data.AirlineDataSetTableAdapters.FlightInfoTableAdapter flightInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavingAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyPlusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox_Class;
        private System.Windows.Forms.Button button_Detail;
    }
}