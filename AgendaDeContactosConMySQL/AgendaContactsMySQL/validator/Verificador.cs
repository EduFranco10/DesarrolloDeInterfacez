using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaContactsMySQL.DAO;

namespace AgendaContactsMySQL.validator
{
    internal class Verificador
    {
        public static bool VerificarPhone(string phone)
        {


            if (phone == null || phone.Equals(""))
            {
                MessageBox.Show("El número de télefono no puede ser vacío");
                return false;
            }

            if (phone.Length != 11)
            {
                MessageBox.Show("El número de télefono debe tener 11 números");
                return false;
            }

             for (int i = 0; i < phone.Length; i++)
                {
                    if (phone[i] < '0' || phone[i] > '9')
                    {
                        MessageBox.Show("Debe estar entre 0-9");
                        return false;
                    }
                }
            
            
             return true;
        }

        // Verifica el nombre
        public static bool VerificarName(string name)
        {
            if (name == null || name.Length < 3 || name.Equals(""))
            {
                MessageBox.Show("Nombre no válido");
                return false;
            }
          
            return true;
        }


    }
}
