using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IComprobante
    {
        int Sp_registrar_comprobante(Comprobante comprobante, Sesion sesion);
        Comprobante Sp_listar_comprobantexidcomprobante(int idcomprobante);
        List<DetalleComprobante> Sp_listar_detallecomprobantexidcomprobante(int idcomprobante);
        DataTable Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado(int idalmacen, DateTime fechainicio, DateTime fechafin, string ncomprobante, int estado);
        DataTable Sp_listar_comprobantexidclientexfechaxncomprobantexestado(int idcliente, DateTime fechainicio, DateTime fechafin, string ncomprobante, int estado);
        int Sp_anular_comprobantexidcomprobante(int idcomprobante, Sesion sesion);
        DataSet Sp_imprimir_comprobante(int idcomprobante, int ocultar);
    }
}
