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
    public partial class CarrierInfo : Form
    {
        string cno = "";

        // _cno used to distinguish Add or Edit
        public CarrierInfo(string _cno)
        {
            InitializeComponent();
            cno = _cno;
        }

        private void CarrierInfo_Load(object sender, EventArgs e)
        {
            if (cno != "")
            {
                textBox1.ReadOnly = true;
                this.Text = "  Edit carrier " + cno;
                Model.Carrier carrier = new Model.Carrier(cno);
                carrier.Fetch();
                textBox1.Text = carrier.CarrierNo;
                textBox2.Text = carrier.CarrierName;
                textBox3.Text = carrier.Country;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Model.Carrier carrier = new Model.Carrier(
                textBox1.Text, textBox2.Text, textBox3.Text
            );
            if (cno != "")
            {
                if (carrier.Update())
                {
                    MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                    Log.Add(Program.user.ID, "Update carrier " + cno + ".");
                    this.Close();
                }
            }
            else
            {
                if (carrier.Add())
                {
                    MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                    Log.Add(Program.user.ID, "Add a carrier.");
                    this.Close();
                }
            }
        }
    }
}
