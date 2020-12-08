namespace AcademicSystem
{
    partial class GradeInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameHere = new System.Windows.Forms.Label();
            this.gradeHere = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherHere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade:";
            // 
            // nameHere
            // 
            this.nameHere.AutoSize = true;
            this.nameHere.Location = new System.Drawing.Point(108, 15);
            this.nameHere.Name = "nameHere";
            this.nameHere.Size = new System.Drawing.Size(56, 13);
            this.nameHere.TabIndex = 0;
            this.nameHere.Text = "nameHere";
            // 
            // gradeHere
            // 
            this.gradeHere.AutoSize = true;
            this.gradeHere.Location = new System.Drawing.Point(108, 57);
            this.gradeHere.Name = "gradeHere";
            this.gradeHere.Size = new System.Drawing.Size(57, 13);
            this.gradeHere.TabIndex = 0;
            this.gradeHere.Text = "gradeHere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teacher:";
            // 
            // teacherHere
            // 
            this.teacherHere.AutoSize = true;
            this.teacherHere.Location = new System.Drawing.Point(108, 36);
            this.teacherHere.Name = "teacherHere";
            this.teacherHere.Size = new System.Drawing.Size(66, 13);
            this.teacherHere.TabIndex = 1;
            this.teacherHere.Text = "teacherHere";
            // 
            // GradeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.teacherHere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradeHere);
            this.Controls.Add(this.nameHere);
            this.Controls.Add(this.label1);
            this.Name = "GradeInfo";
            this.Size = new System.Drawing.Size(450, 89);
            this.Load += new System.EventHandler(this.GradeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameHere;
        private System.Windows.Forms.Label gradeHere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label teacherHere;
    }
}
