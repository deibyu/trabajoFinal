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
    public class CMoneda
    {
        private readonly IMoneda imoneda = new MMoneda();
        public List<Moneda> Sp_listar_monedaxestado() {

            return imoneda.Sp_listar_monedaxestado();
        }
    }
}
