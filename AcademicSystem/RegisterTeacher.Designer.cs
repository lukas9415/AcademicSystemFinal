namespace AcademicSystem
{
    partial class RegisterTeacher
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
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicDataSet = new AcademicSystem.academicDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupsTableAdapter = new AcademicSystem.academicDataSetTableAdapters.groupsTableAdapter();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new AcademicSystem.academicDataSetTableAdapters.subjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.academicDataSet;
            // 
            // academicDataSet
            // 
            this.academicDataSet.DataSetName = "academicDataSet";
            this.academicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 23;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(89, 44);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTextBox.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.academicDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 140);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterTeacher";
            this.Load += new System.EventHandler(this.RegisterTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private academicDataSet academicDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private academicDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private academicDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
    }
}