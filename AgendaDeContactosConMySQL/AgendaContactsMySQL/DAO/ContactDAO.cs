using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using AgendaContactsMySQL.models;

namespace AgendaContactsMySQL.DAO
{
    internal class ContactDAO
    {
        // Método para insertar un contacto
        public static void InsertContact(Contact contact)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string insertSQL = "INSERT INTO contacts (nameContact, phoneContact) VALUES (@nameContact, @phoneContact)";
                MySqlCommand command = new MySqlCommand(insertSQL, connection);
                command.Parameters.AddWithValue("@nameContact", contact.Name);
                command.Parameters.AddWithValue("@phoneContact", contact.Phone);

                command.ExecuteNonQuery();
            }
        }

        // Método para actualizar el número de teléfono de un contacto
        public static void UpdateContact(string phoneActual, Contact newContact)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string updateSQL = "UPDATE contacts SET phoneContact = @newPhoneContact, nameContact = @newNameContact WHERE phoneContact = @phoneContact";
                
                MySqlCommand command = new MySqlCommand(updateSQL, connection);
                command.Parameters.AddWithValue("phoneContact", phoneActual);

                command.Parameters.AddWithValue("@newNameContact", newContact.Name);
                command.Parameters.AddWithValue("@newPhoneContact", newContact.Phone);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contacto actualizado.");
                }
                else
                {
                    MessageBox.Show("No existe un contacto con el núemro " + phoneActual);
                }
            }
        }

        // Método para eliminar un contacto
        public static void DeleteContact(Contact contact)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string deleteSQL = "DELETE FROM contacts WHERE nameContact = @nameContact AND phoneContact = @phoneContact";
                MySqlCommand command = new MySqlCommand(deleteSQL, connection);
                command.Parameters.AddWithValue("@nameContact", contact.Name);
                command.Parameters.AddWithValue("@phoneContact", contact.Phone);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Contacto eliminado con éxito.");
                }
                else
                {
                    MessageBox.Show("Contacto no encontrado.");
                }
            }
        }

        // Método para buscar un contacto por número de teléfono
        public static bool SearchByPhone(string phoneContact)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string searchSQL = "SELECT nameContact, phoneContact FROM contacts WHERE phoneContact = @phoneContact";
                MySqlCommand command = new MySqlCommand(searchSQL, connection);
                command.Parameters.AddWithValue("@phoneContact", phoneContact);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show($"Ya existe un contacto con el número de télefono: {reader.GetString("phoneContact")}");
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool SearchByName(string nameContact)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string searchSQL = "SELECT nameContact, phoneContact FROM contacts WHERE nameContact = @nameContact";
                MySqlCommand command = new MySqlCommand(searchSQL, connection);
                command.Parameters.AddWithValue("@nameContact", nameContact);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show($"Ya existe un contacto con el nombre : {reader.GetString("nameContact")}");
                        return true;
                    }
                }
                return false;
            }
        }

        // Método para comprobar si un contacto ya existe
        public static bool ComprobarContact(string nameContact, string phoneContact)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string selectSQL = "SELECT * FROM contacts WHERE nameContact = @nameContact AND phoneContact = @phoneContact";
                MySqlCommand command = new MySqlCommand(selectSQL, connection);
                command.Parameters.AddWithValue("@nameContact", nameContact);
                command.Parameters.AddWithValue("@phoneContact", phoneContact);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }
}

