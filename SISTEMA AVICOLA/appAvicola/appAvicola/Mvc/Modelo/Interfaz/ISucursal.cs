using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ISucursal
    {
        int Sp_registrar_sucursal(Sucursal sucursal, Sesion sesion);
        int Sp_actualizar_sucursal(Sucursal sucursal, Sesion sesion);
        DataTable Sp_listar_sucursal();
        DataTable Sp_listar_sucursalxrazonsocial(string razonsocial);
        List<Sucursal> Sp_listar_sucursalxidempresa(int idempresa);
    }
}
