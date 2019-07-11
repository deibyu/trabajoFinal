using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Sesion
    {
        private Usuario usuario;
        private Empresa empresa;
        private Sucursal sucursal;
        private Almacen almacen;

        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Empresa Empresa { get => empresa; set => empresa = value; }
        public Sucursal Sucursal { get => sucursal; set => sucursal = value; }
        public Almacen Almacen { get => almacen; set => almacen = value; }
    }
}
