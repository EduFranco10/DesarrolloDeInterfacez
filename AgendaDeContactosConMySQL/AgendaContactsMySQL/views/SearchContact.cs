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

namespace AgendaContactsMySQL.views
{
    public partial class SearchContact : Form
    {
        public SearchContact()
        {
            InitializeComponent();
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            string nameContact = textName.Text;
            string phoneContact = textPhone.Text;

            bool nameValido = Verificador.VerificarName(nameContact);
            bool phoneValido = Verificador.VerificarPhone(phoneContact);

            if (nameValido && phoneValido)
            {
                if (ContactDAO.ComprobarContact(nameContact, phoneContact))
                {
                    MessageBox.Show("Contacto encontrado\nNombre: " + nameContact + "\nTélefono: " + phoneContact);
                    btnClean_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Contacto no encontrado.");
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textName.ResetText();
            textPhone.ResetText();
        }

        private void SearchContact_Load(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
