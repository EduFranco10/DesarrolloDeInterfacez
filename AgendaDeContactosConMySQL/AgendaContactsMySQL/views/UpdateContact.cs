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
    public partial class UpdateContact : Form
    {
        public UpdateContact()
        {
            InitializeComponent();
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            string newName = textNewName.Text;
            string newPhone = textNewPhone.Text;
            string phone = textPhoneActual.Text;

            bool newNameValido = Verificador.VerificarName(newName);
            bool newphoneValido = Verificador.VerificarPhone(newPhone);
            bool phoneValido = Verificador.VerificarPhone(phone);

            if (newNameValido && phoneValido && newphoneValido)
            {
                ContactDAO.UpdateContact(phone, new Contact(newName, newPhone));
                btnClean_Click(sender, e);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textNewName.ResetText();
            textNewPhone.ResetText();
            textPhoneActual.ResetText();
        }

        private void UpdateContact_Load(object sender, EventArgs e)
        {

        }
    }
}
