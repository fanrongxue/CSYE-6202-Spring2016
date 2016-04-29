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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            string Old = textBox_Old.Text.Trim();
            string Password = textBox_Password.Text.Trim();
            string Repeat = textBox_Repeat.Text.Trim();

            if (Old.Equals(String.Empty) || Password.Equals(String.Empty) || Repeat.Equals(String.Empty))
                MessageBox.Show("Cannot be empty!", "Information", MessageBoxButtons.OK);
            else if (!Old.Equals(Program.user.Password))
                MessageBox.Show("Password not correct!", "Information", MessageBoxButtons.OK);
            else if (Repeat != Password)
                MessageBox.Show("Password and repeat are not the same!", "Information", MessageBoxButtons.OK);
            else
            {
                if (Program.user.ChangePassword(Password)) {
                    Log.Add(Program.user.ID, "Change password.");
                    MessageBox.Show("Successful!", "Information", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("System error, please try again!", "Information", MessageBoxButtons.OK);
            }
        }
    }
}
