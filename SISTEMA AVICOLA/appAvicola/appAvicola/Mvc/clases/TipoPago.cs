using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class TipoPago
    {
        private int idtipopago;
        private string nombre;
        private int ndia;
        private int estado;

        public int Idtipopago { get => idtipopago; set => idtipopago = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Ndia { get => ndia; set => ndia = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
