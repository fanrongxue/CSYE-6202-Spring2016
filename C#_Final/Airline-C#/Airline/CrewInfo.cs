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
    public partial class CrewInfo : Form
    {
        string cno = "";

        // _cno used to distinguish Add or Edit
        public CrewInfo(string _cno)
        {
            InitializeComponent();
            cno = _cno;
        }

        private void CrewInfo_Load(object sender, EventArgs e)
        {
            if (cno != "")
            {
                textBox1.ReadOnly = true;
                this.Text = "  Edit crew " + cno;
                Model.Crew crew = new Model.Crew(cno);
                crew.Fetch();
                textBox1.Text = crew.CrewNo;
                textBox2.Text = crew.FlightNo;
                textBox3.Text = crew.CrewName;
                textBox4.Text = crew.Role;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Model.Crew crew = new Model.Crew(
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text
            );
            if (cno != "")
            {
                if (crew.Update())
                {
                    MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                    Log.Add(Program.user.ID, "Update crew " + cno + ".");
                    this.Close();
                }
            }
            else
            {
                if (crew.Add())
                {
                    MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                    Log.Add(Program.user.ID, "Add a crew.");
                    this.Close();
                }
            }
        }
    }
}
