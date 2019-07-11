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
    class MComprobante : IComprobante
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;
        private DataSet data = null;

        public int Sp_anular_comprobantexidcomprobante(int idcomprobante, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_anular_comprobantexidcomprobante", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));                 
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = idcomprobante;         
                    cmd.Parameters[1].Value = sesion.Usuario.Idusuario;

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

        public DataSet Sp_imprimir_comprobante(int idcomprobante,int ocultar)
        {
            try
            {
                con = conn.Conectar();
                data = null;

                if (con != null)
                {
                    data = new DataSet();                  
                    cmd = new MySqlCommand("Sp_imprimir_comprobante", con)
                    {
                        CommandType = CommandType.StoredProcedure,                        
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_ocultar", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idcomprobante;
                    cmd.Parameters[1].Value = ocultar;
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(data, "comprobante");
                    data.WriteXml(AppDomain.CurrentDomain.BaseDirectory+"\\rpt\\comprobante.xml", XmlWriteMode.WriteSchema);                    
                    adap.Dispose();
                    data.Dispose();
                }
                return data;
            }
            catch (MySqlException ex)
            {               
                return data;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public DataTable Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado(int idalmacen, DateTime fechainicio, DateTime fechafin, string ncomprobante, int estado)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idalmacen", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_fechainicio", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_fechafin", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_ncomprobante", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idalmacen;
                    cmd.Parameters[1].Value = fechainicio;
                    cmd.Parameters[2].Value = fechafin;
                    cmd.Parameters[3].Value = ncomprobante;
                    cmd.Parameters[4].Value = estado;

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

        public DataTable Sp_listar_comprobantexidclientexfechaxncomprobantexestado(int idcliente, DateTime fechainicio, DateTime fechafin, string ncomprobante, int estado)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_comprobantexidclientexfechaxncomprobantexestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_fechainicio", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_fechafin", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_ncomprobante", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idcliente;
                    cmd.Parameters[1].Value = fechainicio;
                    cmd.Parameters[2].Value = fechafin;
                    cmd.Parameters[3].Value = ncomprobante;
                    cmd.Parameters[4].Value = estado;

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

        public Comprobante Sp_listar_comprobantexidcomprobante(int idcomprobante)
        {
            Comprobante comprobante  = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_comprobantexidcomprobante", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));                 
                    cmd.Parameters[0].Value = idcomprobante;                  
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            comprobante = new Comprobante()
                            {
                                Idcomprobante = (int)dr["idcomprobante"],
                                Serie = new Serie() {
                                    Idserie = (int)dr["idserie"],
                                    Tipocomprobante = new TipoComprobante() {
                                        Idtipocomprobante = (int)dr["idtipocomprobante"],
                                        Nombre = (string)dr["tcnombre"]
                                    }
                                },
                                Nserie = (string)dr["nserie"],
                                Ncorrelativo = (string)dr["ncorrelativo"],
                                Ncomprobante = (string)dr["ncomprobante"],
                                Fechaemision = (DateTime)dr["fechaemision"],
                                Cliente = new Cliente() {
                                    Idcliente = (int)dr["idcliente"]
                                },
                                Subtotal = (decimal)dr["subtotal"],
                                Igv = (decimal)dr["igv"],
                                Total = (decimal)dr["total"],
                                Usuario = new Usuario() {
                                    Idusuario = (int)dr["idusuario"]
                                },
                                Estado = (int)dr["estado"],
                                Glosa = Convert.ToString(dr["glosa"])
                            };
                        }

                    }
                    dr.Close();
                }
                return comprobante;
            }
            catch (MySqlException ex)
            {
                return comprobante;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public List<DetalleComprobante> Sp_listar_detallecomprobantexidcomprobante(int idcomprobante)
        {
            List<DetalleComprobante> lista_detallecomprobante= null;
            DetalleComprobante detallecomprobante = null;
            try
            {
                con = conn.Conectar();

                if (con != null)
                {
                    cmd = new MySqlCommand("Sp_listar_detallecomprobantexidcomprobante", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = idcomprobante;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_detallecomprobante = new List<DetalleComprobante>();

                        while (dr.Read())
                        {
                            detallecomprobante = new DetalleComprobante()
                            {
                                Iddetallecomprobante = (int)dr["iddetallecomprobante"],
                                Comprobante=new Comprobante() {
                                    Idcomprobante=(int)dr["idcomprobante"]
                                },
                                Producto=new Producto() {
                                    Idproducto = (int)dr["idproducto"],
                                    Nombre = (string)dr["nombre"]
                                },
                                Unidadequivalente=new UnidadEquivalente() {
                                    Idunidadequivalente=(int)dr["idunidadequivalente"],
                                    Unidadmedida=new UnidadMedida() {
                                        Sigla=(string)dr["umsigla"],
                                    }
                                },
                                Nunidad = (decimal)dr["nunidad"],
                                Pbruto = (decimal)dr["pbruto"],
                                Ptara = (decimal)dr["ptara"],
                                Pneto = (decimal)dr["pneto"],
                                Preciounitario=(decimal)dr["preciounitario"],
                                Subtotal=(decimal)dr["subtotal"],
                                Igv=(decimal)dr["igv"],
                                Total=(decimal)dr["total"],
                                Estado = (int)dr["estado"]
                            };

                            lista_detallecomprobante.Add(detallecomprobante);
                        }

                    }
                    dr.Close();
                }
                return lista_detallecomprobante;
            }
            catch (MySqlException ex)
            {
                return lista_detallecomprobante;
                throw ex;
            }
            finally { cmd.Dispose(); conn.Desconectar(con); }
        }

        public int Sp_registrar_comprobante(Comprobante comprobante, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registrar_comprobante", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idserie", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_fechaemision", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_subtotal", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_igv", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_total", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_glosa", MySqlDbType.VarChar));

                    cmd.Parameters[0].Value = comprobante.Serie.Idserie;
                    cmd.Parameters[1].Value = comprobante.Fechaemision;
                    cmd.Parameters[2].Value = comprobante.Cliente.Idcliente;
                    cmd.Parameters[3].Value = comprobante.Subtotal;
                    cmd.Parameters[4].Value = comprobante.Igv;
                    cmd.Parameters[5].Value = comprobante.Total;
                    cmd.Parameters[6].Value = sesion.Usuario.Idusuario;
                    cmd.Parameters[7].Value = comprobante.Glosa;

                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            comprobante.Idcomprobante = Convert.ToInt32(dr["_id"]);
                        }

                    }
                    dr.Close();

                    if (comprobante.Idcomprobante < 0) { id = -1; tra.Rollback(); tra.Dispose(); return id; }

                    foreach (DetalleComprobante dt in comprobante.Lista_detallecomprobante)
                    {

                        cmd = new MySqlCommand("Sp_registrar_detallecomprobante", con)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@_idproducto", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@_idunidadequivalente", MySqlDbType.Int32));
                        cmd.Parameters.Add(new MySqlParameter("@_nunidad", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_pbruto", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_ptara", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_pneto", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_preciounitario", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_subtotal", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_igv", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_total", MySqlDbType.Decimal));
                        cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                        cmd.Parameters[0].Value = comprobante.Idcomprobante;
                        cmd.Parameters[1].Value = dt.Producto.Idproducto;
                        cmd.Parameters[2].Value = dt.Unidadequivalente.Idunidadequivalente;
                        cmd.Parameters[3].Value = dt.Nunidad;
                        cmd.Parameters[4].Value = dt.Pbruto;
                        cmd.Parameters[5].Value = dt.Ptara;
                        cmd.Parameters[6].Value = dt.Pneto;
                        cmd.Parameters[7].Value = dt.Preciounitario;
                        cmd.Parameters[8].Value = dt.Subtotal;
                        cmd.Parameters[9].Value = dt.Igv;
                        cmd.Parameters[10].Value = dt.Total;
                        cmd.Parameters[11].Value = sesion.Usuario.Idusuario;

                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                dt.Iddetallecomprobante = Convert.ToInt32(dr["_id"]);
                            }

                        }
                        dr.Close();

                        if (dt.Iddetallecomprobante < 0) { id = -1; tra.Rollback(); tra.Dispose(); return id; }
                    }
                    tra.Commit();
                    tra.Dispose();
                    id = comprobante.Idcomprobante;
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
