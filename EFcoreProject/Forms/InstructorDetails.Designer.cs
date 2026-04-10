namespace EFcoreProject.Forms
{
    partial class InstructorDetails
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
            label1 = new Label();
            label3 = new Label();
            firstNameBox = new TextBox();
            LastNameBox = new TextBox();
            IdBox = new TextBox();
            PhoneBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 106);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 175);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(206, 111);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(284, 27);
            firstNameBox.TabIndex = 3;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(206, 179);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(284, 27);
            LastNameBox.TabIndex = 4;
            // 
            // IdBox
            // 
            IdBox.Location = new Point(206, 54);
            IdBox.Name = "IdBox";
            IdBox.ReadOnly = true;
            IdBox.Size = new Size(284, 27);
            IdBox.TabIndex = 8;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(206, 234);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(284, 27);
            PhoneBox.TabIndex = 7;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 229);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 5;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 305);
            label5.Name = "label5";
            label5.Size = new Size(137, 31);
            label5.TabIndex = 9;
            label5.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 308);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 28);
            comboBox1.TabIndex = 10;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(134, 375);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(228, 44);
            SaveBtn.TabIndex = 11;
            SaveBtn.Text = "save";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // InstructorDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(SaveBtn);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(IdBox);
            Controls.Add(PhoneBox);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(LastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "InstructorDetails";
            Text = "InstructorDetails";
            Load += InstructorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox firstNameBox;
        private TextBox LastNameBox;
        private TextBox IdBox;
        private TextBox PhoneBox;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button SaveBtn;
    }
}