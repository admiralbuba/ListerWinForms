using Lister.Forms;

namespace Lister
{
    public partial class NewGroup : Form
    {
        public string GroupName { get; set; }
        public List<string> Users { get; set; }
        public NewGroup()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (groupName.Text == "")
            {
                MessageBox.Show("Enter group name");
                return;
            }

            GroupName = groupName.Text;
            using (var form = new GroupMembers())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Users = form.Users;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
