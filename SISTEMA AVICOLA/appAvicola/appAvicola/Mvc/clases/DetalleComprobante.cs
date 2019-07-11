using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class DetalleComprobante
    {
        private int iddetallecomprobante;
        private Comprobante comprobante;
        private Producto producto;
        private UnidadEquivalente unidadequivalente;
        private decimal nunidad;
        private decimal pbruto;
        private decimal ptara;
        private decimal pneto;
        private decimal preciounitario;
        private decimal subtotal;
        private decimal igv;
        private decimal total;
        private decimal estado;

        public int Iddetallecomprobante { get => iddetallecomprobante; set => iddetallecomprobante = value; }
        public Comprobante Comprobante { get => comprobante; set => comprobante = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public UnidadEquivalente Unidadequivalente { get => unidadequivalente; set => unidadequivalente = value; }
        public decimal Nunidad { get => nunidad; set => nunidad = value; }
        public decimal Pbruto { get => pbruto; set => pbruto = value; }
        public decimal Ptara { get => ptara; set => ptara = value; }
        public decimal Pneto { get => pneto; set => pneto = value; }
        public decimal Preciounitario { get => preciounitario; set => preciounitario = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Igv { get => igv; set => igv = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal Estado { get => estado; set => estado = value; }
    }
}
