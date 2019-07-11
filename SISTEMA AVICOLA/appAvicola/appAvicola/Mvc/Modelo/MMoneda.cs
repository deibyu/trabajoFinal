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
    class MMoneda:IMoneda
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;    

        public List<Moneda> Sp_listar_monedaxestado()
        {
            List<Moneda> lista_moneda = null;
            Moneda moneda = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_monedaxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_moneda = new List<Moneda>();

                        while (dr.Read())
                        {
                            moneda = new Moneda()
                            {
                                Idmoneda = (int)dr["idmoneda"],
                                Nombre = (string)dr["nombre"],
                                Sigla = (string)dr["sigla"],
                                Estado = (int)dr["estado"]
                            };

                            lista_moneda.Add(moneda);
                        }

                    }
                    dr.Close();
                }
                return lista_moneda;
            }
            catch (MySqlException ex)
            {
                return lista_moneda;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}

