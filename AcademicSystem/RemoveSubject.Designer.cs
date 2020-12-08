namespace AcademicSystem
{
    partial class RemoveSubject
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
            this.groupsTableAdapter = new AcademicSystem.academicDataSetTableAdapters.groupsTableAdapter();
            this.subjectTableAdapter = new AcademicSystem.academicDataSetTableAdapters.subjectTableAdapter();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicDataSet = new AcademicSystem.academicDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select a subject down below";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.academicDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Remove Subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subject name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Subjects in the system:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Available Teachers:";
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(274, 45);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(452, 195);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(732, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 195);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.subjectBindingSource2;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "id";
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataMember = "subject";
            this.subjectBindingSource1.DataSource = this.academicDataSet;
            // 
            // subjectBindingSource2
            // 
            this.subjectBindingSource2.DataMember = "subject";
            this.subjectBindingSource2.DataSource = this.academicDataSet;
            // 
            // RemoveSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 251);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "RemoveSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveSubject";
            this.Load += new System.EventHandler(this.RemoveSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private academicDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private academicDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private academicDataSet academicDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.BindingSource subjectBindingSource2;
    }
}