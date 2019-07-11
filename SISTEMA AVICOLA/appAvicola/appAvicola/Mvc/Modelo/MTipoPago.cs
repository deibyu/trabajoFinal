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
    class MTipoPago:ITipoPago
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;

        public List<TipoPago> Sp_listar_tipopagoxestado()
        {
            List<TipoPago> lista_tipopago = null;
            TipoPago tipopago = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_tipopagoxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipopago = new List<TipoPago>();

                        while (dr.Read())
                        {
                            tipopago = new TipoPago()
                            {
                                Idtipopago = (int)dr["idtipopago"],
                                Nombre = (string)dr["nombre"],
                                Ndia=(int)dr["ndia"],
                                Estado = (int)dr["estado"]
                            };

                            lista_tipopago.Add(tipopago);
                        }

                    }
                    dr.Close();
                }
                return lista_tipopago;
            }
            catch (MySqlException ex)
            {
                return lista_tipopago;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
