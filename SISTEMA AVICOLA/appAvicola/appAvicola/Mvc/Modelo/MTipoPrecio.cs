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
    class MTipoPrecio:ITipoPrecio
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;

        public List<TipoPrecio> Sp_listar_tipoprecioxestado()
        {
            List<TipoPrecio> lista_tipoprecio = null;
            TipoPrecio tipoprecio = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_tipoprecioxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipoprecio = new List<TipoPrecio>();

                        while (dr.Read())
                        {
                            tipoprecio = new TipoPrecio()
                            {
                                Idtipoprecio= (int)dr["idtipoprecio"],
                                Nombre = (string)dr["nombre"],                               
                                Estado = (int)dr["estado"]
                            };

                            lista_tipoprecio.Add(tipoprecio);
                        }

                    }
                    dr.Close();
                }
                return lista_tipoprecio;
            }
            catch (MySqlException ex)
            {
                return lista_tipoprecio;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
