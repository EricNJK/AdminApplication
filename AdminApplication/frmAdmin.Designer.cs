namespace AdminApplication
{
    partial class frmAdmin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.newtab = new System.Windows.Forms.TabPage();
            this.newProjectGroupBox = new System.Windows.Forms.GroupBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.txtProjectEnd = new System.Windows.Forms.TextBox();
            this.txtProjectStart = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.npLbl4 = new System.Windows.Forms.Label();
            this.npLbl3 = new System.Windows.Forms.Label();
            this.npLbl2 = new System.Windows.Forms.Label();
            this.npLbl1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.npTasksGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.txtTaskEnd = new System.Windows.Forms.TextBox();
            this.txtTaskStart = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.tasksLbl1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.newtab.SuspendLayout();
            this.newProjectGroupBox.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.npTasksGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(117, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(64, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(345, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(117, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(283, 24);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(540, 18);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 418);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblWelcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "In order to start using the tool, you must log in using the fields above";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cambria", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(162, 110);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(370, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Administrator Tool";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Projects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.newtab);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(670, 380);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl2_Selected);
            // 
            // newtab
            // 
            this.newtab.Controls.Add(this.newProjectGroupBox);
            this.newtab.Location = new System.Drawing.Point(4, 22);
            this.newtab.Name = "newtab";
            this.newtab.Padding = new System.Windows.Forms.Padding(3);
            this.newtab.Size = new System.Drawing.Size(662, 354);
            this.newtab.TabIndex = 0;
            this.newtab.Text = "New";
            this.newtab.UseVisualStyleBackColor = true;
            // 
            // newProjectGroupBox
            // 
            this.newProjectGroupBox.Controls.Add(this.btnAddProject);
            this.newProjectGroupBox.Controls.Add(this.cbCustomer);
            this.newProjectGroupBox.Controls.Add(this.txtProjectEnd);
            this.newProjectGroupBox.Controls.Add(this.txtProjectStart);
            this.newProjectGroupBox.Controls.Add(this.txtProjectName);
            this.newProjectGroupBox.Controls.Add(this.npLbl4);
            this.newProjectGroupBox.Controls.Add(this.npLbl3);
            this.newProjectGroupBox.Controls.Add(this.npLbl2);
            this.newProjectGroupBox.Controls.Add(this.npLbl1);
            this.newProjectGroupBox.Location = new System.Drawing.Point(34, 30);
            this.newProjectGroupBox.Name = "newProjectGroupBox";
            this.newProjectGroupBox.Size = new System.Drawing.Size(303, 214);
            this.newProjectGroupBox.TabIndex = 1;
            this.newProjectGroupBox.TabStop = false;
            this.newProjectGroupBox.Text = "Add New Project";
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(135, 159);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 8;
            this.btnAddProject.Text = "Add";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(135, 116);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 7;
            // 
            // txtProjectEnd
            // 
            this.txtProjectEnd.Location = new System.Drawing.Point(136, 90);
            this.txtProjectEnd.Name = "txtProjectEnd";
            this.txtProjectEnd.Size = new System.Drawing.Size(100, 20);
            this.txtProjectEnd.TabIndex = 6;
            // 
            // txtProjectStart
            // 
            this.txtProjectStart.Location = new System.Drawing.Point(136, 64);
            this.txtProjectStart.Name = "txtProjectStart";
            this.txtProjectStart.Size = new System.Drawing.Size(100, 20);
            this.txtProjectStart.TabIndex = 5;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(136, 38);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 20);
            this.txtProjectName.TabIndex = 4;
            // 
            // npLbl4
            // 
            this.npLbl4.AutoSize = true;
            this.npLbl4.Location = new System.Drawing.Point(63, 119);
            this.npLbl4.Name = "npLbl4";
            this.npLbl4.Size = new System.Drawing.Size(54, 13);
            this.npLbl4.TabIndex = 3;
            this.npLbl4.Text = "Customer:";
            // 
            // npLbl3
            // 
            this.npLbl3.AutoSize = true;
            this.npLbl3.Location = new System.Drawing.Point(40, 93);
            this.npLbl3.Name = "npLbl3";
            this.npLbl3.Size = new System.Drawing.Size(77, 13);
            this.npLbl3.TabIndex = 2;
            this.npLbl3.Text = "Expected End:";
            // 
            // npLbl2
            // 
            this.npLbl2.AutoSize = true;
            this.npLbl2.Location = new System.Drawing.Point(37, 67);
            this.npLbl2.Name = "npLbl2";
            this.npLbl2.Size = new System.Drawing.Size(80, 13);
            this.npLbl2.TabIndex = 1;
            this.npLbl2.Text = "Expected Start:";
            // 
            // npLbl1
            // 
            this.npLbl1.AutoSize = true;
            this.npLbl1.Location = new System.Drawing.Point(79, 41);
            this.npLbl1.Name = "npLbl1";
            this.npLbl1.Size = new System.Drawing.Size(38, 13);
            this.npLbl1.TabIndex = 0;
            this.npLbl1.Text = "Name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.npTasksGroupBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(662, 354);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Tasks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // npTasksGroupBox
            // 
            this.npTasksGroupBox.Controls.Add(this.groupBox2);
            this.npTasksGroupBox.Controls.Add(this.groupBox1);
            this.npTasksGroupBox.Controls.Add(this.lblEndDate);
            this.npTasksGroupBox.Controls.Add(this.lblCustomer);
            this.npTasksGroupBox.Controls.Add(this.lblStartDate);
            this.npTasksGroupBox.Controls.Add(this.label4);
            this.npTasksGroupBox.Controls.Add(this.label3);
            this.npTasksGroupBox.Controls.Add(this.label1);
            this.npTasksGroupBox.Controls.Add(this.cbProjects);
            this.npTasksGroupBox.Controls.Add(this.tasksLbl1);
            this.npTasksGroupBox.Location = new System.Drawing.Point(15, 25);
            this.npTasksGroupBox.Name = "npTasksGroupBox";
            this.npTasksGroupBox.Size = new System.Drawing.Size(626, 304);
            this.npTasksGroupBox.TabIndex = 0;
            this.npTasksGroupBox.TabStop = false;
            this.npTasksGroupBox.Text = "Existing Projects";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTasks);
            this.groupBox2.Location = new System.Drawing.Point(336, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 175);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.Location = new System.Drawing.Point(6, 19);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(240, 147);
            this.lbTasks.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTask);
            this.groupBox1.Controls.Add(this.cbTeams);
            this.groupBox1.Controls.Add(this.txtTaskEnd);
            this.groupBox1.Controls.Add(this.txtTaskStart);
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(23, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Task";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(98, 143);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(98, 106);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(121, 21);
            this.cbTeams.TabIndex = 7;
            // 
            // txtTaskEnd
            // 
            this.txtTaskEnd.Location = new System.Drawing.Point(98, 80);
            this.txtTaskEnd.Name = "txtTaskEnd";
            this.txtTaskEnd.Size = new System.Drawing.Size(100, 20);
            this.txtTaskEnd.TabIndex = 6;
            // 
            // txtTaskStart
            // 
            this.txtTaskStart.Location = new System.Drawing.Point(98, 54);
            this.txtTaskStart.Name = "txtTaskStart";
            this.txtTaskStart.Size = new System.Drawing.Size(100, 20);
            this.txtTaskStart.TabIndex = 5;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(98, 28);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(100, 20);
            this.txtTaskName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Team:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Expected End:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Expected Start:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(547, 41);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 13);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "lblEndDate";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(358, 71);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 13);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "lblCustomer";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(358, 41);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(74, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "lblStartDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expected End:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expected Start:";
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(117, 33);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(121, 21);
            this.cbProjects.TabIndex = 1;
            this.cbProjects.SelectedIndexChanged += new System.EventHandler(this.cbProjects_SelectedIndexChanged);
            // 
            // tasksLbl1
            // 
            this.tasksLbl1.AutoSize = true;
            this.tasksLbl1.Location = new System.Drawing.Point(41, 36);
            this.tasksLbl1.Name = "tasksLbl1";
            this.tasksLbl1.Size = new System.Drawing.Size(73, 13);
            this.tasksLbl1.TabIndex = 0;
            this.tasksLbl1.Text = "SelectProject:";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmAdmin";
            this.Text = "Administrator Tool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.newtab.ResumeLayout(false);
            this.newProjectGroupBox.ResumeLayout(false);
            this.newProjectGroupBox.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.npTasksGroupBox.ResumeLayout(false);
            this.npTasksGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage newtab;
        private System.Windows.Forms.GroupBox newProjectGroupBox;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox txtProjectEnd;
        private System.Windows.Forms.TextBox txtProjectStart;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label npLbl4;
        private System.Windows.Forms.Label npLbl3;
        private System.Windows.Forms.Label npLbl2;
        private System.Windows.Forms.Label npLbl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox npTasksGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.TextBox txtTaskEnd;
        private System.Windows.Forms.TextBox txtTaskStart;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.Label tasksLbl1;
    }
}

