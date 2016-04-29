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
    public partial class AdminMain : Form
    {
        bool isLogout = false;
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if logout then not exit application
            if (!isLogout)
                Application.Exit();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            label_User.Text = Program.user.ID;
        }

        private void linkLabel_Change_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword win = new ChangePassword();
            win.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isLogout = true;
            this.Close();
            Program.loginWin.Show();
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightManage win = new FlightManage();
            win.ShowDialog();
        }

        private void carriersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarrierManage win = new CarrierManage();
            win.ShowDialog();
        }

        private void crewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrewManage win = new CrewManage();
            win.ShowDialog();
        }
    }
}
