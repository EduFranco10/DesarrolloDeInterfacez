using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaContactsMySQL.DAO;
using AgendaContactsMySQL.validator;
using AgendaContactsMySQL.models;


namespace AgendaContactsMySQL.views
{
    public partial class DeleteContact : Form
    {
        public DeleteContact()
        {
            InitializeComponent();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string phone = textPhone.Text;

            bool nameValido = Verificador.VerificarName(name);
            bool phoneValido = Verificador.VerificarPhone(phone);

            if (nameValido && phoneValido)
            {
                ContactDAO.DeleteContact(new Contact(name, phone));
                btnClean_Click(sender, e);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textName.ResetText();
            textPhone.ResetText();
        }

        private void DeleteContact_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
