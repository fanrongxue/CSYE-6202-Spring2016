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
    public partial class FlightInfo : Form
    {
        string fno = "";

        // _fno used to distinguish Add or Edit
        public FlightInfo(string _fno)
        {
            InitializeComponent();
            fno = _fno;
        }

        private void FlightInfo_Load(object sender, EventArgs e)
        {
            if (fno != "")
            {
                textBox1.ReadOnly = true;
                this.Text = "  Edit flight " + fno;
                Model.Flight flight = new Model.Flight(fno);
                flight.Fetch();
                textBox1.Text = flight.FlightNo;
                textBox2.Text = flight.Start;
                textBox3.Text = flight.Destination;
                textBox4.Text = flight.EconomyPrice.ToString();
                textBox5.Text = flight.EconomyCount.ToString();
                textBox6.Text = flight.EconomyPlusPrice.ToString();
                textBox7.Text = flight.EconomyPlusCount.ToString();
                textBox8.Text = flight.BusinessPrice.ToString();
                textBox9.Text = flight.BusinessCount.ToString();
                textBox10.Text = flight.CarrierNo;
                dateTimePicker1.Value = flight.LeavingAt;
                dateTimePicker2.Value = flight.ArrivalAt;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Model.Flight flight = new Model.Flight(
                textBox1.Text, textBox10.Text, textBox2.Text, textBox3.Text,
                dateTimePicker1.Value, dateTimePicker2.Value,
                float.Parse(textBox4.Text), int.Parse(textBox5.Text),
                float.Parse(textBox6.Text), int.Parse(textBox7.Text),
                float.Parse(textBox8.Text), int.Parse(textBox9.Text)
            );
            if (fno != "")
            {
                if (flight.Update())
                {
                    MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                    Log.Add(Program.user.ID, "Update flight " + fno + ".");
                    this.Close();
                }
            }
            else
            {
                if (flight.Add())
                {
                    MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                    Log.Add(Program.user.ID, "Add a flight.");
                    this.Close();
                }
            }
        }
    }
}
