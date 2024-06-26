﻿namespace BookStoreManagmentSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label14 = new Label();
            AdminLink = new Label();
            LoginBtn = new Button();
            UPasswordTb = new TextBox();
            UNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(AdminLink);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(UPasswordTb);
            panel2.Controls.Add(UNameTb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 399);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(155, 30);
            panel8.Name = "panel8";
            panel8.Size = new Size(372, 50);
            panel8.TabIndex = 10;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(3, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(45, 42);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(55, 9);
            label14.Name = "label14";
            label14.Size = new Size(300, 28);
            label14.TabIndex = 0;
            label14.Text = "Book Shop Managment System";
            // 
            // AdminLink
            // 
            AdminLink.AutoSize = true;
            AdminLink.Cursor = Cursors.Hand;
            AdminLink.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            AdminLink.Location = new Point(257, 333);
            AdminLink.Name = "AdminLink";
            AdminLink.Size = new Size(186, 28);
            AdminLink.TabIndex = 3;
            AdminLink.Text = "Continue as Admin";
            AdminLink.Click += AdminLink_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Location = new Point(298, 249);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(109, 42);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPasswordTb
            // 
            UPasswordTb.Location = new Point(207, 180);
            UPasswordTb.Name = "UPasswordTb";
            UPasswordTb.PasswordChar = '*';
            UPasswordTb.Size = new Size(303, 31);
            UPasswordTb.TabIndex = 1;
            // 
            // UNameTb
            // 
            UNameTb.Location = new Point(207, 116);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(303, 31);
            UNameTb.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 183);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 119);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 3;
            label5.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(710, 408);
            Controls.Add(panel2);
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label AdminLink;
        private Button LoginBtn;
        private TextBox UPasswordTb;
        private TextBox UNameTb;
        private Panel panel8;
        private PictureBox pictureBox9;
        private Label label14;
    }
}