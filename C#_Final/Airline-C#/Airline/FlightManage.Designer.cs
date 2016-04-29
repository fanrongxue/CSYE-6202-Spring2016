namespace Airline
{
    partial class FlightManage
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
            this.flightNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavingAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyPlusPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyPlusCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet = new Airline.App_Data.AirlineDataSet();
            this.flightTableAdapter = new Airline.App_Data.AirlineDataSetTableAdapters.FlightTableAdapter();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightNoDataGridViewTextBoxColumn,
            this.carrierNoDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.leavingAtDataGridViewTextBoxColumn,
            this.arrivalAtDataGridViewTextBoxColumn,
            this.economyPriceDataGridViewTextBoxColumn,
            this.economyCountDataGridViewTextBoxColumn,
            this.economyPlusPriceDataGridViewTextBoxColumn,
            this.economyPlusCountDataGridViewTextBoxColumn,
            this.businessPriceDataGridViewTextBoxColumn,
            this.businessCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // flightNoDataGridViewTextBoxColumn
            // 
            this.flightNoDataGridViewTextBoxColumn.DataPropertyName = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.HeaderText = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.Name = "flightNoDataGridViewTextBoxColumn";
            this.flightNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carrierNoDataGridViewTextBoxColumn
            // 
            this.carrierNoDataGridViewTextBoxColumn.DataPropertyName = "CarrierNo";
            this.carrierNoDataGridViewTextBoxColumn.HeaderText = "CarrierNo";
            this.carrierNoDataGridViewTextBoxColumn.Name = "carrierNoDataGridViewTextBoxColumn";
            this.carrierNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // economyPriceDataGridViewTextBoxColumn
            // 
            this.economyPriceDataGridViewTextBoxColumn.DataPropertyName = "EconomyPrice";
            this.economyPriceDataGridViewTextBoxColumn.HeaderText = "EconomyPrice";
            this.economyPriceDataGridViewTextBoxColumn.Name = "economyPriceDataGridViewTextBoxColumn";
            this.economyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economyCountDataGridViewTextBoxColumn
            // 
            this.economyCountDataGridViewTextBoxColumn.DataPropertyName = "EconomyCount";
            this.economyCountDataGridViewTextBoxColumn.HeaderText = "EconomyCount";
            this.economyCountDataGridViewTextBoxColumn.Name = "economyCountDataGridViewTextBoxColumn";
            this.economyCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economyPlusPriceDataGridViewTextBoxColumn
            // 
            this.economyPlusPriceDataGridViewTextBoxColumn.DataPropertyName = "EconomyPlusPrice";
            this.economyPlusPriceDataGridViewTextBoxColumn.HeaderText = "EconomyPlusPrice";
            this.economyPlusPriceDataGridViewTextBoxColumn.Name = "economyPlusPriceDataGridViewTextBoxColumn";
            this.economyPlusPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // economyPlusCountDataGridViewTextBoxColumn
            // 
            this.economyPlusCountDataGridViewTextBoxColumn.DataPropertyName = "EconomyPlusCount";
            this.economyPlusCountDataGridViewTextBoxColumn.HeaderText = "EconomyPlusCount";
            this.economyPlusCountDataGridViewTextBoxColumn.Name = "economyPlusCountDataGridViewTextBoxColumn";
            this.economyPlusCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessPriceDataGridViewTextBoxColumn
            // 
            this.businessPriceDataGridViewTextBoxColumn.DataPropertyName = "BusinessPrice";
            this.businessPriceDataGridViewTextBoxColumn.HeaderText = "BusinessPrice";
            this.businessPriceDataGridViewTextBoxColumn.Name = "businessPriceDataGridViewTextBoxColumn";
            this.businessPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // businessCountDataGridViewTextBoxColumn
            // 
            this.businessCountDataGridViewTextBoxColumn.DataPropertyName = "BusinessCount";
            this.businessCountDataGridViewTextBoxColumn.HeaderText = "BusinessCount";
            this.businessCountDataGridViewTextBoxColumn.Name = "businessCountDataGridViewTextBoxColumn";
            this.businessCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.airlineDataSet;
            // 
            // airlineDataSet
            // 
            this.airlineDataSet.DataSetName = "AirlineDataSet";
            this.airlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(148, 8);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(87, 26);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(12, 10);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(116, 23);
            this.textBox_Search.TabIndex = 3;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(453, 8);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(87, 26);
            this.button_Edit.TabIndex = 5;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(351, 8);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(87, 26);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(555, 8);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(87, 26);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // FlightManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 538);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FlightManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Flight Manage";
            this.Load += new System.EventHandler(this.FlightManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private App_Data.AirlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private App_Data.AirlineDataSetTableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavingAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyPlusPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyPlusCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
    }
}