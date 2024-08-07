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

namespace Attendance_System_Project.PAL.User_Control
{   

    public partial class UserControlDashboard : UserControl
    {
        private string sql = @"Data Source=DESKTOP-1D47PII\SQLEXPRESS;
                                Initial Catalog=MyfirstDatabaseDB01;
                                Integrated Security=True;"; 
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void Count()
        {
            labelTotalClasses.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Class_Table;", sql).ToString();
            labelTotalStudent.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM Student_Table;", sql).ToString();
            labelTotalRole.Text = Attendance.Attendance.Count("SELECT COUNT(*) FROM User_Table;", sql).ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
