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
    public partial class CrewManage : Form
    {
        public CrewManage()
        {
            InitializeComponent();
        }

        private void FlightManage_Load(object sender, EventArgs e)
        {
            this.crewTableAdapter.Fill(this.airlineDataSet.Crew);
        }

        //search
        private void button_Search_Click(object sender, EventArgs e)
        {
            this.crewBindingSource.Filter = "CrewNo like'%" + textBox_Search.Text + "%' or FlightNo like'%" + textBox_Search.Text + "%' or CrewName like'%" + textBox_Search.Text + "%' or Role like'%" + textBox_Search.Text + "%'";
            Log.Add(Program.user.ID, "Crew search.");
        }

        // delete rows
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            // collect ids to delete
            string crewNos = "(";
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                crewNos += "'" + dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'";
                if (i != dataGridView1.SelectedRows.Count - 1)
                    crewNos += ",";
            }
            crewNos += ")";

            if (MessageBox.Show("Sure to delete crews whose no. in " + crewNos + "?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            // call the model's delete method
            Model.Crew crew = new Model.Crew();
            if (crew.Delete(crewNos))
            {
                Log.Add(Program.user.ID, "Delete crew " + crewNos + ".");
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
            CrewInfo win = new CrewInfo("");
            win.ShowDialog();
            this.crewTableAdapter.Fill(this.airlineDataSet.Crew);
        }

        // open edit form
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            CrewInfo win = new CrewInfo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            win.ShowDialog();
            this.crewTableAdapter.Fill(this.airlineDataSet.Crew);
        }
    }
}
