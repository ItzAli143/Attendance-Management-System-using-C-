using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System_Project.PAL.User_Control
{
	public partial class UserControlReport : UserControl
	{
		private string sql = @"Data Source=DESKTOP-1D47PII\SQLEXPRESS;
                                Initial Catalog=MyfirstDatabaseDB01;
                                Integrated Security=True;";

		public UserControlReport()
		{
			InitializeComponent();
		}
		
		public void FirstTab()
		{
			tabControlReport.SelectedTab = tabPageClassReport;
		}

		private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBoxPrint, "Print");
		}

		private void pictureBoxPrint1_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBoxPrint1, "Print");
		}

		private void comboBoxClass_Click(object sender, EventArgs e)
		{
			comboBoxClass.Items.Clear();
			Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass, sql);
		}

		private void comboBoxClass1_Click(object sender, EventArgs e)
		{
			comboBoxClass1.Items.Clear();
			Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass1, sql);
		}

		private void comboBoxRegNo_Click(object sender, EventArgs e)
		{
			if(comboBoxClass1.SelectedIndex != 1)
			{
				comboBoxRegNo.Items.Clear();
				Attendance.Attendance.FillComboBox("SELECT DISTINCT(Student_Reg) FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name = '"+ comboBoxClass1.SelectedItem.ToString() +"';", comboBoxRegNo, sql);
			}
		}

		private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBoxClass.SelectedIndex != -1)				
			Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate.Text + "%' AND Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "';", dataGridViewClassReport, sql);

		}

		private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
				Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Class_Name = '" + comboBoxClass1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() +"';", dataGridViewStudentReport, sql);

		}

		private void comboBoxClass1_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
				Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Class_Name = '" + comboBoxClass1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "';", dataGridViewStudentReport, sql);
		}

		private void pictureBoxPrint_Click(object sender, EventArgs e)
		{

		}
	}
}
