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
    class MUnidadEquivalente: IUnidadEquivalente
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_unidadequivalente(UnidadEquivalente unidad, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_unidadequivalente", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idunidadequivalente", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipounidad", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadmedida", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_equivale", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadbase", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = unidad.Idunidadequivalente;
                    cmd.Parameters[1].Value = unidad.Tipounidad.Idtipounidad;
                    cmd.Parameters[2].Value = unidad.Unidadmedida.Idunidadmedida;
                    cmd.Parameters[3].Value = unidad.Equivale;
                    cmd.Parameters[4].Value = unidad.Unidadbase.Idunidadmedida;
                    cmd.Parameters[5].Value = unidad.Estado;
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

        public DataTable Sp_listar_unidadequivalentexproducto(int idproducto)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_unidadequivalentexproducto", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idproducto", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idproducto;
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

        public List<UnidadEquivalente> Sp_listar_unidadequivalentexproductoxestado(int idproducto)
        {
            List<UnidadEquivalente> lista_unidadequivalente = null;
            UnidadEquivalente unidadequivalente = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_unidadequivalentexproductoxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idproducto", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idproducto;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_unidadequivalente = new List<UnidadEquivalente>();

                        while (dr.Read())
                        {
                            unidadequivalente = new UnidadEquivalente()
                            {
                                Idunidadequivalente = (int)dr["idunidadequivalente"],
                                Producto=new Producto() {
                                    Idproducto=(int)dr["idproducto"]
                                },
                                Tipounidad=new TipoUnidad() {
                                    Idtipounidad=(int)dr["idtipounidad"],
                                    Nombre=(string)dr["tunombre"]
                                },
                                Unidadmedida=new UnidadMedida() {
                                    Idunidadmedida=(int)dr["idunidadmedida"],
                                    Sigla=(string)dr["unisigla"]
                                },
                                Equivale=(decimal)dr["equivale"],
                                Unidadbase=new UnidadMedida()
                                {
                                    Idunidadmedida=(int)dr["idunidadbase"],
                                    Sigla=(string)dr["basesigla"]
                                },                               
                                Estado = (int)dr["estado"]
                            };

                            lista_unidadequivalente.Add(unidadequivalente);
                        }

                    }
                    dr.Close();
                }
                return lista_unidadequivalente;
            }
            catch (MySqlException ex)
            {
                return lista_unidadequivalente;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public int Sp_registrar_unidadequivalente(UnidadEquivalente unidad, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_unidadequivalente", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idproducto", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipounidad", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadmedida", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_equivale", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadbase", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = unidad.Producto.Idproducto;
                    cmd.Parameters[1].Value = unidad.Tipounidad.Idtipounidad;
                    cmd.Parameters[2].Value = unidad.Unidadmedida.Idunidadmedida;
                    cmd.Parameters[3].Value = unidad.Equivale;
                    cmd.Parameters[4].Value = unidad.Unidadbase.Idunidadmedida;
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
            finally
            {
                cmd.Dispose(); conn.Desconectar(con);
            }
        }
    }
}
