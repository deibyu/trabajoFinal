using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IUnidadMedida
    {
        int Sp_registrar_unidadmedida(UnidadMedida unidad, Sesion sesion);
        int Sp_actualizar_unidadmedida(UnidadMedida unidad, Sesion sesion);
        DataTable Sp_listar_unidadmedida();
        DataTable Sp_listar_unidadmedidaxnombre(string nombre);
        List<UnidadMedida> Sp_listar_unidadmedidaxestado();
    }
}
