namespace EFcoreProject.Forms
{
    partial class CourseSessionAttendanceForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            AddBtn = new System.Windows.Forms.Button();
            updateBtn = new System.Windows.Forms.Button();
            deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(793, 351);
            dataGridView1.TabIndex = 0;
            // 
            // AddBtn
            // 
            AddBtn.Location = new System.Drawing.Point(25, 377);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(176, 50);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new System.Drawing.Point(280, 377);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new System.Drawing.Size(176, 50);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new System.Drawing.Point(558, 377);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(176, 50);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // CourseSessionAttendanceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Name = "CourseSessionAttendanceForm";
            Text = "Course Session Attendance";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}