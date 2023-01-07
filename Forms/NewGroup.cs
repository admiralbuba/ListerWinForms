namespace Lister
{
    public partial class NewGroup : Form
    {
        public string GroupName { get; set; }
        public NewGroup()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            GroupName = groupName.Text;
            DialogResult= DialogResult.OK;
            Close();
        }
    }
}
