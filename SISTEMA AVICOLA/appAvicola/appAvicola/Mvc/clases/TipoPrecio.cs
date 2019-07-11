using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class TipoPrecio
    {
        private int idtipoprecio;
        private string nombre;
        private int estado;

        public int Idtipoprecio { get => idtipoprecio; set => idtipoprecio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
