using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ITipoUnidad
    {
        List<TipoUnidad> Sp_listar_tipounidadxestado();
    }
}
