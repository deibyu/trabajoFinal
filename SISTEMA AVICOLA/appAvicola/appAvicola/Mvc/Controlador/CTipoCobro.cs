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
    public class CTipoCobro
    {
        private ITipoCobro itipocobro = new MTipoCobro();
        public List<TipoCobro> Sp_listar_tipocobroxestado() {

            return itipocobro.Sp_listar_tipocobroxestado();
        }
    }
}
