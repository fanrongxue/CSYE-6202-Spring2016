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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // button click
        private void button_Login_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        // process login
        private void doLogin()
        {
            string ID = textBox_Account.Text.Trim();
            string Password = textBox_Password.Text.Trim();

            if (ID.Equals(String.Empty) || Password.Equals(String.Empty))
                MessageBox.Show("Cannot be empty!", "Information", MessageBoxButtons.OK);
            else {
                User user = new User(ID, Password);
                if (user.Login()) {
                    // store to global
                    Program.user = user;

                    // log it
                    Log.Add(ID, "User login.");

                    // open user main window
                    if (!user.IsAdmin())
                    {
                        UserMain win = new UserMain();
                        win.Show();
                    }
                    // open admin main window
                    else
                    {
                        AdminMain win = new AdminMain();
                        win.Show();
                    }

                    // clear
                    textBox_Account.Text = "";
                    textBox_Password.Text = "";
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong ID or Password! Please try again.", "Information", MessageBoxButtons.OK);
            }
        }

        private void textBox_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                doLogin();
        }

        // go to register window
        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register win = new Register();
            win.Show();
            this.Hide();
        }
    }
}
