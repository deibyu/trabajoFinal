using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Serie
    {
        private int idserie;
        private Almacen almacen;
        private TipoComprobante tipocomprobante;
        private string nserie;
        private int ncorrelativo;
        private int estado;

        public int Idserie { get => idserie; set => idserie = value; }
        public Almacen Almacen { get => almacen; set => almacen = value; }
        public TipoComprobante Tipocomprobante { get => tipocomprobante; set => tipocomprobante = value; }
        public string Nserie { get => nserie; set => nserie = value; }
        public int Ncorrelativo { get => ncorrelativo; set => ncorrelativo = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
