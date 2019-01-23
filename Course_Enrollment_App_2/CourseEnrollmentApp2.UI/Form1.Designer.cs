namespace CourseEnrollmentApp2.UI
{
    partial class EnrollmentForm
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
            this.enrollmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseEnrollmentDB10DataSet = new CourseEnrollmentApp2.UI.CourseEnrollmentDB10DataSet();
            this.EnrollmentGridView = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentsTableAdapter = new CourseEnrollmentApp2.UI.CourseEnrollmentDB10DataSetTableAdapters.EnrollmentsTableAdapter();
            this.studentsTableAdapter = new CourseEnrollmentApp2.UI.CourseEnrollmentDB10DataSetTableAdapters.StudentsTableAdapter();
            this.closeButton = new System.Windows.Forms.Button();
            this.courseEnrollmentDB10DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseEnrollmentDB10DataSet1 = new CourseEnrollmentApp2.UI.CourseEnrollmentDB10DataSet1();
            this.courseEnrollmentDB10DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new CourseEnrollmentApp2.UI.CourseEnrollmentDB10DataSetTableAdapters.CoursesTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enrollmentsBindingSource
            // 
            this.enrollmentsBindingSource.DataMember = "Enrollments";
            this.enrollmentsBindingSource.DataSource = this.courseEnrollmentDB10DataSet;
            // 
            // courseEnrollmentDB10DataSet
            // 
            this.courseEnrollmentDB10DataSet.DataSetName = "CourseEnrollmentDB10DataSet";
            this.courseEnrollmentDB10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EnrollmentGridView
            // 
            this.EnrollmentGridView.AutoGenerateColumns = false;
            this.EnrollmentGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EnrollmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnrollmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.StudentId,
            this.CourseId,
            this.Grade});
            this.EnrollmentGridView.DataSource = this.enrollmentsBindingSource;
            this.EnrollmentGridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.EnrollmentGridView.Location = new System.Drawing.Point(12, 12);
            this.EnrollmentGridView.Name = "EnrollmentGridView";
            this.EnrollmentGridView.Size = new System.Drawing.Size(446, 426);
            this.EnrollmentGridView.TabIndex = 1;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.courseEnrollmentDB10DataSet;
            // 
            // enrollmentsTableAdapter
            // 
            this.enrollmentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(490, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // courseEnrollmentDB10DataSetBindingSource
            // 
            this.courseEnrollmentDB10DataSetBindingSource.DataSource = this.courseEnrollmentDB10DataSet;
            this.courseEnrollmentDB10DataSetBindingSource.Position = 0;
            // 
            // courseEnrollmentDB10DataSet1
            // 
            this.courseEnrollmentDB10DataSet1.DataSetName = "CourseEnrollmentDB10DataSet1";
            this.courseEnrollmentDB10DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseEnrollmentDB10DataSet1BindingSource
            // 
            this.courseEnrollmentDB10DataSet1BindingSource.DataSource = this.courseEnrollmentDB10DataSet1;
            this.courseEnrollmentDB10DataSet1BindingSource.Position = 0;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.courseEnrollmentDB10DataSetBindingSource;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EnrollmentId";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "CourseId";
            this.CourseId.Name = "CourseId";
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.EnrollmentGridView);
            this.Name = "EnrollmentForm";
            this.Text = "Enrollment List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseEnrollmentDB10DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView EnrollmentGridView;
        private CourseEnrollmentDB10DataSet courseEnrollmentDB10DataSet;
        private System.Windows.Forms.BindingSource enrollmentsBindingSource;
        private CourseEnrollmentDB10DataSetTableAdapters.EnrollmentsTableAdapter enrollmentsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private CourseEnrollmentDB10DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.BindingSource courseEnrollmentDB10DataSetBindingSource;
        private System.Windows.Forms.BindingSource courseEnrollmentDB10DataSet1BindingSource;
        private CourseEnrollmentDB10DataSet1 courseEnrollmentDB10DataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CourseEnrollmentDB10DataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}

