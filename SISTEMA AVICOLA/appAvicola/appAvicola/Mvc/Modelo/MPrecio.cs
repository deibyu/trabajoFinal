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
    class MPrecio:IPrecio
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_precio(Precio precio, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_precio", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idprecio", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipoprecio", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idmoneda", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_precio", MySqlDbType.Decimal));         
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = precio.Idprecio;
                    cmd.Parameters[1].Value = precio.Tipoprecio.Idtipoprecio;
                    cmd.Parameters[2].Value = precio.Moneda.Idmoneda;
                    cmd.Parameters[3].Value = precio.Valor;
                    cmd.Parameters[4].Value = precio.Estado; 
                    cmd.Parameters[5].Value = sesion.Usuario.Idusuario;

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

        public DataTable Sp_listar_precioxidunidadequivalente(int idunidadequivalente)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_precioxidunidadequivalente", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadequivalente", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idunidadequivalente;
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

        public List<Precio> Sp_listar_precioxidunidadequivalentexestado(int idunidadequivalente)
        {
            List<Precio> lista_precio = null;
            Precio precio = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_precioxidunidadequivalentexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadequivalente", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idunidadequivalente;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_precio = new List<Precio>();

                        while (dr.Read())
                        {
                            precio = new Precio()
                            {
                                Idprecio = (int)dr["idprecio"],
                                Unidadequivalente=new UnidadEquivalente() {
                                    Idunidadequivalente=(int)dr["idunidadequivalente"]
                                },
                                Tipoprecio=new TipoPrecio() {
                                    Idtipoprecio = (int)dr["idtipoprecio"],
                                    Nombre = (string)dr["tpnombre"]
                                },
                                Moneda=new Moneda() {
                                    Idmoneda=(int)dr["idmoneda"],
                                    Sigla=(string)dr["sigla"]
                                },
                                Valor=(decimal)dr["precio"],                          
                                Estado = (int)dr["estado"]
                            };

                            lista_precio.Add(precio);
                        }

                    }
                    dr.Close();
                }
                return lista_precio;
            }
            catch (MySqlException ex)
            {
                return lista_precio;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public int Sp_registrar_precio(Precio precio, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_precio", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idunidadequivalente", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipoprecio", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idmoneda", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_precio", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = precio.Unidadequivalente.Idunidadequivalente;
                    cmd.Parameters[1].Value = precio.Tipoprecio.Idtipoprecio;
                    cmd.Parameters[2].Value = precio.Moneda.Idmoneda;
                    cmd.Parameters[3].Value = precio.Valor;
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
