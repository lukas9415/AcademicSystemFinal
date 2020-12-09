namespace AcademicSystem
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherButton = new System.Windows.Forms.ToolStripMenuItem();
            this.studentButton = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nameHere = new System.Windows.Forms.Label();
            this.groupHere = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.welcomeText = new System.Windows.Forms.Label();
            this.addNewGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminWelcome = new System.Windows.Forms.Label();
            this.teacherWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.adminButton,
            this.teacherButton,
            this.studentButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // adminButton
            // 
            this.adminButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupToolStripMenuItem,
            this.teacherManagementToolStripMenuItem,
            this.studentManagementToolStripMenuItem,
            this.subjectManagementToolStripMenuItem});
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(89, 20);
            this.adminButton.Text = "Admin Menu";
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewGroupToolStripMenuItem,
            this.removeGroupsToolStripMenuItem});
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addGroupToolStripMenuItem.Text = "Group Management";
            this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.addGroupToolStripMenuItem_Click);
            // 
            // teacherManagementToolStripMenuItem
            // 
            this.teacherManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerTeacherToolStripMenuItem,
            this.removeTeacherToolStripMenuItem});
            this.teacherManagementToolStripMenuItem.Name = "teacherManagementToolStripMenuItem";
            this.teacherManagementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.teacherManagementToolStripMenuItem.Text = "Teacher Management";
            // 
            // registerTeacherToolStripMenuItem
            // 
            this.registerTeacherToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registerTeacherToolStripMenuItem.Name = "registerTeacherToolStripMenuItem";
            this.registerTeacherToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registerTeacherToolStripMenuItem.Text = "Register New Teacher";
            this.registerTeacherToolStripMenuItem.Click += new System.EventHandler(this.registerTeacherToolStripMenuItem_Click);
            // 
            // removeTeacherToolStripMenuItem
            // 
            this.removeTeacherToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeTeacherToolStripMenuItem.Name = "removeTeacherToolStripMenuItem";
            this.removeTeacherToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.removeTeacherToolStripMenuItem.Text = "Remove Teacher";
            this.removeTeacherToolStripMenuItem.Click += new System.EventHandler(this.removeTeacherToolStripMenuItem_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewStudentToolStripMenuItem,
            this.removeStudentToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // registerNewStudentToolStripMenuItem
            // 
            this.registerNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registerNewStudentToolStripMenuItem.Name = "registerNewStudentToolStripMenuItem";
            this.registerNewStudentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registerNewStudentToolStripMenuItem.Text = "Register New Student";
            this.registerNewStudentToolStripMenuItem.Click += new System.EventHandler(this.registerNewStudentToolStripMenuItem_Click);
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.removeStudentToolStripMenuItem.Text = "Remove Student";
            this.removeStudentToolStripMenuItem.Click += new System.EventHandler(this.removeStudentToolStripMenuItem_Click);
            // 
            // subjectManagementToolStripMenuItem
            // 
            this.subjectManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSubjectToolStripMenuItem,
            this.removeSubjectToolStripMenuItem});
            this.subjectManagementToolStripMenuItem.Name = "subjectManagementToolStripMenuItem";
            this.subjectManagementToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.subjectManagementToolStripMenuItem.Text = "Subject Management";
            // 
            // addNewSubjectToolStripMenuItem
            // 
            this.addNewSubjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNewSubjectToolStripMenuItem.Name = "addNewSubjectToolStripMenuItem";
            this.addNewSubjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewSubjectToolStripMenuItem.Text = "Add New Subject";
            this.addNewSubjectToolStripMenuItem.Click += new System.EventHandler(this.addNewSubjectToolStripMenuItem_Click);
            // 
            // removeSubjectToolStripMenuItem
            // 
            this.removeSubjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeSubjectToolStripMenuItem.Name = "removeSubjectToolStripMenuItem";
            this.removeSubjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeSubjectToolStripMenuItem.Text = "Remove Subject";
            this.removeSubjectToolStripMenuItem.Click += new System.EventHandler(this.removeSubjectToolStripMenuItem_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGradesToolStripMenuItem});
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(94, 20);
            this.teacherButton.Text = "Teacher Menu";
            // 
            // studentButton
            // 
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(94, 20);
            this.studentButton.Text = "Student Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged In as:";
            // 
            // nameHere
            // 
            this.nameHere.AutoSize = true;
            this.nameHere.Location = new System.Drawing.Point(148, 28);
            this.nameHere.Name = "nameHere";
            this.nameHere.Size = new System.Drawing.Size(56, 13);
            this.nameHere.TabIndex = 1;
            this.nameHere.Text = "nameHere";
            // 
            // groupHere
            // 
            this.groupHere.AutoSize = true;
            this.groupHere.Location = new System.Drawing.Point(91, 28);
            this.groupHere.Name = "groupHere";
            this.groupHere.Size = new System.Drawing.Size(57, 13);
            this.groupHere.TabIndex = 1;
            this.groupHere.Text = "groupHere";
            this.groupHere.Click += new System.EventHandler(this.groupHere_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(512, 346);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(13, 58);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(456, 20);
            this.welcomeText.TabIndex = 3;
            this.welcomeText.Text = "Welcome to the system, below you can see your grades.";
            // 
            // addNewGroupToolStripMenuItem
            // 
            this.addNewGroupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNewGroupToolStripMenuItem.Name = "addNewGroupToolStripMenuItem";
            this.addNewGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewGroupToolStripMenuItem.Text = "Add New Group";
            this.addNewGroupToolStripMenuItem.Click += new System.EventHandler(this.addNewGroupToolStripMenuItem_Click);
            // 
            // removeGroupsToolStripMenuItem
            // 
            this.removeGroupsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeGroupsToolStripMenuItem.Name = "removeGroupsToolStripMenuItem";
            this.removeGroupsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeGroupsToolStripMenuItem.Text = "Remove Groups";
            this.removeGroupsToolStripMenuItem.Click += new System.EventHandler(this.removeGroupsToolStripMenuItem_Click);
            // 
            // addGradesToolStripMenuItem
            // 
            this.addGradesToolStripMenuItem.Name = "addGradesToolStripMenuItem";
            this.addGradesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addGradesToolStripMenuItem.Text = "Grade Management";
            this.addGradesToolStripMenuItem.Click += new System.EventHandler(this.addGradesToolStripMenuItem_Click);
            // 
            // adminWelcome
            // 
            this.adminWelcome.AutoSize = true;
            this.adminWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminWelcome.Location = new System.Drawing.Point(13, 58);
            this.adminWelcome.Name = "adminWelcome";
            this.adminWelcome.Size = new System.Drawing.Size(456, 20);
            this.adminWelcome.TabIndex = 3;
            this.adminWelcome.Text = "Welcome, Administrator, use functions in the menu strip";
            // 
            // teacherWelcome
            // 
            this.teacherWelcome.AutoSize = true;
            this.teacherWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherWelcome.Location = new System.Drawing.Point(13, 58);
            this.teacherWelcome.Name = "teacherWelcome";
            this.teacherWelcome.Size = new System.Drawing.Size(414, 20);
            this.teacherWelcome.TabIndex = 3;
            this.teacherWelcome.Text = "Welcome, Teacher, use functions in the menu strip";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.teacherWelcome);
            this.Controls.Add(this.adminWelcome);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupHere);
            this.Controls.Add(this.nameHere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminButton;
        private System.Windows.Forms.ToolStripMenuItem teacherButton;
        private System.Windows.Forms.ToolStripMenuItem studentButton;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameHere;
        private System.Windows.Forms.Label groupHere;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.ToolStripMenuItem registerNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGradesToolStripMenuItem;
        private System.Windows.Forms.Label adminWelcome;
        private System.Windows.Forms.Label teacherWelcome;
    }
}