using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class UnidadEquivalente
    {
        private int idunidadequivalente;
        private Producto producto;
        private TipoUnidad tipounidad;
        private UnidadMedida unidadmedida;
        private decimal equivale;
        private UnidadMedida unidadbase;
        private int estado;

        public int Idunidadequivalente { get => idunidadequivalente; set => idunidadequivalente = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public TipoUnidad Tipounidad { get => tipounidad; set => tipounidad = value; }
        public UnidadMedida Unidadmedida { get => unidadmedida; set => unidadmedida = value; }
        public decimal Equivale { get => equivale; set => equivale = value; }
        public UnidadMedida Unidadbase { get => unidadbase; set => unidadbase = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
