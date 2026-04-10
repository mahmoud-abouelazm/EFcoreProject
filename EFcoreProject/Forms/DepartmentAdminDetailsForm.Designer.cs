namespace EFcoreProject.Forms
{
    partial class DepartmentAdminDetailsForm
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
            idBox = new TextBox();
            nameBox = new TextBox();
            locationBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(34, 31);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 106);
            label2.Name = "label2";
            label2.Size = new Size(74, 31);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 166);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 2;
            label3.Text = "Location";
            // 
            // idBox
            // 
            idBox.Location = new Point(164, 50);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(266, 27);
            idBox.TabIndex = 3;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(164, 110);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(266, 27);
            nameBox.TabIndex = 4;
            // 
            // locationBox
            // 
            locationBox.Location = new Point(164, 170);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(266, 27);
            locationBox.TabIndex = 5;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(164, 230);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(220, 43);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // DepartmentAdminDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 312);
            Controls.Add(saveBtn);
            Controls.Add(locationBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepartmentAdminDetailsForm";
            Text = "Department Details";
            Load += DepartmentAdminDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox locationBox;
        private Button saveBtn;
    }
}
