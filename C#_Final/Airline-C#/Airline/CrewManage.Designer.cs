namespace Airline
{
    partial class CrewManage
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
            this.crewNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDataSet = new Airline.App_Data.AirlineDataSet();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.crewTableAdapter = new Airline.App_Data.AirlineDataSetTableAdapters.CrewTableAdapter();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).BeginInit();
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
            this.crewNoDataGridViewTextBoxColumn,
            this.flightNoDataGridViewTextBoxColumn,
            this.crewNameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.crewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(701, 423);
            this.dataGridView1.TabIndex = 0;
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
            // airlineDataSet
            // 
            this.airlineDataSet.DataSetName = "AirlineDataSet";
            this.airlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button_Edit.Location = new System.Drawing.Point(467, 8);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(87, 26);
            this.button_Edit.TabIndex = 5;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(560, 8);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(87, 26);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(374, 8);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(87, 26);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // CrewManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 475);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrewManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Crew Manage";
            this.Load += new System.EventHandler(this.FlightManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private App_Data.AirlineDataSet airlineDataSet;
        private System.Windows.Forms.BindingSource crewBindingSource;
        private App_Data.AirlineDataSetTableAdapters.CrewTableAdapter crewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Add;
    }
}