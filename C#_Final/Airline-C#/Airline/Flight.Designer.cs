namespace Airline
{
    partial class Flight
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_f5 = new System.Windows.Forms.Label();
            this.flightCarrierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet = new Airline.App_Data.AirlineDataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.label_f4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_f8 = new System.Windows.Forms.Label();
            this.label_f7 = new System.Windows.Forms.Label();
            this.label_f6 = new System.Windows.Forms.Label();
            this.label_f3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_f2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_f1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_c3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label_c2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label_c1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crewNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.crewTableAdapter = new Airline.App_Data.AirlineDataSetTableAdapters.CrewTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.flightCarrierTableAdapter = new Airline.App_Data.AirlineDataSetTableAdapters.FlightCarrierTableAdapter();
            this.bookDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDetailTableAdapter = new Airline.App_Data.AirlineDataSetTableAdapters.BookDetailTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightCarrierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_f5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label_f4);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label_f8);
            this.groupBox1.Controls.Add(this.label_f7);
            this.groupBox1.Controls.Add(this.label_f6);
            this.groupBox1.Controls.Add(this.label_f3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_f2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_f1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(315, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight Information";
            // 
            // label_f5
            // 
            this.label_f5.AutoSize = true;
            this.label_f5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "ArrivalAt", true));
            this.label_f5.Location = new System.Drawing.Point(170, 165);
            this.label_f5.Name = "label_f5";
            this.label_f5.Size = new System.Drawing.Size(69, 20);
            this.label_f5.TabIndex = 15;
            this.label_f5.Text = "Flight No.";
            // 
            // flightCarrierBindingSource
            // 
            this.flightCarrierBindingSource.DataMember = "FlightCarrier";
            this.flightCarrierBindingSource.DataSource = this.airlineDataSet;
            // 
            // airlineDataSet
            // 
            this.airlineDataSet.DataSetName = "AirlineDataSet";
            this.airlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Arrival At";
            // 
            // label_f4
            // 
            this.label_f4.AutoSize = true;
            this.label_f4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "LeavingAt", true));
            this.label_f4.Location = new System.Drawing.Point(170, 133);
            this.label_f4.Name = "label_f4";
            this.label_f4.Size = new System.Drawing.Size(69, 20);
            this.label_f4.TabIndex = 13;
            this.label_f4.Text = "Flight No.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Leaving At";
            // 
            // label_f8
            // 
            this.label_f8.AutoSize = true;
            this.label_f8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "Business", true));
            this.label_f8.Location = new System.Drawing.Point(170, 261);
            this.label_f8.Name = "label_f8";
            this.label_f8.Size = new System.Drawing.Size(69, 20);
            this.label_f8.TabIndex = 11;
            this.label_f8.Text = "Flight No.";
            // 
            // label_f7
            // 
            this.label_f7.AutoSize = true;
            this.label_f7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "EconomyPlus", true));
            this.label_f7.Location = new System.Drawing.Point(170, 229);
            this.label_f7.Name = "label_f7";
            this.label_f7.Size = new System.Drawing.Size(69, 20);
            this.label_f7.TabIndex = 10;
            this.label_f7.Text = "Flight No.";
            // 
            // label_f6
            // 
            this.label_f6.AutoSize = true;
            this.label_f6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "Economy", true));
            this.label_f6.Location = new System.Drawing.Point(170, 197);
            this.label_f6.Name = "label_f6";
            this.label_f6.Size = new System.Drawing.Size(69, 20);
            this.label_f6.TabIndex = 9;
            this.label_f6.Text = "Flight No.";
            // 
            // label_f3
            // 
            this.label_f3.AutoSize = true;
            this.label_f3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "Destination", true));
            this.label_f3.Location = new System.Drawing.Point(170, 101);
            this.label_f3.Name = "label_f3";
            this.label_f3.Size = new System.Drawing.Size(69, 20);
            this.label_f3.TabIndex = 8;
            this.label_f3.Text = "Flight No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Business";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "EconomyPlus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Economy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination";
            // 
            // label_f2
            // 
            this.label_f2.AutoSize = true;
            this.label_f2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "Start", true));
            this.label_f2.Location = new System.Drawing.Point(170, 69);
            this.label_f2.Name = "label_f2";
            this.label_f2.Size = new System.Drawing.Size(69, 20);
            this.label_f2.TabIndex = 3;
            this.label_f2.Text = "Flight No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start";
            // 
            // label_f1
            // 
            this.label_f1.AutoSize = true;
            this.label_f1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "FlightNo", true));
            this.label_f1.Location = new System.Drawing.Point(170, 37);
            this.label_f1.Name = "label_f1";
            this.label_f1.Size = new System.Drawing.Size(69, 20);
            this.label_f1.TabIndex = 1;
            this.label_f1.Text = "Flight No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_c3);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label_c2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label_c1);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(315, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrier Information";
            // 
            // label_c3
            // 
            this.label_c3.AutoSize = true;
            this.label_c3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "Country", true));
            this.label_c3.Location = new System.Drawing.Point(170, 109);
            this.label_c3.Name = "label_c3";
            this.label_c3.Size = new System.Drawing.Size(69, 20);
            this.label_c3.TabIndex = 14;
            this.label_c3.Text = "Flight No.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(73, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Country";
            // 
            // label_c2
            // 
            this.label_c2.AutoSize = true;
            this.label_c2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "CarrierName", true));
            this.label_c2.Location = new System.Drawing.Point(170, 77);
            this.label_c2.Name = "label_c2";
            this.label_c2.Size = new System.Drawing.Size(69, 20);
            this.label_c2.TabIndex = 12;
            this.label_c2.Text = "Flight No.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 20);
            this.label20.TabIndex = 11;
            this.label20.Text = "Carrier Name";
            // 
            // label_c1
            // 
            this.label_c1.AutoSize = true;
            this.label_c1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightCarrierBindingSource, "CarrierNo", true));
            this.label_c1.Location = new System.Drawing.Point(170, 45);
            this.label_c1.Name = "label_c1";
            this.label_c1.Size = new System.Drawing.Size(69, 20);
            this.label_c1.TabIndex = 10;
            this.label_c1.Text = "Flight No.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(54, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Carrier No.";
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
            this.crewNoDataGridViewTextBoxColumn,
            this.flightNoDataGridViewTextBoxColumn,
            this.crewNameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.crewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(521, 161);
            this.dataGridView1.TabIndex = 2;
            // 
            // crewNoDataGridViewTextBoxColumn
            // 
            this.crewNoDataGridViewTextBoxColumn.DataPropertyName = "CrewNo";
            this.crewNoDataGridViewTextBoxColumn.HeaderText = "CrewNo";
            this.crewNoDataGridViewTextBoxColumn.Name = "crewNoDataGridViewTextBoxColumn";
            this.crewNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightNoDataGridViewTextBoxColumn
            // 
            this.flightNoDataGridViewTextBoxColumn.DataPropertyName = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.HeaderText = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.Name = "flightNoDataGridViewTextBoxColumn";
            this.flightNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crewNameDataGridViewTextBoxColumn
            // 
            this.crewNameDataGridViewTextBoxColumn.DataPropertyName = "CrewName";
            this.crewNameDataGridViewTextBoxColumn.HeaderText = "CrewName";
            this.crewNameDataGridViewTextBoxColumn.Name = "crewNameDataGridViewTextBoxColumn";
            this.crewNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crewBindingSource
            // 
            this.crewBindingSource.DataMember = "Crew";
            this.crewBindingSource.DataSource = this.airlineDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(333, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crew Information";
            // 
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(333, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 284);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All Bookings";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.flightNoDataGridViewTextBoxColumn1,
            this.ticketTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.bookTimeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bookDetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(518, 260);
            this.dataGridView2.TabIndex = 0;
            // 
            // flightCarrierTableAdapter
            // 
            this.flightCarrierTableAdapter.ClearBeforeFill = true;
            // 
            // bookDetailBindingSource
            // 
            this.bookDetailBindingSource.DataMember = "BookDetail";
            this.bookDetailBindingSource.DataSource = this.airlineDataSet;
            // 
            // bookDetailTableAdapter
            // 
            this.bookDetailTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 60F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightNoDataGridViewTextBoxColumn1
            // 
            this.flightNoDataGridViewTextBoxColumn1.DataPropertyName = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn1.FillWeight = 95.63452F;
            this.flightNoDataGridViewTextBoxColumn1.HeaderText = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn1.Name = "flightNoDataGridViewTextBoxColumn1";
            this.flightNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ticketTypeDataGridViewTextBoxColumn
            // 
            this.ticketTypeDataGridViewTextBoxColumn.DataPropertyName = "TicketType";
            this.ticketTypeDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.ticketTypeDataGridViewTextBoxColumn.HeaderText = "TicketType";
            this.ticketTypeDataGridViewTextBoxColumn.Name = "ticketTypeDataGridViewTextBoxColumn";
            this.ticketTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 70F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTimeDataGridViewTextBoxColumn
            // 
            this.bookTimeDataGridViewTextBoxColumn.DataPropertyName = "BookTime";
            this.bookTimeDataGridViewTextBoxColumn.FillWeight = 95.63452F;
            this.bookTimeDataGridViewTextBoxColumn.HeaderText = "BookTime";
            this.bookTimeDataGridViewTextBoxColumn.Name = "bookTimeDataGridViewTextBoxColumn";
            this.bookTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 515);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Flight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Flight";
            this.Load += new System.EventHandler(this.Flight_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightCarrierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_f2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_f1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_f5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_f4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_f8;
        private System.Windows.Forms.Label label_f7;
        private System.Windows.Forms.Label label_f6;
        private System.Windows.Forms.Label label_f3;
        private System.Windows.Forms.Label label_c3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_c2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label_c1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private App_Data.AirlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource crewBindingSource;
        private App_Data.AirlineDataSetTableAdapters.CrewTableAdapter crewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource flightCarrierBindingSource;
        private App_Data.AirlineDataSetTableAdapters.FlightCarrierTableAdapter flightCarrierTableAdapter;
        private System.Windows.Forms.BindingSource bookDetailBindingSource;
        private App_Data.AirlineDataSetTableAdapters.BookDetailTableAdapter bookDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTimeDataGridViewTextBoxColumn;
    }
}