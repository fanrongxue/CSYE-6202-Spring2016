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
    public partial class FlightManage : Form
    {
        public FlightManage()
        {
            InitializeComponent();
        }

        private void FlightManage_Load(object sender, EventArgs e)
        {
            this.flightTableAdapter.Fill(this.airlineDataSet.Flight);
        }

        //search
        private void button_Search_Click(object sender, EventArgs e)
        {
            this.flightBindingSource.Filter = "FlightNo like'%" + textBox_Search.Text + "%' or CarrierNo like'%" + textBox_Search.Text + "%' or Start like'%" + textBox_Search.Text + "%' or Destination like'%" + textBox_Search.Text + "%'";
            Log.Add(Program.user.ID, "Flight search.");
        }

        // delete rows
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            // collect ids to delete
            string flightNos = "(";
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                flightNos += "'" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'";
                if (i != dataGridView1.SelectedRows.Count - 1)
                    flightNos += ",";
            }
            flightNos += ")";

            if (MessageBox.Show("Sure to delete flights whose no. in " + flightNos + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            // call the model's delete method
            Model.Flight flight = new Model.Flight();
            if (flight.Delete(flightNos))
            {
                Log.Add(Program.user.ID, "Delete flight " + flightNos + ".");
                // delete from datagridview
                foreach (DataGridViewRow dataGridView1Row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(dataGridView1Row);
                }
            }
        }

        // open add form
        private void button_Add_Click(object sender, EventArgs e)
        {
            FlightInfo win = new FlightInfo("");
            win.ShowDialog();
            this.flightTableAdapter.Fill(this.airlineDataSet.Flight);
        }

        // open edit form
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            FlightInfo win = new FlightInfo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            win.ShowDialog();
            this.flightTableAdapter.Fill(this.airlineDataSet.Flight);
        }
    }
}
