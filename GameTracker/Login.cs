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
    public partial class Login : Form
    {

        public string username;
        public Login()
        {
            InitializeComponent();
            errorLabel.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           

             this.username = userNameTextBox.Text;
            string password = passWordTextBox.Text;
           int Content=(int)userTableAdapter1.checkLogin(username, password);
            LoadResults lr = new LoadResults(this);

            if (Content==1) {
                loginButton.Text = "Login succesful";
               
                lr.Show();
                this.Hide();

                

            }
            else
            {
                errorLabel.Show();
               errorLabel.Text = "Something went wrong";
            }
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registerForm rf = new registerForm();
            rf.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //comment
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
