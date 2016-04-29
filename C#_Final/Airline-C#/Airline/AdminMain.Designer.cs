namespace Airline
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carriersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel_Change = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightsToolStripMenuItem,
            this.carriersToolStripMenuItem,
            this.crewsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(660, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.flightsToolStripMenuItem.Text = "Flights";
            this.flightsToolStripMenuItem.Click += new System.EventHandler(this.flightsToolStripMenuItem_Click);
            // 
            // carriersToolStripMenuItem
            // 
            this.carriersToolStripMenuItem.Name = "carriersToolStripMenuItem";
            this.carriersToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.carriersToolStripMenuItem.Text = "Carriers";
            this.carriersToolStripMenuItem.Click += new System.EventHandler(this.carriersToolStripMenuItem_Click);
            // 
            // crewsToolStripMenuItem
            // 
            this.crewsToolStripMenuItem.Name = "crewsToolStripMenuItem";
            this.crewsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.crewsToolStripMenuItem.Text = "Crews";
            this.crewsToolStripMenuItem.Click += new System.EventHandler(this.crewsToolStripMenuItem_Click);
            // 
            // linkLabel_Change
            // 
            this.linkLabel_Change.AutoSize = true;
            this.linkLabel_Change.Location = new System.Drawing.Point(489, 265);
            this.linkLabel_Change.Name = "linkLabel_Change";
            this.linkLabel_Change.Size = new System.Drawing.Size(120, 20);
            this.linkLabel_Change.TabIndex = 15;
            this.linkLabel_Change.TabStop = true;
            this.linkLabel_Change.Text = "Change Password";
            this.linkLabel_Change.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Change_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "You can add/edit/delete flight/carrier/crew here";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(555, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(489, 174);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(71, 20);
            this.label_User.TabIndex = 11;
            this.label_User.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 370);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.linkLabel_Change);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMain_FormClosed);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carriersToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel_Change;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem crewsToolStripMenuItem;
    }
}