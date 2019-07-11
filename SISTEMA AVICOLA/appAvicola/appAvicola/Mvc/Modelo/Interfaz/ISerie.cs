using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ISerie
    {
        int Sp_registrar_serie(Serie serie, Sesion sesion);
        int Sp_actualizar_serie(Serie serie, Sesion sesion);
        DataTable Sp_listar_seriexidalmacenxidtipocomprobante(int idalmacen, int idtipocomprobante);
        List<Serie> Sp_listar_seriexidalmacenxidtipocomprobantexestado(int idalmacen, int idtipocomprobante);
    }
}
