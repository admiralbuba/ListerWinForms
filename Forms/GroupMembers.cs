namespace Lister.Forms
{
    public partial class GroupMembers : Form
    {
        public List<string> Users { get; set; }
        public GroupMembers()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (users.CheckedItems.Count == 0)
            {
                MessageBox.Show("Choose at least one user");
                return;
            }
            Users = users.CheckedItems.Cast<string>().ToList(); 
            DialogResult = DialogResult.OK;
        }
    }
}
