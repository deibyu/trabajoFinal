using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
   public class Empresa
    {
        private int idempresa;
        private string razonsocial;
        private TipoDocumento tipodocumento;
        private string ruc;
        private string direccion;
        private string telefono;
        private int estado;
        private List<Sucursal> lista_sucursal;

        public int Idempresa { get => idempresa; set => idempresa = value; }
        public string Razonsocial { get => razonsocial; set => razonsocial = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }        
        public List<Sucursal> Lista_sucursal { get => lista_sucursal; set => lista_sucursal = value; }
        public TipoDocumento Tipodocumento { get => tipodocumento; set => tipodocumento = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
