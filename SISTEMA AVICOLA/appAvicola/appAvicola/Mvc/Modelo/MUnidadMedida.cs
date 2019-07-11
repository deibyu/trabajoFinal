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
    class MUnidadMedida:IUnidadMedida
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_unidadmedida(UnidadMedida unidad, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_unidadmedida", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idunidadmedida", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_sigla", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = unidad.Idunidadmedida;
                    cmd.Parameters[1].Value = unidad.Nombre;
                    cmd.Parameters[2].Value = unidad.Sigla;
                    cmd.Parameters[3].Value = unidad.Estado;
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

        public DataTable Sp_listar_unidadmedida()
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_unidadmedida", con)
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

        public List<UnidadMedida> Sp_listar_unidadmedidaxestado()
        {
            List<UnidadMedida> lista_unidadmedida = null;
            UnidadMedida unidad = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_unidadmedidaxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
               
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_unidadmedida = new List<UnidadMedida>();

                        while (dr.Read())
                        {
                            unidad = new UnidadMedida()
                            {
                                Idunidadmedida = (int)dr["idunidadmedida"],                               
                                Nombre = (string)dr["nombre"],
                                Sigla = (string)dr["sigla"],                           
                                Estado = (int)dr["estado"]
                            };

                            lista_unidadmedida.Add(unidad);
                        }

                    }
                    dr.Close();
                }
                return lista_unidadmedida;
            }
            catch (MySqlException ex)
            {
                return lista_unidadmedida;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_unidadmedidaxnombre(string nombre)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_unidadmedidaxnombre", con)
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

        public int Sp_registrar_unidadmedida(UnidadMedida unidad, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_unidadmedida", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_sigla", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = unidad.Nombre;
                    cmd.Parameters[1].Value = unidad.Sigla;
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
            finally
            {
                cmd.Dispose(); conn.Desconectar(con);
            }
        }
    }
}
