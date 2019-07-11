using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Bd
{
    public class Conexion
    {
        
        public static String cadenaconexion = ConfigurationManager.ConnectionStrings["AVICOLA"].ConnectionString;

        public MySqlConnection Conectar()
        {
            MySqlConnection conector = null;
            try
            {
                conector = new MySqlConnection(cadenaconexion);
                conector.Open();
                return conector;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MySqlConnection Desconectar(MySqlConnection conector)
        {
            conector.Dispose();
            conector.Close();
            return conector;
        }
    }
}
