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
    public partial class UserMain : Form
    {
        bool isLogout = false;
        public UserMain()
        {
            InitializeComponent();
        }

        private void UserMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if logout then not exit application
            if (!isLogout)
                Application.Exit();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            label_User.Text = Program.user.ID;
        }

        // logout
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isLogout = true;
            this.Close();
            Program.loginWin.Show();
        }

        // change password
        private void linkLabel_Change_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword win = new ChangePassword();
            win.ShowDialog();
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flights win = new Flights();
            win.ShowDialog();
        }

        private void myBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyBookings win = new MyBookings();
            win.ShowDialog();
        }
    }
}
