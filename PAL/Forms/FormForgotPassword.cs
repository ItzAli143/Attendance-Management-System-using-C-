﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System_Project.PAL.Forms
{
    public partial class FormForgotPassword : Form
    {
        private string sql = @"Data Source=DESKTOP-1D47PII\SQLEXPRESS;
                                Initial Catalog=MyfirstDatabaseDB01;
                                Integrated Security=True;"; 
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == "skyangal@gmail.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }
            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "skyangal@gmail.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Trim() == string.Empty)
            {
                textBoxEmail.Text = "skyangal@gmail.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }

            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "skyangal@gmail.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void pictureBoxError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxError, "Invalid Email!");
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if(IsValidEmail(textBoxEmail.Text.Trim()))
            {
                string userName = Attendance.Attendance.GetUsernamePassword("SELECT User_Name FROM User_Table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                string password = Attendance.Attendance.GetUsernamePassword("SELECT User_Pass FROM User_Table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                MessageBox.Show("Your Username is " + userName + " and Password is " + password + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }
    }
}
