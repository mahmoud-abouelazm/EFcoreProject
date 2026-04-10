namespace EFcoreProject.Forms
{
    partial class ManageInstructorsForm
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
            instructorsGrid = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)instructorsGrid).BeginInit();
            SuspendLayout();
            // 
            // instructorsGrid
            // 
            instructorsGrid.AllowUserToAddRows = false;
            instructorsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            instructorsGrid.Location = new Point(12, 12);
            instructorsGrid.MultiSelect = false;
            instructorsGrid.Name = "instructorsGrid";
            instructorsGrid.ReadOnly = true;
            instructorsGrid.RowHeadersWidth = 51;
            instructorsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instructorsGrid.Size = new Size(760, 357);
            instructorsGrid.TabIndex = 0;
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
            // ManageInstructorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(instructorsGrid);
            Name = "ManageInstructorsForm";
            Text = "Manage Instructors";
            Load += ManageInstructorsForm_Load;
            ((System.ComponentModel.ISupportInitialize)instructorsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView instructorsGrid;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
    }
}
