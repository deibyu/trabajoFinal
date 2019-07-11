using appAvicola.Mvc.Clases;
using appAvicola.Mvc.Modelo;
using appAvicola.Mvc.Modelo.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Controlador
{
    public class CTipoPago
    {
        private ITipoPago tipoPago = new MTipoPago();
        public List<TipoPago> Sp_listar_tipopagoxestado() {

            return tipoPago.Sp_listar_tipopagoxestado();
        }
    }
}
