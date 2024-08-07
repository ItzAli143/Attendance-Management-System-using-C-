using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Attendance_System_Project.PAL.Forms
{
    public partial class FormMain : Form
    {
        private string sql = @"Data Source=DESKTOP-1D47PII\SQLEXPRESS;
                                Initial Catalog=MyfirstDatabaseDB01;
                                Integrated Security=True;"; 
        public string Username, Role;

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
                panelExpand.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if(Role == "User")
            {
                buttonDashboard.Hide();
                buttonAddClass.Hide();
                buttonAddStudent.Hide();
                buttonRegister.Hide();
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlAttendance1.Visible = false;
            userControlReport1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlRegister1.Visible = false;
            userControlDashboard2.Count();
            userControlDashboard2.Visible = true;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlReport1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlDashboard2.Visible = false;
            userControlAttendance1.Visible = true;
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControlAddClass1.ClearTextBox();
            userControlAddClass1.Visible = true;
            userControlAttendance1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlDashboard2.Visible = false;
            userControlReport1.Visible = false;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControlAttendance1.Visible = false;
            userControlReport1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlDashboard2.Visible = false;
            userControlRegister1.HideErrorPic();
            userControlAddStudent1.ClearTextBox();
            userControlAddStudent1.Visible = true;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlAttendance1.Visible = false;
            userControlRegister1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlDashboard2.Visible = false;
            userControlReport1.FirstTab();
            userControlReport1.Visible = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlAttendance1.Visible = false;
            userControlReport1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlDashboard2.Visible = false;
            userControlRegister1.CleartextBox();
            userControlRegister1.Visible = true;
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
                panelExpand.Visible = false;
            else
                panelExpand.Visible = true;
        }

        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 180);
        }
    }
}
