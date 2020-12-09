namespace AcademicSystem
{
    partial class AddGrades
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.subjectTableAdapter = new AcademicSystem.academicDataSetTableAdapters.subjectTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicDataSet = new AcademicSystem.academicDataSet();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new AcademicSystem.academicDataSetTableAdapters.groupsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 19;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Enter a new grade down below";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.academicDataSet;
            // 
            // academicDataSet
            // 
            this.academicDataSet.DataSetName = "academicDataSet";
            this.academicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.academicDataSet;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.groupsBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Grade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Students in selected group:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student grades:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(274, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 195);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(600, 101);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(328, 195);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Group:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Name = "AddGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGrades";
            this.Load += new System.EventHandler(this.AddGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private academicDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private academicDataSet academicDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private academicDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}