using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Cliente
    {
        private int idcliente;
        private string razonsocial;
        private TipoDocumento tipodocumento;
        private string documento;
        private string direccion;
        private int estado;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Razonsocial { get => razonsocial; set => razonsocial = value; }
        public TipoDocumento Tipodocumento { get => tipodocumento; set => tipodocumento = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
