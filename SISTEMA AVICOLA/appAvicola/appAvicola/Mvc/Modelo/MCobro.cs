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
    class MCobro : ICobro
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_anular_cobro(int ideuda, int idcobro, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_anular_cobro", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_iddeuda", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idcobro", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = ideuda;
                    cmd.Parameters[1].Value = idcobro;
                    cmd.Parameters[2].Value = sesion.Usuario.Idusuario;

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

        public DataTable Sp_listar_cobroxfechaxestado(DateTime fechainicio, DateTime fechafin, int estado)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_cobroxfechaxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };                    
                    cmd.Parameters.Add(new MySqlParameter("@_fechainicio", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_fechafin", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));                    
                    cmd.Parameters[0].Value = fechainicio;
                    cmd.Parameters[1].Value = fechafin;
                    cmd.Parameters[2].Value = estado;
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

        public Cobro Sp_listar_cobroxidcobro(int idcobro)
        {

            Cobro cobro = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_cobroxidcobro", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idcobro", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idcobro;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            cobro = new Cobro()
                            {
                                Idcobro = (int)dr["idcobro"],
                                Deuda = new Deuda()
                                {

                                    Iddeuda = (int)dr["iddeuda"],
                                },
                                Fechacobro = (DateTime)dr["fechacobro"],
                                Tipocobro = new TipoCobro()
                                {
                                    Idtipocobro = (int)dr["idtipocobro"]
                                },
                                Moneda = new Moneda()
                                {
                                    Idmoneda = (int)dr["idmoneda"]
                                },
                                Cuentabancaria = (string)dr["cuentabancaria"],
                                Noperacion = (string)dr["noperacion"],
                                Monto = (decimal)dr["monto"],
                                Observacion = (string)dr["observacion"],
                                Estado = (int)dr["estado"]
                            };
                        }

                    }
                    dr.Close();
                }
                return cobro;
            }
            catch (MySqlException ex)
            {
                return cobro;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_cobroxiddeudaxfechaxestado(int ideuda, DateTime fechainicio, DateTime fechafin, int estado)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_cobroxiddeudaxfechaxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_iddeuda", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_fechainicio", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_fechafin", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = ideuda;
                    cmd.Parameters[1].Value = fechainicio;
                    cmd.Parameters[2].Value = fechafin;
                    cmd.Parameters[3].Value = estado;
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

        public int Sp_registrar_cobro(Cobro cobro, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_cobro", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_iddeuda", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_fechacobro", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipocobro", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_cuentabancaria", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_noperacion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_monto", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_observacion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = cobro.Deuda.Iddeuda;
                    cmd.Parameters[1].Value = cobro.Fechacobro;
                    cmd.Parameters[2].Value = cobro.Tipocobro.Idtipocobro;
                    cmd.Parameters[3].Value = cobro.Cuentabancaria;
                    cmd.Parameters[4].Value = cobro.Noperacion;
                    cmd.Parameters[5].Value = cobro.Monto;
                    cmd.Parameters[6].Value = cobro.Observacion;
                    cmd.Parameters[7].Value = sesion.Usuario.Idusuario;

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
