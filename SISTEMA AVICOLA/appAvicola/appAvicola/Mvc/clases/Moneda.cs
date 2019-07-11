using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Moneda
    {
        private int idmoneda;
        private string nombre;
        private string sigla;
        private int estado;

        public int Idmoneda { get => idmoneda; set => idmoneda = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
