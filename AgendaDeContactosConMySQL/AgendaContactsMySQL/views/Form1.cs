using AgendaContactsMySQL.views;

namespace AgendaContactsMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWindowAddContact_Click(object sender, EventArgs e)
        {
            AddContact windowAddContact = new AddContact();
            this.Hide();
            windowAddContact.ShowDialog();
            this.Show();
        }

        private void btnWindowSearchContact_Click(object sender, EventArgs e)
        {
            SearchContact windowSearchContact = new SearchContact();
            this.Hide();
            windowSearchContact.ShowDialog();
            this.Show();
        }

        private void btnWindowUpdateContact_Click(object sender, EventArgs e)
        {
            UpdateContact windowUpdateContact = new UpdateContact();
            this.Hide();
            windowUpdateContact.ShowDialog();
            this.Show();
        }

        private void btnWindowDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact windowDeleteContact = new DeleteContact();
            this.Hide();
            windowDeleteContact.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
