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
    class MEmpresa:IEmpresa
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_empresa(Empresa empresa, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_empresa", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idempresa", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipodocumento", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_razonsocial", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_ruc", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = empresa.Idempresa;
                    cmd.Parameters[1].Value = empresa.Tipodocumento.Idtipodocumento;
                    cmd.Parameters[2].Value = empresa.Razonsocial;
                    cmd.Parameters[3].Value = empresa.Ruc;
                    cmd.Parameters[4].Value = empresa.Direccion;
                    cmd.Parameters[5].Value = empresa.Telefono;
                    cmd.Parameters[6].Value = empresa.Estado;
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

        public DataTable Sp_listar_empresa()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_empresa", con)
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

        public List<Empresa> Sp_listar_empresaxestado()
        {
            List<Empresa> lista_empresa = null;
            Empresa empresa = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_empresaxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };                      
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_empresa = new List<Empresa>();                        

                        while (dr.Read())
                        {
                            empresa = new Empresa()
                            {
                                Idempresa = (int)dr["idempresa"],
                                Tipodocumento = new TipoDocumento()
                                {
                                    Idtipodocumento = (int)dr["idtipodocumento"],
                                    Sigla = (string)dr["sigla"]
                                },
                                Razonsocial = (string)dr["razonsocial"],
                                Ruc = (string)dr["ruc"],
                                Direccion = (string)dr["direccion"],
                                Telefono = (string)dr["telefono"],
                                Estado = (int)dr["estado"]
                            };

                            lista_empresa.Add(empresa);

                        }

                    }
                    dr.Close();
                }
                return lista_empresa;
            }
            catch (MySqlException ex)
            {
                return lista_empresa;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
            
        }

        public Empresa Sp_listar_empresaxnumeroruc(string ruc)
        {        
            Empresa empresa = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_empresaxnumeroruc", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_ruc", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = ruc;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        empresa = new Empresa();

                        while (dr.Read())
                        {
                            empresa = new Empresa()
                            {
                                Idempresa = (int)dr["idempresa"],
                                Tipodocumento=new TipoDocumento() {
                                    Idtipodocumento=(int)dr["idtipodocumento"],
                                    Sigla=(string)dr["sigla"]
                                },
                                Razonsocial = (string)dr["razonsocial"],
                                Ruc=(string)dr["ruc"],
                                Direccion = (string)dr["direccion"],
                                Telefono = (string)dr["telefono"],
                                Estado = (int)dr["estado"]
                            };
                          
                        }

                    }
                    dr.Close();
                }
                return empresa;
            }
            catch (MySqlException ex)
            {
                return empresa;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_empresaxrazonsocial(string razonsocial)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_empresaxrazonsocial", con)
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

        public DataTable Sp_listar_empresaxruc(string ruc)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_empresaxruc", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_ruc", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = ruc;

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

        public int Sp_registrar_empresa(Empresa empresa, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_empresa", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };
                    
                    cmd.Parameters.Add(new MySqlParameter("@_idtipodocumento", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_razonsocial", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_ruc", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));                    
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    
                    cmd.Parameters[0].Value = empresa.Tipodocumento.Idtipodocumento;
                    cmd.Parameters[1].Value = empresa.Razonsocial;
                    cmd.Parameters[2].Value = empresa.Ruc;
                    cmd.Parameters[3].Value = empresa.Direccion;
                    cmd.Parameters[4].Value = empresa.Telefono;                    
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
