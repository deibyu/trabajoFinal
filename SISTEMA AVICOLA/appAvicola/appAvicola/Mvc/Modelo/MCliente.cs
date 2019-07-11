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
    class MCliente:ICliente
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_cliente(Cliente cliente, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_cliente", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_razonsocial", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipodocumento", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_documento", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));          
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = cliente.Idcliente;
                    cmd.Parameters[1].Value = cliente.Razonsocial;
                    cmd.Parameters[2].Value = cliente.Tipodocumento.Idtipodocumento;
                    cmd.Parameters[3].Value = cliente.Documento;
                    cmd.Parameters[4].Value = cliente.Direccion;              
                    cmd.Parameters[5].Value = cliente.Estado;
                    cmd.Parameters[6].Value = sesion.Usuario.Idusuario;

                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            filas_afectadas = Convert.ToInt32(dr["_filas_afectadas"]);
                        }

                    }
                    dr.Close();
                    tra.Commit();
                    tra.Dispose();
                }
                return filas_afectadas;
            }
            catch (MySqlException ex)
            {
                filas_afectadas = -1;
                tra.Rollback();
                tra.Dispose();
                return filas_afectadas;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_cliente()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_cliente", con)
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

        public List<Cliente> Sp_listar_clientexestado()
        {
            List<Cliente> lista_cliente= null;
            Cliente cliente = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_clientexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_cliente = new List<Cliente>();

                        while (dr.Read())
                        {
                            cliente = new Cliente()
                            {
                                Idcliente = (int)dr["idcliente"],
                                Tipodocumento = new TipoDocumento()
                                {
                                    Idtipodocumento = (int)dr["idtipodocumento"],
                                    Sigla = (string)dr["sigla"]
                                },
                                Razonsocial = (string)dr["razonsocial"],
                                Documento = (string)dr["documento"],
                                Direccion = (string)dr["direccion"],                         
                                Estado = (int)dr["estado"]
                            };

                            lista_cliente.Add(cliente);

                        }

                    }
                    dr.Close();
                }
                return lista_cliente;
            }
            catch (MySqlException ex)
            {
                return lista_cliente;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }

        }

        public DataTable Sp_listar_clientexrazonsocial(string razonsocial)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_clientexrazonsocial", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_razonsocial", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = razonsocial;

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

        public int Sp_registrar_cliente(Cliente cliente, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_cliente", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_razonsocial", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipodocumento", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_documento", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                                        
                    cmd.Parameters[0].Value = cliente.Razonsocial;
                    cmd.Parameters[1].Value = cliente.Tipodocumento.Idtipodocumento;
                    cmd.Parameters[2].Value = cliente.Documento;
                    cmd.Parameters[3].Value = cliente.Direccion;
                    cmd.Parameters[4].Value = sesion.Usuario.Idusuario;

                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            id = Convert.ToInt32(dr["_id"]);
                        }

                    }
                    dr.Close();
                    tra.Commit();
                    tra.Dispose();
                }
                return id;
            }
            catch (MySqlException ex)
            {
                id = -1;
                tra.Rollback();
                tra.Dispose();
                return id;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }
    }
}
