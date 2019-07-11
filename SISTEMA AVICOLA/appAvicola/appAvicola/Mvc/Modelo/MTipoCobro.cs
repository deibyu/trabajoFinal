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
    class MTipoCobro:ITipoCobro
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;

        public List<TipoCobro> Sp_listar_tipocobroxestado()
        {
            List<TipoCobro> lista_tipocobro = null;
            TipoCobro tipocobro = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_tipocobroxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipocobro = new List<TipoCobro>();

                        while (dr.Read())
                        {
                            tipocobro = new TipoCobro()
                            {
                                Idtipocobro = (int)dr["idtipocobro"],
                                Nombre = (string)dr["nombre"],
                                Sigla = (string)dr["sigla"],
                                Estado = (int)dr["estado"]
                            };

                            lista_tipocobro.Add(tipocobro);
                        }

                    }
                    dr.Close();
                }
                return lista_tipocobro;
            }
            catch (MySqlException ex)
            {
                return lista_tipocobro;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
