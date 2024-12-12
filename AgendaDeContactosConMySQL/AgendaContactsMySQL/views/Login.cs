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

namespace AgendaContactsMySQL.views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textUser.Text;
            string password = textPassword.Text;

            bool userValido = comprobarUser(user);
            bool passwordValido = comprobarPassword(password);
            if (userValido && passwordValido)
            {
                if (UserDAO.ComprobarUser(user, password))
                {

                    abrirWindowMenuCerrarLogin();
                }
                else
                {
                    MessageBox.Show("El usuario introducido no existe");
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            abrirWindowRegistroCerrarLogin();
        }

        private bool comprobarUser(string user)
        {
            if (user == null)
            {
                MessageBox.Show("El usuario no puede ser nulo");
                return false;
            }
            else if (user.Length < 3)
            {
                MessageBox.Show("El usuario tine que tener como mínimo tres caracteres");
                return false;
            }
            return true;
        }

        private bool comprobarPassword(string password)
        {

            if (password == null || password.Equals(""))
            {
                MessageBox.Show("La contraseña no puede ser nula");
                return false;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("La contraseña tine que tener como mínimo 8 caracteres");
                return false;
            }
            return true;
        }

        private void abrirWindowRegistroCerrarLogin()
        {
            this.Hide();
            Registro windowRegistro = new Registro();
            windowRegistro.ShowDialog();
            this.Close();
        }

        private void abrirWindowMenuCerrarLogin()
        {
            this.Hide();
            Form1 windowMenu = new Form1();
            windowMenu.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            textUser.ResetText();
            textPassword.ResetText();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
