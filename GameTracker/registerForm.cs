﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTracker
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            verificationLabel.Hide();
        }

        

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(passwordTxtBox.Text == ConfirmPasswordtxtBox.Text)
            {

           
            if (userNameTxtBox != null && passwordTxtBox != null)
            {
                string uname = userNameTxtBox.Text;
                string passwd = passwordTxtBox.Text;
                int exists = (int)userTableAdapter1.UserExists(uname);
                if (exists == 0)
                {
                    userTableAdapter1.InsertQuery(uname, passwd);
                    verificationLabel.Show();
                    verificationLabel.Text = "user " + uname + " added";
                }
                else {
                    verificationLabel.Show();
                    verificationLabel.Text = "User Already exists";
                }
                }
               
            }
            else
            {
                verificationLabel.Show();
                verificationLabel.Text = "Wrong match";

            }
        }
        private void goLoginBtn_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void registerForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void registerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void registerForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
