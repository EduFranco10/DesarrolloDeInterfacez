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
using AgendaContactsMySQL.models;
using AgendaContactsMySQL.validator;
namespace AgendaContactsMySQL
{
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            String nameContact = textName.Text;
            String phoneContact = textPhone.Text;

            bool nameValido = Verificador.VerificarName(nameContact);
            bool phoneValido = Verificador.VerificarPhone(phoneContact);

            if (nameValido && phoneValido)
            {
                if (!ContactDAO.SearchByPhone(phoneContact))
                {
                    ContactDAO.InsertContact(new Contact(nameContact, phoneContact));
                    MessageBox.Show("Contacto agregado");
                    btnClean_Click(sender, e);
                }
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textName.ResetText();
            textPhone.ResetText();
        }

        private void AddContact_Load(object sender, EventArgs e)
        {

        }
    }
}
