namespace EFcoreProject.Forms
{
    partial class ManageStudentsForm
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            studentsGrid = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsGrid).BeginInit();
            SuspendLayout();
            // 
            // studentsGrid
            // 
            studentsGrid.AllowUserToAddRows = false;
            studentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsGrid.Location = new Point(12, 12);
            studentsGrid.MultiSelect = false;
            studentsGrid.Name = "studentsGrid";
            studentsGrid.ReadOnly = true;
            studentsGrid.RowHeadersWidth = 51;
            studentsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsGrid.Size = new Size(760, 357);
            studentsGrid.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(25, 390);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(176, 43);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(287, 390);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(176, 43);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(596, 390);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(176, 43);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // ManageStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(studentsGrid);
            Name = "ManageStudentsForm";
            Text = "Manage Students";
            Load += ManageStudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentsGrid;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
    }
}
