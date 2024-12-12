using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaContactsMySQL.models;
using MySql.Data.MySqlClient;

namespace AgendaContactsMySQL.DAO
{
    internal class UserDAO
    {
        public static void InsertUser(string user, string password)
        {
            // Método para insertar un user
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string insertSQL = "INSERT INTO users (user, password) VALUES (@user, @password)";
                MySqlCommand command = new MySqlCommand(insertSQL, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            } 
        }

        public static bool ComprobarUser(string user, string password)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string selectSQL = "SELECT * FROM users WHERE user = @user AND password = @password";
                MySqlCommand command = new MySqlCommand(selectSQL, connection);
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public static bool SearchUser(string user)
        {
            using (MySqlConnection connection = Conexion.GetConexion())
            {
                connection.Open();
                string searchSQL = "SELECT user FROM users WHERE user = @user";
                MySqlCommand command = new MySqlCommand(searchSQL, connection);
                command.Parameters.AddWithValue("@user", user);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show($"Ya existe un usuario con el nombre : {reader.GetString("user")}");
                        return true;
                    }
                }
                return false;
            }
        }

    }
}
