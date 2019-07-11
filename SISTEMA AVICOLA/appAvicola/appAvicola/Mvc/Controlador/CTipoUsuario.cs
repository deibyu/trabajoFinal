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
    public class CTipoUsuario
    {
        private readonly ITipoUsuario tipoUsuario = new MTipoUsuario();
        public List<TipoUsuario> Sp_listar_tipousuarioxestado() {

            return tipoUsuario.Sp_listar_tipousuarioxestado();
        }
    }
}
