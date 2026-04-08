namespace EFcoreProject.Forms
{
    partial class DepartmentEdit
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
            SaveBtn = new Button();
            this.Manager = new ComboBox();
            label5 = new Label();
            IdBox = new TextBox();
            PhoneBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            NameBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(102, 360);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(228, 44);
            SaveBtn.TabIndex = 22;
            SaveBtn.Text = "save";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.Manager.FormattingEnabled = true;
            this.Manager.Location = new Point(174, 249);
            this.Manager.Name = "Manager";
            this.Manager.Size = new Size(265, 28);
            this.Manager.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 243);
            label5.Name = "label5";
            label5.Size = new Size(106, 31);
            label5.TabIndex = 20;
            label5.Text = "Manager";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(174, 39);
            IdBox.Name = "IdBox";
            IdBox.ReadOnly = true;
            IdBox.Size = new Size(284, 27);
            IdBox.TabIndex = 19;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(174, 168);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(284, 27);
            PhoneBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 35);
            label2.Name = "label2";
            label2.Size = new Size(34, 31);
            label2.TabIndex = 17;
            label2.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 162);
            label4.Name = "label4";
            label4.Size = new Size(101, 31);
            label4.TabIndex = 16;
            label4.Text = "Location";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(174, 96);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(284, 27);
            NameBox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 91);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // DepartmentEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(SaveBtn);
            Controls.Add(this.Manager);
            Controls.Add(label5);
            Controls.Add(IdBox);
            Controls.Add(PhoneBox);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Name = "DepartmentEdit";
            Text = "DepartmentEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private ComboBox Manager;
        private Label label5;
        private TextBox IdBox;
        private TextBox PhoneBox;
        private Label label2;
        private Label label4;
        private TextBox LastNameBox;
        private TextBox NameBox;
        private Label label3;
        private Label label1;
    }
}