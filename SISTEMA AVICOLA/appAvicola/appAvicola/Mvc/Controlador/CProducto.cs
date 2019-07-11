using appAvicola.Mvc.Clases;
using appAvicola.Mvc.Modelo;
using appAvicola.Mvc.Modelo.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Controlador
{
    public class CProducto
    {
        private readonly IProducto iproducto = new MProducto();

        public int Sp_actualizar_producto(Producto producto, Sesion sesion) {

            return iproducto.Sp_actualizar_producto(producto, sesion);
        }

        public DataTable Sp_listar_productoxcategoria(Categoria categoria) {

            return iproducto.Sp_listar_productoxcategoria(categoria);
        }

        public DataTable Sp_listar_productoxcategoriaxestado(Categoria categoria) {

            return iproducto.Sp_listar_productoxcategoriaxestado(categoria);
        }

        public DataTable Sp_listar_productoxcategoriaxestadoxnombre(Categoria categoria, string nombre) {

            return iproducto.Sp_listar_productoxcategoriaxestadoxnombre(categoria, nombre);
        }

        public DataTable Sp_listar_productoxnombre(string nombre) {

            return iproducto.Sp_listar_productoxnombre(nombre);
        }
        public int Sp_registar_producto(Producto producto, Sesion sesion) {

            return iproducto.Sp_registar_producto(producto, sesion);
        }
    }
}
