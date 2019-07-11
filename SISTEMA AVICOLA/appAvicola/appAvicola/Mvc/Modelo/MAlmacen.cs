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
    class MAlmacen:IAlmacen
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_almacen(Almacen almacen, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_almacen", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idsucursal", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));                    
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = almacen.Idalmacen;
                    cmd.Parameters[1].Value = almacen.Sucursal.Idsucursal;
                    cmd.Parameters[2].Value = almacen.Nombre;
                    cmd.Parameters[3].Value = almacen.Direccion;
                    cmd.Parameters[4].Value = almacen.Telefono;                    
                    cmd.Parameters[5].Value = almacen.Estado;
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

        public DataTable Sp_listar_almacen()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_almacen", con)
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

        public List<Almacen> Sp_listar_almacenxestado()
        {
            List<Almacen> lista_almacen = null;
            Almacen almacen = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_almacenxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };         
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_almacen = new List<Almacen>();

                        while (dr.Read())
                        {
                            almacen = new Almacen()
                            {
                                Idalmacen = (int)dr["idalmacen"],
                                Sucursal = new Sucursal()
                                {
                                    Idsucursal = (int)dr["idsucursal"]
                                },
                                Nombre = (string)dr["nombre"],
                                Direccion = (string)dr["direccion"],
                                Telefono = (string)dr["telefono"],
                                Estado = (int)dr["estado"]
                            };

                            lista_almacen.Add(almacen);
                        }

                    }
                    dr.Close();
                }
                return lista_almacen;
            }
            catch (MySqlException ex)
            {
                return lista_almacen;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public List<Almacen> Sp_listar_almacenxidsucursal(int idsucursal)
        {
            List<Almacen> lista_almacen = null;
            Almacen almacen = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_almacenxidsucursal", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idsucursal", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idsucursal;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_almacen = new List<Almacen>();

                        while (dr.Read())
                        {
                            almacen = new Almacen()
                            {
                                Idalmacen = (int)dr["idalmacen"],
                                Sucursal = new Sucursal()
                                {
                                    Idsucursal = (int)dr["idsucursal"]
                                },
                                Nombre = (string)dr["nombre"],
                                Direccion = (string)dr["direccion"],                              
                                Telefono = (string)dr["telefono"],
                                Estado = (int)dr["estado"]
                            };

                            lista_almacen.Add(almacen);
                        }

                    }
                    dr.Close();
                }
                return lista_almacen;
            }
            catch (MySqlException ex)
            {
                return lista_almacen;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_almacenxnombre(string nombre)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_almacenxnombre", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = nombre;

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

        public int Sp_registrar_almacen(Almacen almacen, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_almacen", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idsucursal", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));               
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = almacen.Sucursal.Idsucursal;
                    cmd.Parameters[1].Value = almacen.Nombre;
                    cmd.Parameters[2].Value = almacen.Direccion;                    
                    cmd.Parameters[3].Value = almacen.Telefono;                    
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
