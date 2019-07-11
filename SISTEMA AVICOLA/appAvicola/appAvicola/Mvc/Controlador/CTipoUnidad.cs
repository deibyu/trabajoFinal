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
    public class CTipoUnidad
    {
        private readonly ITipoUnidad itipounidad = new MTipoUnidad();
        public List<TipoUnidad> Sp_listar_tipounidadxestado() {

            return itipounidad.Sp_listar_tipounidadxestado();
        }
    }
}
