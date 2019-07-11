using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Precio
    {
        private int idprecio;
        private UnidadEquivalente unidadequivalente;
        private TipoPrecio tipoprecio;
        private Moneda moneda;
        private decimal valor;
        private int estado;

        public int Idprecio { get => idprecio; set => idprecio = value; }
        public UnidadEquivalente Unidadequivalente { get => unidadequivalente; set => unidadequivalente = value; }
        public TipoPrecio Tipoprecio { get => tipoprecio; set => tipoprecio = value; }
        public Moneda Moneda { get => moneda; set => moneda = value; }
     
        public int Estado { get => estado; set => estado = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}
