using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Almacen
    {
        private int idalmacen;
        private Sucursal sucursal;
        private string nombre;
        private string direccion;
        private string telefono;
        private int estado;

        public int Idalmacen { get => idalmacen; set => idalmacen = value; }
        public Sucursal Sucursal { get => sucursal; set => sucursal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
