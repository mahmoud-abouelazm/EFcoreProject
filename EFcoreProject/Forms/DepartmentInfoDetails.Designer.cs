namespace EFcoreProject.Forms
{
    partial class DepartmentInfoDetails
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
            label1 = new Label();
            label3 = new Label();
            nameBox = new TextBox();
            locationBox = new TextBox();
            IdBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            managerBox = new ComboBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 106);
            label1.Name = "label1";
            label1.Size = new Size(74, 31);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 175);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 2;
            label3.Text = "Location";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(206, 111);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(284, 27);
            nameBox.TabIndex = 3;
            // 
            // locationBox
            // 
            locationBox.Location = new Point(206, 179);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(284, 27);
            locationBox.TabIndex = 4;
            // 
            // IdBox
            // 
            IdBox.Location = new Point(206, 54);
            IdBox.Name = "IdBox";
            IdBox.ReadOnly = true;
            IdBox.Size = new Size(284, 27);
            IdBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 50);
            label2.Name = "label2";
            label2.Size = new Size(34, 31);
            label2.TabIndex = 6;
            label2.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 245);
            label5.Name = "label5";
            label5.Size = new Size(100, 31);
            label5.TabIndex = 9;
            label5.Text = "Manager";
            // 
            // managerBox
            // 
            managerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            managerBox.FormattingEnabled = true;
            managerBox.Location = new Point(206, 248);
            managerBox.Name = "managerBox";
            managerBox.Size = new Size(265, 28);
            managerBox.TabIndex = 10;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(134, 316);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(228, 44);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // DepartmentInfoDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 389);
            Controls.Add(saveBtn);
            Controls.Add(managerBox);
            Controls.Add(label5);
            Controls.Add(IdBox);
            Controls.Add(label2);
            Controls.Add(locationBox);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "DepartmentInfoDetails";
            Text = "DepartmentInfoDetails";
            Load += DepartmentInfoDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox nameBox;
        private TextBox locationBox;
        private TextBox IdBox;
        private Label label2;
        private Label label5;
        private ComboBox managerBox;
        private Button saveBtn;
    }
}
