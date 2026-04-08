namespace EFcoreProject.Forms
{
    partial class DepartmentDetails
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
            deleteBtn = new Button();
            updateBtn = new Button();
            AddBtn = new Button();
            Courses = new DataGridView();
            deptInfoEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)Courses).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(332, 388);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(133, 50);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete Course";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(144, 388);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(168, 50);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update Course";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(15, 388);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 50);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Add Course";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // Courses
            // 
            Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Courses.Location = new Point(12, 12);
            Courses.Name = "Courses";
            Courses.RowHeadersWidth = 51;
            Courses.Size = new Size(631, 351);
            Courses.TabIndex = 4;
            // 
            // deptInfoEdit
            // 
            deptInfoEdit.Location = new Point(492, 388);
            deptInfoEdit.Name = "deptInfoEdit";
            deptInfoEdit.Size = new Size(151, 50);
            deptInfoEdit.TabIndex = 8;
            deptInfoEdit.Text = "Department info";
            deptInfoEdit.UseVisualStyleBackColor = true;
            // 
            // DepartmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 450);
            Controls.Add(deptInfoEdit);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(AddBtn);
            Controls.Add(Courses);
            Name = "DepartmentDetails";
            Text = "DepartmentDetails";
            ((System.ComponentModel.ISupportInitialize)Courses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button deleteBtn;
        private Button updateBtn;
        private Button AddBtn;
        private DataGridView Courses;
        private Button deptInfoEdit;
    }
}