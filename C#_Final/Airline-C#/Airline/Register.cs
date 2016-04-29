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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            doRegister();
        }

        private void doRegister()
        {
            string ID = textBox_Account.Text.Trim();
            string Password = textBox_Password.Text.Trim();
            string Repeat = textBox_Repeat.Text.Trim();

            if (ID.Equals(String.Empty) || Password.Equals(String.Empty))
            {
                MessageBox.Show("Cannot be empty!", "Information", MessageBoxButtons.OK);
                return;
            }

            if (Repeat != Password)
                MessageBox.Show("Password and repeat are not the same!", "Information", MessageBoxButtons.OK);
            else
            {
                NormalUser user = new NormalUser(ID, Password);
                if(user.Register()){
                    // log it
                    Log.Add(ID, "User register.");

                    // go to login
                    Login win = new Login();
                    win.Show();

                    // clear
                    textBox_Account.Text = "";
                    textBox_Password.Text = "";
                    textBox_Repeat.Text = "";
                    this.Hide();
                }
                else
                    MessageBox.Show("This account already exists! Try something else.", "Information", MessageBoxButtons.OK);
            }
        }

        // go to login window
        private void linkLabel_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.loginWin.Show();
            this.Close();
        }

        private void textBox_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                doRegister();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.loginWin.Visible)
                Application.Exit();
        }
    }
}
