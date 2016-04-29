using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airline
{
    public partial class Flights : Form
    {
        SqlConnection sqlConnection;
        public Flights()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(Properties.Settings.Default.AirlineConnectionString);
        }

        // bind data for datagridview
        private void Flights_Load(object sender, EventArgs e)
        {
            this.flightInfoTableAdapter.Fill(this.airlineDataSet.FlightInfo);
            comboBox_Class.SelectedIndex = 0;
        }

        // search
        private void button_Search_Click(object sender, EventArgs e)
        {
            this.flightInfoBindingSource.Filter = "FlightNo like'%" + textBox_Search.Text + "%' or CarrierName like'%" + textBox_Search.Text + "%' or Start like'%" + textBox_Search.Text + "%' or Destination like'%" + textBox_Search.Text + "%'";
            Log.Add(Program.user.ID, "Flight search.");
        }

        // book a ticket
        private void button_Book_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a flight!", "Information", MessageBoxButtons.OK);
                return;
            }

            string type = comboBox_Class.Text;
            string fno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            Model.Book book = new Model.Book(fno, Program.user.ID, type);
            if (book.Add())
            {
                Log.Add(Program.user.ID, "User book a flight.");
                MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                this.flightInfoTableAdapter.Fill(this.airlineDataSet.FlightInfo);
            }
            else
                MessageBox.Show("Tickets not enough!", "Information", MessageBoxButtons.OK);
        }

        // view detail of a flight
        private void button_Detail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight first!", "Information", MessageBoxButtons.OK);
                return;
            }
            Flight win = new Flight(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            win.ShowDialog();
        }
    }
}
