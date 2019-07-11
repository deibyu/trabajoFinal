using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Usuario
    {
        private int idusuario;
        private TipoUsuario tipousuario;
        private string nombreyapellido;
        private string cuenta;
        private string clave;
        private int estado;

        public int Idusuario { get => idusuario; set => idusuario = value; }        
        public string Nombreyapellido { get => nombreyapellido; set => nombreyapellido = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Estado { get => estado; set => estado = value; }
        public TipoUsuario Tipousuario { get => tipousuario; set => tipousuario = value; }
    }
}
