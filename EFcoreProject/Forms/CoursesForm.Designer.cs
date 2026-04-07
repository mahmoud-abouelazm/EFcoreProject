namespace EFcoreProject.Forms
{
    partial class CoursesForm
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
            CoursesGirdView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CoursesGirdView).BeginInit();
            SuspendLayout();
            // 
            // CoursesGirdView
            // 
            CoursesGirdView.AllowUserToAddRows = false;
            CoursesGirdView.AllowUserToDeleteRows = false;
            CoursesGirdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesGirdView.Dock = DockStyle.Fill;
            CoursesGirdView.Location = new Point(0, 0);
            CoursesGirdView.Name = "CoursesGirdView";
            CoursesGirdView.ReadOnly = true;
            CoursesGirdView.RowHeadersWidth = 51;
            CoursesGirdView.Size = new Size(1180, 450);
            CoursesGirdView.TabIndex = 0;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 450);
            Controls.Add(CoursesGirdView);
            Name = "CoursesForm";
            Text = "CoursesForm";
            Load += CoursesForm_Load;
            ((System.ComponentModel.ISupportInitialize)CoursesGirdView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CoursesGirdView;
    }
}