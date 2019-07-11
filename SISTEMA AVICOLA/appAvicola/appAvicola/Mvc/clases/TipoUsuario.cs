using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class TipoUsuario
    {
        private int idtipousuario;
        private string nombre;
        private string sigla;
        private int estado;

        public int Idtipousuario { get => idtipousuario; set => idtipousuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
