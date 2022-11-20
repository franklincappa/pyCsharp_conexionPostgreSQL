using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionPostgreSQL.Clases
{
    class Conexion
    {
        NpgsqlConnection conex = new NpgsqlConnection();
        static String servidor= "localhost";
        static String database= "db_DemoAPI";
        static String usuario= "postgres";
        static String password= "Red#FSCT$90";
        static String puerto= "5432";

        String cadenaConexion = "server=" + servidor + "; " +
            "port=" + puerto + ";" +
            "user id=" + usuario + ";" +
            "password=" + password + ";" +
            "database=" + database + ";";
        public NpgsqlConnection establecerConexion()
        {
            try {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Conexión Establecida");
            }
            catch (NpgsqlException e) {
                MessageBox.Show("No se pudo establecer la conexión con la base de datos PostgreSQL, Error:  "+e.ToString());
            }
            return conex;
        }

    }
}
