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
    public partial class CarrierManage : Form
    {
        public CarrierManage()
        {
            InitializeComponent();
        }

        private void FlightManage_Load(object sender, EventArgs e)
        {
            this.carrierTableAdapter.Fill(this.airlineDataSet.Carrier);
        }

        //search
        private void button_Search_Click(object sender, EventArgs e)
        {
            this.carrierBindingSource.Filter = "CarrierNo like'%" + textBox_Search.Text + "%' or CarrierName like'%" + textBox_Search.Text + "%' or Country like'%" + textBox_Search.Text + "%'";
            Log.Add(Program.user.ID, "Carrier search.");
        }

        // delete rows
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            // collect ids to delete
            string carrierNos = "(";
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                carrierNos += "'" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'";
                if (i != dataGridView1.SelectedRows.Count - 1)
                    carrierNos += ",";
            }
            carrierNos += ")";

            if (MessageBox.Show("Sure to delete carriers whose no. in " + carrierNos + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            // call the model's delete method
            Model.Carrier carrier = new Model.Carrier();
            if (carrier.Delete(carrierNos))
            {
                Log.Add(Program.user.ID, "Delete carrier " + carrierNos + ".");
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
            CarrierInfo win = new CarrierInfo("");
            win.ShowDialog();
            this.carrierTableAdapter.Fill(this.airlineDataSet.Carrier);
        }

        // open edit form
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            CarrierInfo win = new CarrierInfo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            win.ShowDialog();
            this.carrierTableAdapter.Fill(this.airlineDataSet.Carrier);
        }
    }
}
