using appAvicola.Mvc.Clases;
using appAvicola.Mvc.Modelo;
using appAvicola.Mvc.Modelo.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Controlador
{
    public class CComprobante
    {
        private readonly IComprobante icomprobante = new MComprobante();
        public int Sp_registrar_comprobante(Comprobante comprobante, Sesion sesion) {

            return icomprobante.Sp_registrar_comprobante(comprobante, sesion);
        }
        public Comprobante Sp_listar_comprobantexidcomprobante(int idcomprobante) {

            return icomprobante.Sp_listar_comprobantexidcomprobante(idcomprobante);
        }
        public List<DetalleComprobante> Sp_listar_detallecomprobantexidcomprobante(int idcomprobante) {

            return icomprobante.Sp_listar_detallecomprobantexidcomprobante(idcomprobante);
        }
        public DataTable Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado(int idalmacen, DateTime fechainicio, DateTime fechafin, string ncomprobante,int estado)
        {

            return icomprobante.Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado(idalmacen, fechainicio, fechafin, ncomprobante, estado);
        }
        public int Sp_anular_comprobantexidcomprobante(int idcomprobante, Sesion sesion) {

            return icomprobante.Sp_anular_comprobantexidcomprobante(idcomprobante, sesion);
        }

        public DataTable Sp_listar_comprobantexidclientexfechaxncomprobantexestado(int idcliente, DateTime fechainicio, DateTime fechafin, string ncomprobante, int estado) {

            return icomprobante.Sp_listar_comprobantexidclientexfechaxncomprobantexestado(idcliente, fechainicio, fechafin, ncomprobante, estado);
        }

        public DataSet Sp_imprimir_comprobante(int idcomprobante,int ocultar) {

            return icomprobante.Sp_imprimir_comprobante(idcomprobante, ocultar);
        }
    }
}
