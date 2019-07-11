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
    class MDeuda:IDeuda
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public Deuda Sp_listar_deudaxidclientexestado(int idcliente)
        {
            Deuda deuda = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_deudaxidclientexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idcliente;                 

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            deuda = new Deuda()
                            {
                                Iddeuda = (int)dr["iddeuda"],
                                Cliente=new Cliente {
                                    Idcliente=(int)dr["idcliente"]
                                },
                                Montoinicial = (decimal)dr["montoinicial"],
                                Montototal = (decimal)dr["montototal"],
                                Montocobrado = (decimal)dr["montocobrado"],
                                Montoactual=(decimal)dr["montoactual"],
                                Estado = (int)dr["estado"]
                            };
                        }

                    }
                    dr.Close();
                }
                return deuda;
            }
            catch (MySqlException ex)
            {
                return deuda;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_deudaxidclientexestado_(int idcliente)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_deudaxidclientexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idcliente;
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

        public Deuda Sp_listar_deudaxiddeudaxestado(int iddeuda)
        {
            Deuda deuda = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_deudaxiddeudaxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_iddeuda", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = iddeuda;

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            deuda = new Deuda()
                            {
                                Iddeuda = (int)dr["iddeuda"],
                                Cliente = new Cliente
                                {
                                    Idcliente = (int)dr["idcliente"]
                                },
                                Montoinicial = (decimal)dr["montoinicial"],
                                Montototal = (decimal)dr["montototal"],
                                Montocobrado = (decimal)dr["montocobrado"],
                                Montoactual = (decimal)dr["montoactual"],
                                Estado = (int)dr["estado"]
                            };
                        }

                    }
                    dr.Close();
                }
                return deuda;
            }
            catch (MySqlException ex)
            {
                return deuda;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
