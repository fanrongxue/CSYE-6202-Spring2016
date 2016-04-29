using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class MyBookings : Form
    {
        public MyBookings()
        {
            InitializeComponent();
        }

        // bind data
        private void Flights_Load(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.airlineDataSet.Book);
        }

        // unbook
        private void button_Unbook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking record!", "Information", MessageBoxButtons.OK);
                return;
            }
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string fno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string type = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            Model.Book book = new Model.Book(id, fno, type);
            if (book.Delete())
            {
                Log.Add(Program.user.ID, "Unbook " + id + ".");
                MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                this.bookTableAdapter.Fill(this.airlineDataSet.Book);
            }
            else
                MessageBox.Show("System error, please try again!", "Information", MessageBoxButtons.OK);
        }

        // search
        private void button_Search_Click(object sender, EventArgs e)
        {
            this.bookBindingSource.Filter = "FlightNo like'%" + textBox_Search.Text + "%' or TicketType like'%" + textBox_Search.Text + "%'";
            Log.Add(Program.user.ID, "Booking search.");
        }
    }
}
