using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Producto
    {
        private int idproducto;
        private Categoria categoria;
        private string nombre;
        private int pararendimiento;
        private UnidadMedida unidad;
        
        private decimal precio;
        private int estado;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Pararendimiento { get => pararendimiento; set => pararendimiento = value; }
        public int Estado { get => estado; set => estado = value; }
        public UnidadMedida Unidad { get => unidad; set => unidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int norden { get; set; }
      
    }
}
