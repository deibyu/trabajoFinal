using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ITipoComprobante
    {
        List<TipoComprobante> Sp_listar_tipocomprobantexestado();
        DataTable Sp_listar_tipocomprobante();
    }
}
