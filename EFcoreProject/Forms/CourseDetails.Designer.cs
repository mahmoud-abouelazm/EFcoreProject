namespace EFcoreProject.Forms
{
    partial class CourseDetails
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
            IdBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            instructorBox = new ComboBox();
            saveBtn = new Button();
            durationBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)durationBox).BeginInit();
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
            label3.Size = new Size(99, 31);
            label3.TabIndex = 2;
            label3.Text = "Duration";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(206, 111);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(284, 27);
            nameBox.TabIndex = 3;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 240);
            label4.Name = "label4";
            label4.Size = new Size(103, 31);
            label4.TabIndex = 9;
            label4.Text = "Instructor";
            // 
            // instructorBox
            // 
            instructorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            instructorBox.FormattingEnabled = true;
            instructorBox.Location = new Point(206, 243);
            instructorBox.Name = "instructorBox";
            instructorBox.Size = new Size(284, 28);
            instructorBox.TabIndex = 10;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(134, 290);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(228, 44);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // durationBox
            // 
            durationBox.Location = new Point(206, 179);
            durationBox.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            durationBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            durationBox.Name = "durationBox";
            durationBox.Size = new Size(284, 27);
            durationBox.TabIndex = 12;
            durationBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CourseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 365);
            Controls.Add(instructorBox);
            Controls.Add(label4);
            Controls.Add(durationBox);
            Controls.Add(saveBtn);
            Controls.Add(IdBox);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CourseDetails";
            Text = "CourseDetails";
            Load += CourseDetails_Load;
            ((System.ComponentModel.ISupportInitialize)durationBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox nameBox;
        private TextBox IdBox;
        private Label label2;
        private Label label4;
        private ComboBox instructorBox;
        private Button saveBtn;
        private NumericUpDown durationBox;
    }
}
