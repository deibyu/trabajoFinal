using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class TipoUnidad
    {
        private int idtipounidad;
        private string nombre;
        private int estado;

        public int Idtipounidad { get => idtipounidad; set => idtipounidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
