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
    class MSucursal:ISucursal
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_sucursal(Sucursal sucursal, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_sucursal", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idsucursal", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idempresa", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_razonsocial", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_sede", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = sucursal.Idsucursal;
                    cmd.Parameters[1].Value = sucursal.Empresa.Idempresa;
                    cmd.Parameters[2].Value = sucursal.Razonsocial;
                    cmd.Parameters[3].Value = sucursal.Direccion;
                    cmd.Parameters[4].Value = sucursal.Sede;
                    cmd.Parameters[5].Value = sucursal.Telefono;
                    cmd.Parameters[6].Value = sucursal.Estado;
                    cmd.Parameters[7].Value = sesion.Usuario.Idusuario;

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

        public DataTable Sp_listar_sucursal()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_sucursal", con)
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

        public List<Sucursal> Sp_listar_sucursalxidempresa(int idempresa)
        {
            List<Sucursal> lista_sucursal = null;
            Sucursal sucursal = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_sucursalxidempresa", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idempresa", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = idempresa;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_sucursal = new List<Sucursal>();

                        while (dr.Read())
                        {
                            sucursal = new Sucursal()
                            {
                                Idsucursal = (int)dr["idsucursal"],
                                Empresa = new Empresa()
                                {
                                    Idempresa = (int)dr["idempresa"]                                    
                                },
                                Razonsocial = (string)dr["razonsocial"],
                                Direccion = (string)dr["direccion"],
                                Sede = (string)dr["sede"],
                                Telefono=(string)dr["telefono"],
                                Estado = (int)dr["estado"]
                            };

                            lista_sucursal.Add(sucursal);
                        }

                    }
                    dr.Close();
                }
                return lista_sucursal;
            }
            catch (MySqlException ex)
            {
                return lista_sucursal;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_sucursalxrazonsocial(string razonsocial)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_sucursalxrazonsocial", con)
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

        public int Sp_registrar_sucursal(Sucursal sucursal, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_sucursal", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idempresa", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_razonsocial", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_sede", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));                    
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = sucursal.Empresa.Idempresa;
                    cmd.Parameters[1].Value = sucursal.Razonsocial;
                    cmd.Parameters[2].Value = sucursal.Direccion;
                    cmd.Parameters[3].Value = sucursal.Sede;
                    cmd.Parameters[4].Value = sucursal.Telefono;                    
                    cmd.Parameters[5].Value = sesion.Usuario.Idusuario;

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
