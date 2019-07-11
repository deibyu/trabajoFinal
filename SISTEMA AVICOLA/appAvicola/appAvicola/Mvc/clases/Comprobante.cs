using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Comprobante
    {
        private int idcomprobante;
        private Serie serie;
        private string nserie;
        private string ncorrelativo;
        private string ncomprobante;
        private TipoPago tipopago;
        private Moneda moneda;
        private DateTime fechaemision;            
        private Cliente cliente;        
        private decimal subtotal;
        private decimal igv;
        private decimal total;
        private string descripcion;           
        private int estado;
        private Usuario usuario;
        private List<DetalleComprobante> lista_detallecomprobante;
        private string glosa;

        public int Idcomprobante { get => idcomprobante; set => idcomprobante = value; }
        public Serie Serie { get => serie; set => serie = value; }
        public string Nserie { get => nserie; set => nserie = value; }
        public string Ncorrelativo { get => ncorrelativo; set => ncorrelativo = value; }
        public string Ncomprobante { get => ncomprobante; set => ncomprobante = value; }
        public DateTime Fechaemision { get => fechaemision; set => fechaemision = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }        
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Igv { get => igv; set => igv = value; }
        public decimal Total { get => total; set => total = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }        
        public int Estado { get => estado; set => estado = value; }
        public List<DetalleComprobante> Lista_detallecomprobante { get => lista_detallecomprobante; set => lista_detallecomprobante = value; }
        public TipoPago Tipopago { get => tipopago; set => tipopago = value; }
        public Moneda Moneda { get => moneda; set => moneda = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public string Glosa { get => glosa; set => glosa = value; }
    }
}
