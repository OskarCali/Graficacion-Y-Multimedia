using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PracticaDB_GrafMult
{
    class DataBase
    {
        public static MySqlConnection Connection()
        {
            string server = "localhost";
            string port = "3306";
            string user = "root";
            string pass = "";
            string database = "grafmult_P7";

            string cadenaFormat = string.Format("Server={0};port={1};Uid={2};pwd={3};database={4};", server, port, user, pass,
                database);

            MySqlConnection connex = new MySqlConnection();

            connex.ConnectionString = cadenaFormat;
            connex.Open();

            return connex;
        }

        public static int Agregar(Persona persona)
        {
            int res = 0;
            MySqlCommand command = new MySqlCommand();

            command.CommandText =
                "INSERT INTO persona (nombre, apellido, edad) values ('" + persona.nombre + "', '" + persona.apellido +
                "', " + persona.edad + ");";
            command.Connection = Connection();

            res = command.ExecuteNonQuery();

            return res;
        }

        public static List<Persona> Cargar()
        {
            List<Persona> personas = new List<Persona>();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM persona;";
            command.Connection = Connection();

            MySqlDataReader personasReader = command.ExecuteReader();

            while (personasReader.Read())
            {
                Persona nuevaPersona = new Persona();
                nuevaPersona.id = personasReader.GetInt32(0);
                nuevaPersona.nombre = personasReader.GetString(1);
                nuevaPersona.apellido = personasReader.GetString(2);
                nuevaPersona.edad = personasReader.GetInt32(3);

                personas.Add(nuevaPersona);
            }

            return personas;
        }

        public static List<Persona> Buscar(int edad)
        {
            List<Persona> personas = new List<Persona>();
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM persona WHERE edad >= '" + edad + "';";
            command.Connection = Connection();

            MySqlDataReader personasReader = command.ExecuteReader();

            while (personasReader.Read())
            {
                Persona nuevaPersona = new Persona();
                nuevaPersona.id = personasReader.GetInt32(0);
                nuevaPersona.nombre = personasReader.GetString(1);
                nuevaPersona.apellido = personasReader.GetString(2);
                nuevaPersona.edad = personasReader.GetInt32(3);

                personas.Add(nuevaPersona);
            }

            return personas;
        }

        public static int Eliminar(string nombre, string apellido, int edad)
        {
            int res = 0;
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "DELETE FROM persona WHERE nombre='" + nombre + "' AND apellido='" + apellido +
                                  "' AND edad=" + edad + ";";
            command.Connection = Connection();

            res = command.ExecuteNonQuery();

            return res;
        }
    }

    class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
    }
}
