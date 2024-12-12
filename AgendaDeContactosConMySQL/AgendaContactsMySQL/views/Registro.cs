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
using Microsoft.VisualBasic.ApplicationServices;

namespace AgendaContactsMySQL.views
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string user = textUser.Text;
            string password = textPassword.Text;
            string passwordRepetido = textRepetirPassword.Text;

            bool userValido = comprobarUser(user);
            bool passwordValido = comprobarPassword(password);
            bool passwordRepetidoValido = comprobarPassword(passwordRepetido);
            bool equalsPassword = comprobarEqualsPassword(password, passwordRepetido);

            if (userValido && passwordValido && passwordRepetidoValido && equalsPassword)
            {
                if (!UserDAO.SearchUser(user))
                {
                    MessageBox.Show("Se ha creado correctamente la cuenta.");
                    UserDAO.InsertUser(user, password);

                    Form1 windowMenu = new Form1();
                    this.Hide();
                    windowMenu.ShowDialog();
                }
            }

        }

        private bool comprobarUser(string user)
        {
            if (user == null)
            {
                MessageBox.Show("El usuario no puede ser nulo.");
                return false;
            }
            else if (user.Length < 3)
            {
                MessageBox.Show("El usuario tiene que tener como mínimo tres caracteres.");
                return false;
            }
            return true;
        }

        private bool comprobarPassword(string password)
        {
            if (password == null || password.Equals(""))
            {
                MessageBox.Show("La contraseña no puede ser nula ni vacia.");
                return false;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("La contraseña tiene que tener como mínimo 8 caracteres.");
                return false;
            }
            return true;
        }

        private bool comprobarEqualsPassword(string password, string passwordComprobacion)
        {
            if (!password.Equals(passwordComprobacion))
            {
                MessageBox.Show("Las contraseñas no son iguales.");
            }
            return password.Equals(passwordComprobacion);
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarPassword_Click(object sender, EventArgs e)
        {
            if (textPassword.UseSystemPasswordChar)
            {
                textPassword.UseSystemPasswordChar = false; // Muestra la contraseña
                btnMostrarPassword.Text = "Ocultar";
            }
            else
            {
                textPassword.UseSystemPasswordChar = true; // Oculta la contraseña
                btnMostrarPassword.Text = "Mostrar";
            }
        }

        private void btnMostrarPasswordRepetido_Click(object sender, EventArgs e)
        {
            if (textRepetirPassword.UseSystemPasswordChar)
            {
                textRepetirPassword.UseSystemPasswordChar = false; // Muestra la contraseña
                btnMostrarPasswordRepetido.Text = "Ocultar";
            }
            else
            {
                textRepetirPassword.UseSystemPasswordChar = true; // Oculta la contraseña
                btnMostrarPasswordRepetido.Text = "Mostrar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textUser.ResetText();
            textPassword.ResetText();
            textRepetirPassword.ResetText();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
