using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IProducto
    {
        int Sp_registar_producto(Producto producto, Sesion sesion);
        int Sp_actualizar_producto(Producto producto, Sesion sesion);
        DataTable Sp_listar_productoxcategoria(Categoria categoria);
        DataTable Sp_listar_productoxnombre(string nombre);
        DataTable Sp_listar_productoxcategoriaxestado(Categoria categoria);
        DataTable Sp_listar_productoxcategoriaxestadoxnombre(Categoria categoria, string nombre);        
    }
}
