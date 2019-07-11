using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IAlmacen
    {
        int Sp_registrar_almacen(Almacen almacen, Sesion sesion);
        int Sp_actualizar_almacen(Almacen almacen, Sesion sesion);
        DataTable Sp_listar_almacen();
        DataTable Sp_listar_almacenxnombre(string nombre);
        List<Almacen> Sp_listar_almacenxidsucursal(int idsucursal);
        List<Almacen> Sp_listar_almacenxestado();
    }
}
