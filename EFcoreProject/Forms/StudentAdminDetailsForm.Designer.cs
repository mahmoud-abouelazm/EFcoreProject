namespace EFcoreProject.Forms
{
    partial class StudentAdminDetailsForm
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
            idBox = new TextBox();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            phoneBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 31);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 95);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 148);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 201);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // idBox
            // 
            idBox.Location = new Point(195, 46);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(272, 27);
            idBox.TabIndex = 4;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(195, 99);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(272, 27);
            firstNameBox.TabIndex = 5;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(195, 152);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(272, 27);
            lastNameBox.TabIndex = 6;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(195, 205);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(272, 27);
            phoneBox.TabIndex = 7;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(195, 266);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(219, 43);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // StudentAdminDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 344);
            Controls.Add(saveBtn);
            Controls.Add(phoneBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(idBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentAdminDetailsForm";
            Text = "Student Details";
            Load += StudentAdminDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idBox;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox phoneBox;
        private Button saveBtn;
    }
}
