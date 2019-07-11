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
    class MTipoDocumento:ITipoDocumento
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;

        public List<TipoDocumento> Sp_listar_tipodocumento()
        {
            List<TipoDocumento> lista_tipodocumento = null;
            TipoDocumento tipodocumento = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_tipodocumento", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipodocumento = new List<TipoDocumento>();

                        while (dr.Read())
                        {
                            tipodocumento = new TipoDocumento()
                            {
                                Idtipodocumento = (int)dr["idtipodocumento"],                              
                                Nombre = (string)dr["nombre"],
                                Sigla = (string)dr["sigla"],
                                Longitud = (int)dr["longitud"],
                                Estado = (int)dr["estado"]
                            };

                            lista_tipodocumento.Add(tipodocumento);
                        }

                    }
                    dr.Close();
                }
                return lista_tipodocumento;
            }
            catch (MySqlException ex)
            {
                return lista_tipodocumento;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
