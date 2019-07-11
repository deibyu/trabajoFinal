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
    public class CTipoComprobante
    {
        private ITipoComprobante tipoComprobante = new MTipoComprobante();
        public List<TipoComprobante> Sp_listar_tipocomprobantexestado() {

            return tipoComprobante.Sp_listar_tipocomprobantexestado();
        }

        public DataTable Sp_listar_tipocomprobante() {

            return tipoComprobante.Sp_listar_tipocomprobante();
        }
    }
}
