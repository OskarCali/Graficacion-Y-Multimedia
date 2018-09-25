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

        public static int agregar(Persona persona)
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
    }

    class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
    }
}
