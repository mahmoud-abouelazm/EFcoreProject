namespace EFcoreProject.Forms
{
    partial class InstructorAdminDetailsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            idBox = new TextBox();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            phoneBox = new TextBox();
            departmentBox = new ComboBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 31);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 95);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 148);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 201);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 254);
            label5.Name = "label5";
            label5.Size = new Size(137, 31);
            label5.TabIndex = 4;
            label5.Text = "Department";
            // 
            // idBox
            // 
            idBox.Location = new Point(197, 46);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(272, 27);
            idBox.TabIndex = 5;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(197, 99);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(272, 27);
            firstNameBox.TabIndex = 6;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(197, 152);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(272, 27);
            lastNameBox.TabIndex = 7;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(197, 205);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(272, 27);
            phoneBox.TabIndex = 8;
            // 
            // departmentBox
            // 
            departmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentBox.FormattingEnabled = true;
            departmentBox.Location = new Point(197, 258);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(272, 28);
            departmentBox.TabIndex = 9;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(197, 314);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(219, 43);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // InstructorAdminDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 388);
            Controls.Add(saveBtn);
            Controls.Add(departmentBox);
            Controls.Add(phoneBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(idBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InstructorAdminDetailsForm";
            Text = "Instructor Details";
            Load += InstructorAdminDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idBox;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox phoneBox;
        private ComboBox departmentBox;
        private Button saveBtn;
    }
}
