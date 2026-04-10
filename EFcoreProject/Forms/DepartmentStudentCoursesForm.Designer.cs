namespace EFcoreProject.Forms
{
    partial class DepartmentStudentCoursesForm
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
            if (disposing && context != null)
            {
                context.Dispose();
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
            assignmentsGrid = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)assignmentsGrid).BeginInit();
            SuspendLayout();
            // 
            // assignmentsGrid
            // 
            assignmentsGrid.AllowUserToAddRows = false;
            assignmentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentsGrid.Location = new Point(12, 12);
            assignmentsGrid.MultiSelect = false;
            assignmentsGrid.Name = "assignmentsGrid";
            assignmentsGrid.ReadOnly = true;
            assignmentsGrid.RowHeadersWidth = 51;
            assignmentsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            assignmentsGrid.Size = new Size(760, 367);
            assignmentsGrid.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(25, 395);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(176, 43);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(279, 395);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(245, 43);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(596, 395);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(176, 43);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // DepartmentStudentCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(assignmentsGrid);
            Name = "DepartmentStudentCoursesForm";
            Text = "Department Student Courses";
            Load += DepartmentStudentCoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)assignmentsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView assignmentsGrid;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
    }
}
