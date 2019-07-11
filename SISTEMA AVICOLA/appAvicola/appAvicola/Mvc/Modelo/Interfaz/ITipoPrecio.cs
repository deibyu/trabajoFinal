using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ITipoPrecio
    {
        List<TipoPrecio> Sp_listar_tipoprecioxestado();
    }
}
