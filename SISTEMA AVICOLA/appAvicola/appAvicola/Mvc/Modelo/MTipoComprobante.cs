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
    class MTipoComprobante:ITipoComprobante
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private DataTable tabla = null;
        public DataTable Sp_listar_tipocomprobante()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_tipocomprobante", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(tabla);
                }

                return tabla;
            }
            catch (Exception ex)
            {

                return tabla;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public List<TipoComprobante> Sp_listar_tipocomprobantexestado()
        {
            List<TipoComprobante> lista_tipocomprobante = null;
            TipoComprobante tipocomprobante = null;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_tipocomprobantexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };                 
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipocomprobante = new List<TipoComprobante>();

                        while (dr.Read())
                        {
                            tipocomprobante = new TipoComprobante()
                            {
                                Idtipocomprobante = (int)dr["idtipocomprobante"],                                
                                Nombre = (string)dr["nombre"],
                                Sigla = (string)dr["sigla"],                          
                                Estado = (int)dr["estado"]
                            };

                            lista_tipocomprobante.Add(tipocomprobante);
                        }

                    }
                    dr.Close();
                }
                return lista_tipocomprobante;
            }
            catch (MySqlException ex)
            {
                return lista_tipocomprobante;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
