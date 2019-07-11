using appAvicola.Mvc.Clases;
using appAvicola.Mvc.Modelo.Bd;
using appAvicola.Mvc.Modelo.Interfaz;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo
{
    class MTipoUnidad:ITipoUnidad
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;

        public List<TipoUnidad> Sp_listar_tipounidadxestado()
        {
            List<TipoUnidad> lista_tipounidad = null;
            TipoUnidad tipounidad = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_tipounidadxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipounidad = new List<TipoUnidad>();

                        while (dr.Read())
                        {
                            tipounidad = new TipoUnidad()
                            {
                                Idtipounidad = (int)dr["idtipounidad"],
                                Nombre = (string)dr["nombre"],                              
                                Estado = (int)dr["estado"]
                            };

                            lista_tipounidad.Add(tipounidad);
                        }

                    }
                    dr.Close();
                }
                return lista_tipounidad;
            }
            catch (MySqlException ex)
            {
                return lista_tipounidad;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
