namespace EFcoreProject
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }
        userID userIDForm = new();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            this.Hide();
            userIDForm.ShowDialog();
            this.Show();
        }

        private void btnDptMng_Click(object sender, EventArgs e)
        {
            this.Hide();
            userIDForm.ShowDialog();
            this.Show();
        }
    }
}
