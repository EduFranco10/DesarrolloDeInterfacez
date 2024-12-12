using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System;

namespace AgendaContactsMySQL.DAO
{
    internal class Conexion
    {
        private const string SERVIDOR = "localhost";
        private const string PUERTO = "3306";
        private const string USER = "root";
        private const string PASSWORD = "root";
        private const string DATABASE = "agendaContacts";

        // Método para obtener la conexión
        public static MySqlConnection GetConexion()
        {
            // Crea la base de datos y tabla si no existen
            CrearBaseDeDatosYTabla();

            // Crea la conexión a la base de datos
            string conexion = "server=" + SERVIDOR + ";port=" + PUERTO + ";user Id=" + USER + ";password=" + PASSWORD + ";database=" + DATABASE + ";";
            MySqlConnection connection = new MySqlConnection(conexion);
            return connection;
        }

        // Método para crear la base de datos y la tabla
        private static void CrearBaseDeDatosYTabla()
        {
            try
            {
                // Conexión inicial para crear la base de datos
                string conexionSinBaseDeDatos = "server=" + SERVIDOR + ";port=" + PUERTO + ";user Id=" + USER + ";password=" + PASSWORD;
                using (MySqlConnection connection = new MySqlConnection(conexionSinBaseDeDatos))
                {
                    connection.Open();

                    // Crear la base de datos si no existe
                    string crearBaseDeDatosQuery = $"CREATE DATABASE IF NOT EXISTS {DATABASE}";
                    using (MySqlCommand cmd = new MySqlCommand(crearBaseDeDatosQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Conexión a la base de datos recién creada
                string conexionConBaseDeDatos = "server=" + SERVIDOR + ";port=" + PUERTO + ";user Id=" + USER + ";password=" + PASSWORD + ";database=" + DATABASE + ";";
                using (MySqlConnection connection = new MySqlConnection(conexionConBaseDeDatos))
                {
                    connection.Open();

                    // Crear la tabla `contacts` si no existe
                    string crearTablaQuery = @"
                        CREATE TABLE IF NOT EXISTS contacts (
                            nameContact VARCHAR(255) NOT NULL,
                            phoneContact VARCHAR(11) PRIMARY KEY
                        )";
                    using (MySqlCommand cmd = new MySqlCommand(crearTablaQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }


                    string crearTablaUserQuery = @"
                        CREATE TABLE IF NOT EXISTS users (
                            user VARCHAR(255) PRIMARY KEY,
                            password VARCHAR(20) NOT NULL
                        )";
                    using (MySqlCommand cmd = new MySqlCommand(crearTablaUserQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la base de datos o la tabla: " + ex.Message);
                throw;
            }
        }
    }
}

