using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class TipoDocumento
    {
        private int idtipodocumento;
        private string nombre;
        private string sigla;
        private int longitud;
        private int estado;

        public int Idtipodocumento { get => idtipodocumento; set => idtipodocumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public int Longitud { get => longitud; set => longitud = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
