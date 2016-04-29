namespace Airline
{
    partial class Register
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Repeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel_Login = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(471, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // textBox_Account
            // 
            this.textBox_Account.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Account.Location = new System.Drawing.Point(560, 152);
            this.textBox_Account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(180, 25);
            this.textBox_Account.TabIndex = 1;
            this.textBox_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Account_KeyPress);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Password.Location = new System.Drawing.Point(560, 203);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(180, 25);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Account_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(465, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Login.Location = new System.Drawing.Point(560, 312);
            this.button_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(100, 31);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Go";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(559, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Register";
            // 
            // textBox_Repeat
            // 
            this.textBox_Repeat.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Repeat.Location = new System.Drawing.Point(560, 251);
            this.textBox_Repeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Repeat.Name = "textBox_Repeat";
            this.textBox_Repeat.PasswordChar = '*';
            this.textBox_Repeat.Size = new System.Drawing.Size(180, 25);
            this.textBox_Repeat.TabIndex = 9;
            this.textBox_Repeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Account_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(481, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repeat";
            // 
            // linkLabel_Login
            // 
            this.linkLabel_Login.AutoSize = true;
            this.linkLabel_Login.Location = new System.Drawing.Point(701, 320);
            this.linkLabel_Login.Name = "linkLabel_Login";
            this.linkLabel_Login.Size = new System.Drawing.Size(39, 17);
            this.linkLabel_Login.TabIndex = 10;
            this.linkLabel_Login.TabStop = true;
            this.linkLabel_Login.Text = "Login";
            this.linkLabel_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Login_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 452);
            this.Controls.Add(this.linkLabel_Login);
            this.Controls.Add(this.textBox_Repeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Account);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Repeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel_Login;
    }
}

