using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IPrecio
    {
        int Sp_registrar_precio(Precio precio, Sesion sesion);
        int Sp_actualizar_precio(Precio precio, Sesion sesion);
        DataTable Sp_listar_precioxidunidadequivalente(int idunidadequivalente);
        List<Precio> Sp_listar_precioxidunidadequivalentexestado(int idunidadequivalente);
    }
}
