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
    public class CTipoDocumento
    {
        private readonly ITipoDocumento itipodocumento = new MTipoDocumento();

        public List<TipoDocumento> Sp_listar_tipodocumento() {

            return itipodocumento.Sp_listar_tipodocumento();
        }
    }
}
