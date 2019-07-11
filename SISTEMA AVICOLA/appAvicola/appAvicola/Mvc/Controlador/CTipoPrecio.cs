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
    public class CTipoPrecio
    {
        private readonly ITipoPrecio itipoprecio = new MTipoPrecio();

        public List<TipoPrecio> Sp_listar_tipoprecioxestado() {

            return itipoprecio.Sp_listar_tipoprecioxestado();
        }
    }
}
