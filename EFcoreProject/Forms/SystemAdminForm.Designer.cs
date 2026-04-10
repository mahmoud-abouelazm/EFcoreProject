namespace EFcoreProject.Forms
{
    partial class SystemAdminForm
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
            btnManageDepartments = new Button();
            btnManageInstructors = new Button();
            btnManageStudents = new Button();
            SuspendLayout();
            // 
            // btnManageDepartments
            // 
            btnManageDepartments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageDepartments.Location = new Point(120, 124);
            btnManageDepartments.Name = "btnManageDepartments";
            btnManageDepartments.Size = new Size(497, 63);
            btnManageDepartments.TabIndex = 0;
            btnManageDepartments.Text = "Manage Departments";
            btnManageDepartments.UseVisualStyleBackColor = true;
            btnManageDepartments.Click += btnManageDepartments_Click;
            // 
            // btnManageInstructors
            // 
            btnManageInstructors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageInstructors.Location = new Point(120, 236);
            btnManageInstructors.Name = "btnManageInstructors";
            btnManageInstructors.Size = new Size(497, 63);
            btnManageInstructors.TabIndex = 1;
            btnManageInstructors.Text = "Manage Instructors";
            btnManageInstructors.UseVisualStyleBackColor = true;
            btnManageInstructors.Click += btnManageInstructors_Click;
            // 
            // btnManageStudents
            // 
            btnManageStudents.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageStudents.Location = new Point(120, 347);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(497, 63);
            btnManageStudents.TabIndex = 2;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = true;
            btnManageStudents.Click += btnManageStudents_Click;
            // 
            // SystemAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(btnManageStudents);
            Controls.Add(btnManageInstructors);
            Controls.Add(btnManageDepartments);
            Name = "SystemAdminForm";
            Text = "System Admin";
            ResumeLayout(false);
        }

        #endregion
        private Button btnManageDepartments;
        private Button btnManageInstructors;
        private Button btnManageStudents;
    }
}