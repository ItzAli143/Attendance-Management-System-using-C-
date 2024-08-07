
namespace Attendance_System_Project.PAL.Forms
{
    partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.buttonReport = new System.Windows.Forms.Button();
			this.buttonAddStudent = new System.Windows.Forms.Button();
			this.buttonAddClass = new System.Windows.Forms.Button();
			this.buttonAttendance = new System.Windows.Forms.Button();
			this.buttonDashboard = new System.Windows.Forms.Button();
			this.panelSlide = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelBack = new System.Windows.Forms.Panel();
			this.panelExpand = new System.Windows.Forms.Panel();
			this.buttonlogout = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonMinimize = new System.Windows.Forms.Button();
			this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.labelTime = new System.Windows.Forms.Label();
			this.panelTop = new System.Windows.Forms.Panel();
			this.labelRole = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.labelUsername = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
			this.userControlReport1 = new Attendance_System_Project.PAL.User_Control.UserControlReport();
			this.userControlRegister1 = new Attendance_System_Project.PAL.User_Control.UserControlRegister();
			this.userControlAddStudent1 = new Attendance_System_Project.PAL.User_Control.UserControlAddStudent();
			this.userControlAddClass1 = new Attendance_System_Project.PAL.User_Control.UserControlAddClass();
			this.userControlDashboard2 = new Attendance_System_Project.PAL.User_Control.UserControlDashboard();
			this.userControlAttendance1 = new Attendance_System_Project.PAL.User_Control.UserControlAttendance();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelBack.SuspendLayout();
			this.panelExpand.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(278, 720);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.buttonRegister);
			this.panel4.Controls.Add(this.buttonReport);
			this.panel4.Controls.Add(this.buttonAddStudent);
			this.panel4.Controls.Add(this.buttonAddClass);
			this.panel4.Controls.Add(this.buttonAttendance);
			this.panel4.Controls.Add(this.buttonDashboard);
			this.panel4.Controls.Add(this.panelSlide);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 180);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(282, 540);
			this.panel4.TabIndex = 0;
			// 
			// buttonRegister
			// 
			this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonRegister.FlatAppearance.BorderSize = 0;
			this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegister.ForeColor = System.Drawing.Color.White;
			this.buttonRegister.Location = new System.Drawing.Point(0, 280);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(282, 56);
			this.buttonRegister.TabIndex = 0;
			this.buttonRegister.Text = "Register";
			this.buttonRegister.UseVisualStyleBackColor = true;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// buttonReport
			// 
			this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonReport.FlatAppearance.BorderSize = 0;
			this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReport.ForeColor = System.Drawing.Color.White;
			this.buttonReport.Location = new System.Drawing.Point(0, 224);
			this.buttonReport.Name = "buttonReport";
			this.buttonReport.Size = new System.Drawing.Size(282, 56);
			this.buttonReport.TabIndex = 0;
			this.buttonReport.Text = "Report";
			this.buttonReport.UseVisualStyleBackColor = true;
			this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
			// 
			// buttonAddStudent
			// 
			this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAddStudent.FlatAppearance.BorderSize = 0;
			this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
			this.buttonAddStudent.Location = new System.Drawing.Point(0, 168);
			this.buttonAddStudent.Name = "buttonAddStudent";
			this.buttonAddStudent.Size = new System.Drawing.Size(282, 56);
			this.buttonAddStudent.TabIndex = 0;
			this.buttonAddStudent.Text = "Add Student";
			this.buttonAddStudent.UseVisualStyleBackColor = true;
			this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
			// 
			// buttonAddClass
			// 
			this.buttonAddClass.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAddClass.FlatAppearance.BorderSize = 0;
			this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddClass.ForeColor = System.Drawing.Color.White;
			this.buttonAddClass.Location = new System.Drawing.Point(0, 112);
			this.buttonAddClass.Name = "buttonAddClass";
			this.buttonAddClass.Size = new System.Drawing.Size(282, 56);
			this.buttonAddClass.TabIndex = 0;
			this.buttonAddClass.Text = "Add Class";
			this.buttonAddClass.UseVisualStyleBackColor = true;
			this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
			// 
			// buttonAttendance
			// 
			this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAttendance.FlatAppearance.BorderSize = 0;
			this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAttendance.ForeColor = System.Drawing.Color.White;
			this.buttonAttendance.Location = new System.Drawing.Point(0, 56);
			this.buttonAttendance.Name = "buttonAttendance";
			this.buttonAttendance.Size = new System.Drawing.Size(282, 56);
			this.buttonAttendance.TabIndex = 0;
			this.buttonAttendance.Text = "Attendance";
			this.buttonAttendance.UseVisualStyleBackColor = true;
			this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
			// 
			// buttonDashboard
			// 
			this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonDashboard.FlatAppearance.BorderSize = 0;
			this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDashboard.ForeColor = System.Drawing.Color.White;
			this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
			this.buttonDashboard.Name = "buttonDashboard";
			this.buttonDashboard.Size = new System.Drawing.Size(282, 56);
			this.buttonDashboard.TabIndex = 0;
			this.buttonDashboard.Text = "Dashboard";
			this.buttonDashboard.UseVisualStyleBackColor = true;
			this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
			// 
			// panelSlide
			// 
			this.panelSlide.BackColor = System.Drawing.Color.White;
			this.panelSlide.Location = new System.Drawing.Point(0, 0);
			this.panelSlide.Name = "panelSlide";
			this.panelSlide.Size = new System.Drawing.Size(8, 47);
			this.panelSlide.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(278, 180);
			this.panel2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(268, 31);
			this.label2.TabIndex = 0;
			this.label2.Text = "System";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Attendance Management";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Attendance_System_Project.Properties.Resources.icon51;
			this.pictureBox1.Location = new System.Drawing.Point(81, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(93, 87);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panelBack
			// 
			this.panelBack.Controls.Add(this.panelExpand);
			this.panelBack.Controls.Add(this.pictureBoxExpand);
			this.panelBack.Controls.Add(this.pictureBox2);
			this.panelBack.Controls.Add(this.labelTime);
			this.panelBack.Controls.Add(this.panelTop);
			this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBack.Location = new System.Drawing.Point(278, 0);
			this.panelBack.Name = "panelBack";
			this.panelBack.Size = new System.Drawing.Size(922, 165);
			this.panelBack.TabIndex = 0;
			// 
			// panelExpand
			// 
			this.panelExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
			this.panelExpand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelExpand.Controls.Add(this.buttonlogout);
			this.panelExpand.Controls.Add(this.panel3);
			this.panelExpand.Location = new System.Drawing.Point(722, 58);
			this.panelExpand.Name = "panelExpand";
			this.panelExpand.Size = new System.Drawing.Size(200, 107);
			this.panelExpand.TabIndex = 2;
			// 
			// buttonlogout
			// 
			this.buttonlogout.BackColor = System.Drawing.Color.White;
			this.buttonlogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonlogout.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonlogout.FlatAppearance.BorderSize = 0;
			this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
			this.buttonlogout.Location = new System.Drawing.Point(0, 53);
			this.buttonlogout.Name = "buttonlogout";
			this.buttonlogout.Size = new System.Drawing.Size(198, 49);
			this.buttonlogout.TabIndex = 0;
			this.buttonlogout.Text = "Log Out";
			this.buttonlogout.UseVisualStyleBackColor = false;
			this.buttonlogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.buttonMinimize);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(198, 53);
			this.panel3.TabIndex = 0;
			// 
			// buttonMinimize
			// 
			this.buttonMinimize.BackColor = System.Drawing.Color.White;
			this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonMinimize.FlatAppearance.BorderSize = 0;
			this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMinimize.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
			this.buttonMinimize.Location = new System.Drawing.Point(0, 0);
			this.buttonMinimize.Name = "buttonMinimize";
			this.buttonMinimize.Size = new System.Drawing.Size(198, 50);
			this.buttonMinimize.TabIndex = 0;
			this.buttonMinimize.Text = "Minimize";
			this.buttonMinimize.UseVisualStyleBackColor = false;
			this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
			// 
			// pictureBoxExpand
			// 
			this.pictureBoxExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxExpand.Image = global::Attendance_System_Project.Properties.Resources.down_arrow1;
			this.pictureBoxExpand.Location = new System.Drawing.Point(803, 34);
			this.pictureBoxExpand.Name = "pictureBoxExpand";
			this.pictureBoxExpand.Size = new System.Drawing.Size(27, 24);
			this.pictureBoxExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxExpand.TabIndex = 2;
			this.pictureBoxExpand.TabStop = false;
			this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBoxExpand_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::Attendance_System_Project.Properties.Resources.pict2;
			this.pictureBox2.Location = new System.Drawing.Point(737, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(60, 58);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// labelTime
			// 
			this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
			this.labelTime.Location = new System.Drawing.Point(24, 23);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(509, 39);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "{?}";
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
			this.panelTop.Controls.Add(this.labelRole);
			this.panelTop.Controls.Add(this.label7);
			this.panelTop.Controls.Add(this.labelUsername);
			this.panelTop.Controls.Add(this.label4);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelTop.Location = new System.Drawing.Point(0, 65);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(922, 100);
			this.panelTop.TabIndex = 0;
			// 
			// labelRole
			// 
			this.labelRole.ForeColor = System.Drawing.Color.White;
			this.labelRole.Location = new System.Drawing.Point(178, 60);
			this.labelRole.Name = "labelRole";
			this.labelRole.Size = new System.Drawing.Size(113, 25);
			this.labelRole.TabIndex = 0;
			this.labelRole.Text = "{?}";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(59, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Role:";
			// 
			// labelUsername
			// 
			this.labelUsername.ForeColor = System.Drawing.Color.White;
			this.labelUsername.Location = new System.Drawing.Point(178, 19);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(113, 25);
			this.labelUsername.TabIndex = 0;
			this.labelUsername.Text = "{?}";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(59, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Welcome:";
			// 
			// timerDateAndTime
			// 
			this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
			// 
			// userControlReport1
			// 
			this.userControlReport1.BackColor = System.Drawing.Color.White;
			this.userControlReport1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlReport1.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.userControlReport1.Location = new System.Drawing.Point(278, 165);
			this.userControlReport1.Margin = new System.Windows.Forms.Padding(4);
			this.userControlReport1.Name = "userControlReport1";
			this.userControlReport1.Size = new System.Drawing.Size(922, 555);
			this.userControlReport1.TabIndex = 0;
			this.userControlReport1.Visible = false;
			// 
			// userControlRegister1
			// 
			this.userControlRegister1.BackColor = System.Drawing.Color.White;
			this.userControlRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlRegister1.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.userControlRegister1.Location = new System.Drawing.Point(278, 165);
			this.userControlRegister1.Margin = new System.Windows.Forms.Padding(4);
			this.userControlRegister1.Name = "userControlRegister1";
			this.userControlRegister1.Size = new System.Drawing.Size(922, 555);
			this.userControlRegister1.TabIndex = 0;
			this.userControlRegister1.Visible = false;
			// 
			// userControlAddStudent1
			// 
			this.userControlAddStudent1.BackColor = System.Drawing.Color.White;
			this.userControlAddStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlAddStudent1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.userControlAddStudent1.Location = new System.Drawing.Point(278, 165);
			this.userControlAddStudent1.Margin = new System.Windows.Forms.Padding(4);
			this.userControlAddStudent1.Name = "userControlAddStudent1";
			this.userControlAddStudent1.Size = new System.Drawing.Size(922, 555);
			this.userControlAddStudent1.TabIndex = 0;
			this.userControlAddStudent1.Visible = false;
			// 
			// userControlAddClass1
			// 
			this.userControlAddClass1.BackColor = System.Drawing.Color.White;
			this.userControlAddClass1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlAddClass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.userControlAddClass1.Location = new System.Drawing.Point(278, 165);
			this.userControlAddClass1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.userControlAddClass1.Name = "userControlAddClass1";
			this.userControlAddClass1.Size = new System.Drawing.Size(922, 555);
			this.userControlAddClass1.TabIndex = 0;
			this.userControlAddClass1.Visible = false;
			// 
			// userControlDashboard2
			// 
			this.userControlDashboard2.BackColor = System.Drawing.Color.White;
			this.userControlDashboard2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlDashboard2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.userControlDashboard2.Location = new System.Drawing.Point(278, 165);
			this.userControlDashboard2.Margin = new System.Windows.Forms.Padding(4);
			this.userControlDashboard2.Name = "userControlDashboard2";
			this.userControlDashboard2.Size = new System.Drawing.Size(922, 555);
			this.userControlDashboard2.TabIndex = 0;
			this.userControlDashboard2.Visible = false;
			// 
			// userControlAttendance1
			// 
			this.userControlAttendance1.BackColor = System.Drawing.Color.White;
			this.userControlAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlAttendance1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.userControlAttendance1.Location = new System.Drawing.Point(278, 165);
			this.userControlAttendance1.Margin = new System.Windows.Forms.Padding(4);
			this.userControlAttendance1.Name = "userControlAttendance1";
			this.userControlAttendance1.Size = new System.Drawing.Size(922, 555);
			this.userControlAttendance1.TabIndex = 0;
			this.userControlAttendance1.Visible = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1200, 720);
			this.Controls.Add(this.userControlAttendance1);
			this.Controls.Add(this.userControlReport1);
			this.Controls.Add(this.userControlRegister1);
			this.Controls.Add(this.userControlAddStudent1);
			this.Controls.Add(this.userControlAddClass1);
			this.Controls.Add(this.userControlDashboard2);
			this.Controls.Add(this.panelBack);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attendance Management System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelBack.ResumeLayout(false);
			this.panelExpand.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelTop.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.Panel panelExpand;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Timer timerDateAndTime;
        private User_Control.UserControlDashboard userControlDashboard1;
		private User_Control.UserControlDashboard userControlDashboard2;
		private User_Control.UserControlAddClass userControlAddClass1;
		private User_Control.UserControlAddStudent userControlAddStudent1;
		private User_Control.UserControlRegister userControlRegister1;
		private User_Control.UserControlReport userControlReport1;
		private User_Control.UserControlAttendance userControlAttendance1;
	}
}