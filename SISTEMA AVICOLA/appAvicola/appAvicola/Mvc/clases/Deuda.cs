using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Clases
{
    public class Deuda
    {
        private int iddeuda;
        private Cliente cliente;
        private decimal montoinicial;
        private decimal montototal;
        private decimal montocobrado;
        private decimal montoactual;
        private int estado;

        public int Iddeuda { get => iddeuda; set => iddeuda = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public decimal Montoinicial { get => montoinicial; set => montoinicial = value; }
        public decimal Montototal { get => montototal; set => montototal = value; }
        public decimal Montocobrado { get => montocobrado; set => montocobrado = value; }
        public decimal Montoactual { get => montoactual; set => montoactual = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
