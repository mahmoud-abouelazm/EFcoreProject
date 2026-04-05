namespace EFcoreProject
{
    partial class welcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSysAdmin = new Button();
            btnInstructor = new Button();
            btnDptMng = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 73);
            label1.Name = "label1";
            label1.Size = new Size(502, 60);
            label1.TabIndex = 0;
            label1.Text = "Welcome To ITI System";
            label1.Click += label1_Click;
            // 
            // btnSysAdmin
            // 
            btnSysAdmin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSysAdmin.Location = new Point(158, 326);
            btnSysAdmin.Name = "btnSysAdmin";
            btnSysAdmin.Size = new Size(448, 59);
            btnSysAdmin.TabIndex = 1;
            btnSysAdmin.Text = "System Admin";
            btnSysAdmin.UseVisualStyleBackColor = true;
            // 
            // btnInstructor
            // 
            btnInstructor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInstructor.Location = new Point(158, 173);
            btnInstructor.Name = "btnInstructor";
            btnInstructor.Size = new Size(448, 59);
            btnInstructor.TabIndex = 2;
            btnInstructor.Text = "Instructor";
            btnInstructor.UseVisualStyleBackColor = true;
            btnInstructor.Click += btnInstructor_Click;
            // 
            // btnDptMng
            // 
            btnDptMng.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDptMng.Location = new Point(158, 248);
            btnDptMng.Name = "btnDptMng";
            btnDptMng.Size = new Size(448, 59);
            btnDptMng.TabIndex = 3;
            btnDptMng.Text = "Department Manager";
            btnDptMng.UseVisualStyleBackColor = true;
            btnDptMng.Click += btnDptMng_Click;
            // 
            // welcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 423);
            Controls.Add(btnDptMng);
            Controls.Add(btnInstructor);
            Controls.Add(btnSysAdmin);
            Controls.Add(label1);
            Name = "welcomeForm";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSysAdmin;
        private Button btnInstructor;
        private Button btnDptMng;
    }
}
