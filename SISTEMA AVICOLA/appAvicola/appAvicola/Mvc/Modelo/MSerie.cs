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
    class MSerie:ISerie
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_serie(Serie serie, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_serie", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idserie", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipocomprobante", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nserie", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_ncorrelativo", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = serie.Idserie;
                    cmd.Parameters[1].Value = serie.Almacen.Idalmacen;
                    cmd.Parameters[2].Value = serie.Tipocomprobante.Idtipocomprobante;
                    cmd.Parameters[3].Value = serie.Nserie;
                    cmd.Parameters[4].Value = serie.Ncorrelativo;
                    cmd.Parameters[5].Value = serie.Estado;
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

        public DataTable Sp_listar_seriexidalmacenxidtipocomprobante(int idalmacen, int idtipocomprobante)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_seriexidalmacenxidtipocomprobante", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipocomprobante", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idalmacen;
                    cmd.Parameters[1].Value = idtipocomprobante;
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

        public List<Serie> Sp_listar_seriexidalmacenxidtipocomprobantexestado(int idalmacen, int idtipocomprobante)
        {
            List<Serie> lista_serie = null;
            Serie serie = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_seriexidalmacenxidtipocomprobantexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipocomprobante", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idalmacen;
                    cmd.Parameters[1].Value = idtipocomprobante;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_serie = new List<Serie>();

                        while (dr.Read())
                        {
                            serie = new Serie()
                            {
                                Idserie = (int)dr["idserie"],
                                Almacen=new Almacen() {
                                    Idalmacen=(int)dr["idalmacen"],
                                    Nombre=(string)dr["anombre"],
                                },
                                Tipocomprobante=new TipoComprobante() {
                                    Idtipocomprobante=(int)dr["idtipocomprobante"],
                                    Sigla=(string)dr["tcsigla"]
                                },
                                Nserie = (string)dr["nserie"],
                                Ncorrelativo = (int)dr["ncorrelativo"],                          
                                Estado = (int)dr["estado"]
                            };

                            lista_serie.Add(serie);
                        }

                    }
                    dr.Close();
                }
                return lista_serie;
            }
            catch (MySqlException ex)
            {
                return lista_serie;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public int Sp_registrar_serie(Serie serie, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_serie", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipocomprobante", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nserie", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_ncorrelativo", MySqlDbType.Int32));                    
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = serie.Almacen.Idalmacen;
                    cmd.Parameters[1].Value = serie.Tipocomprobante.Idtipocomprobante;
                    cmd.Parameters[2].Value = serie.Nserie;
                    cmd.Parameters[3].Value = serie.Ncorrelativo;                    
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
