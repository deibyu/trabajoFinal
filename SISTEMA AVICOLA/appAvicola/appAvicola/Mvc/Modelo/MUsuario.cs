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
    class MUsuario : IUsuario
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_usuario(Usuario usuario, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_usuario", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipousuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_cuenta", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_clave", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusu", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = usuario.Idusuario;
                    cmd.Parameters[1].Value = usuario.Tipousuario.Idtipousuario;
                    cmd.Parameters[2].Value = usuario.Nombreyapellido;
                    cmd.Parameters[3].Value = usuario.Cuenta;
                    cmd.Parameters[4].Value = usuario.Clave;
                    cmd.Parameters[5].Value = usuario.Estado;
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

        public int Sp_actualizar_usuarioalmacen(int idusuarioalmacen, Almacen almacen, Usuario usuario, int estado, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_usuarioalmacen", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idusuarioalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuarioenalmacen", MySqlDbType.Int32));   
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = idusuarioalmacen;
                    cmd.Parameters[1].Value = almacen.Idalmacen;
                    cmd.Parameters[2].Value = usuario.Idusuario;         
                    cmd.Parameters[3].Value = estado;
                    cmd.Parameters[4].Value = sesion.Usuario.Idusuario;

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

        public DataTable Sp_listar_usuario()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_usuario", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(tabla);
                }

                return tabla;
            }
            catch (Exception ex) {

                return tabla;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_usuarioalmacen()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_usuarioalmacen", con)
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

        public Usuario Sp_listar_usuarioxcuentaxclave(Almacen almacen, Usuario usuario)
        {    
            Usuario usu = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_usuarioxcuentaxclave", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_cuenta", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_clave", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = almacen.Idalmacen;
                    cmd.Parameters[1].Value = usuario.Cuenta;
                    cmd.Parameters[2].Value = usuario.Clave;

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {                       

                        while (dr.Read())
                        {
                            usu = new Usuario()
                            {
                                Idusuario = (int)dr["idusuario"],
                                Tipousuario=new TipoUsuario() {

                                    Idtipousuario = (int)dr["idtipousuario"],
                                    Nombre=(string)dr["tunombre"]
                                },
                                Nombreyapellido=(string)dr["nombreyapellido"],
                                Cuenta = (string)dr["cuenta"],
                                Clave = (string)dr["clave"],
                                Estado = (int)dr["estado"]
                            };                          
                        }

                    }
                    dr.Close();
                }
                return usu;
            }
            catch (MySqlException ex)
            {
                return usu;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_usuarioxnombreyapellido(string nombreyapellido)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_usuarioxnombreyapellido", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = nombreyapellido;
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

        public int Sp_registrar_usuario(Usuario usuario, Sesion sesion)
        {
            int id = -1;

            try
            {
                con=conn.Conectar();

                if (con != null) {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_usuario", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idtipousuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_cuenta", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_clave", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));           

                    cmd.Parameters[0].Value = usuario.Tipousuario.Idtipousuario;
                    cmd.Parameters[1].Value = usuario.Nombreyapellido;
                    cmd.Parameters[2].Value = usuario.Cuenta;
                    cmd.Parameters[3].Value = usuario.Clave;      
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
            finally {cmd.Dispose(); conn.Desconectar(con); }
        }

        public int Sp_registrar_usuarioalmacen(Almacen almacen, Usuario usuario, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_usuarioalmacen", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuarioenalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = almacen.Idalmacen;
                    cmd.Parameters[1].Value = usuario.Idusuario;           
                    cmd.Parameters[2].Value = sesion.Usuario.Idusuario;

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
