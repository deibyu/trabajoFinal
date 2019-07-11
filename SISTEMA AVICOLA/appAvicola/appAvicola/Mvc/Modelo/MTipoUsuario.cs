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
    class MTipoUsuario:ITipoUsuario
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        
        public List<TipoUsuario> Sp_listar_tipousuarioxestado()
        {
            List<TipoUsuario> lista_tipousuario = null;
            TipoUsuario tipousuario = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_tipousuarioxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipousuario = new List<TipoUsuario>();

                        while (dr.Read())
                        {
                            tipousuario = new TipoUsuario()
                            {
                                Idtipousuario = (int)dr["idtipousuario"],
                                Nombre = (string)dr["nombre"],
                                Sigla = (string)dr["sigla"],                               
                                Estado = (int)dr["estado"]
                            };

                            lista_tipousuario.Add(tipousuario);
                        }

                    }
                    dr.Close();
                }
                return lista_tipousuario;
            }
            catch (MySqlException ex)
            {
                return lista_tipousuario;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
