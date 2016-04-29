namespace Airline
{
    partial class ChangePassword
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
            this.textBox_Repeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Go = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Old = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Repeat
            // 
            this.textBox_Repeat.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Repeat.Location = new System.Drawing.Point(195, 218);
            this.textBox_Repeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Repeat.Name = "textBox_Repeat";
            this.textBox_Repeat.PasswordChar = '*';
            this.textBox_Repeat.Size = new System.Drawing.Size(180, 25);
            this.textBox_Repeat.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(116, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Repeat";
            // 
            // button_Go
            // 
            this.button_Go.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Go.Location = new System.Drawing.Point(168, 287);
            this.button_Go.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(100, 31);
            this.button_Go.TabIndex = 15;
            this.button_Go.Text = "Go";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Password.Location = new System.Drawing.Point(195, 170);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(180, 25);
            this.textBox_Password.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Password";
            // 
            // textBox_Old
            // 
            this.textBox_Old.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Old.Location = new System.Drawing.Point(195, 119);
            this.textBox_Old.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Old.Name = "textBox_Old";
            this.textBox_Old.PasswordChar = '*';
            this.textBox_Old.Size = new System.Drawing.Size(180, 25);
            this.textBox_Old.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑 Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(114, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Change Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Repeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Old);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangePassword";
            this.Text = "  Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Repeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Go;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Old;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

    }
}