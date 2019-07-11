using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Sucursal
    {
        private int idsucursal;
        private Empresa empresa;
        private string razonsocial;
        private string direccion;
        private string sede;
        private string telefono;
        private int estado;
        private List<Almacen> lista_almacen;
         
        public string Razonsocial { get => razonsocial; set => razonsocial = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sede { get => sede; set => sede = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Estado { get => estado; set => estado = value; }
        public List<Almacen> Lista_almacen { get => lista_almacen; set => lista_almacen = value; }
        public Empresa Empresa { get => empresa; set => empresa = value; }
        public int Idsucursal { get => idsucursal; set => idsucursal = value; }
    }
}
