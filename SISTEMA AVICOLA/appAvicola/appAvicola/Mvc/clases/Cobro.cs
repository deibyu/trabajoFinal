using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Cobro
    {
        private int idcobro;
        private Deuda deuda;
        private DateTime fechacobro;
        private TipoCobro tipocobro;
        private Moneda moneda;
        private string cuentabancaria;
        private string noperacion;
        private decimal monto;
        private string observacion;
        private int estado;

        public int Idcobro { get => idcobro; set => idcobro = value; }
       
        public DateTime Fechacobro { get => fechacobro; set => fechacobro = value; }
        public TipoCobro Tipocobro { get => tipocobro; set => tipocobro = value; }
        public Moneda Moneda { get => moneda; set => moneda = value; }
        public string Cuentabancaria { get => cuentabancaria; set => cuentabancaria = value; }
        public string Noperacion { get => noperacion; set => noperacion = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public Deuda Deuda { get => deuda; set => deuda = value; }
    }
}
