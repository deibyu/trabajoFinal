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
    class MProducto:IProducto
    {
        private Conexion conn = new Conexion();
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader dr = null;
        private MySqlDataAdapter adap = null;
        private MySqlTransaction tra = null;
        private DataTable tabla = null;

        public int Sp_actualizar_producto(Producto producto, Sesion sesion)
        {
            int filas_afectadas = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_actualizar_producto", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idproducto", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idcategoria", MySqlDbType.Int32));                    
                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadmedida", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_precio", MySqlDbType.Decimal));        
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_norden", MySqlDbType.Int32)); 

                    cmd.Parameters[0].Value = producto.Idproducto;
                    cmd.Parameters[1].Value = producto.Categoria.Idcategoria;
                    cmd.Parameters[2].Value = producto.Nombre;
                    cmd.Parameters[3].Value = producto.Estado;
                    cmd.Parameters[4].Value = producto.Unidad.Idunidadmedida;
                    cmd.Parameters[5].Value = producto.Precio;          
                    cmd.Parameters[6].Value = sesion.Usuario.Idusuario;
                    cmd.Parameters[7].Value = producto.norden;

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

        public DataTable Sp_listar_productoxcategoria(Categoria categoria)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_productoxcategoria", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcategoria", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = categoria.Idcategoria;

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

        public DataTable Sp_listar_productoxcategoriaxestado(Categoria categoria)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_productoxcategoriaxestado", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcategoria", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = categoria.Idcategoria;

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

        public DataTable Sp_listar_productoxcategoriaxestadoxnombre(Categoria categoria, string nombre)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_productoxcategoriaxestadoxnombre", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcategoria", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = categoria.Idcategoria;
                    cmd.Parameters[1].Value = nombre;

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

        public DataTable Sp_listar_productoxnombre(string nombre)
        {
            try
            {
                tabla = null;
                con = conn.Conectar();

                if (con != null)
                {
                    tabla = new DataTable();
                    cmd = new MySqlCommand("Sp_listar_productoxnombre", con)
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

        public int Sp_registar_producto(Producto producto, Sesion sesion)
        {
            int id = -1;

            try
            {
                con = conn.Conectar();

                if (con != null)
                {

                    tra = con.BeginTransaction();
                    cmd = new MySqlCommand("Sp_registar_producto", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = tra
                    };

                    cmd.Parameters.Add(new MySqlParameter("@_idcategoria", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombre", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_idunidadmedida", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_precio", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_norden", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = producto.Categoria.Idcategoria;
                    cmd.Parameters[1].Value = producto.Nombre;
                    cmd.Parameters[2].Value = producto.Unidad.Idunidadmedida;
                    cmd.Parameters[3].Value = producto.Precio;
                    cmd.Parameters[4].Value = sesion.Usuario.Idusuario;
                    cmd.Parameters[5].Value = producto.norden;


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
