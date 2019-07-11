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
    public class CSerie
    {
        private readonly ISerie iserie = new MSerie();
        public int Sp_actualizar_serie(Serie serie, Sesion sesion) {

            return iserie.Sp_actualizar_serie(serie, sesion);
        }
        public DataTable Sp_listar_seriexidalmacenxidtipocomprobante(int idalmacen, int idtipocomprobante) {

            return iserie.Sp_listar_seriexidalmacenxidtipocomprobante(idalmacen, idtipocomprobante);
        }
        public List<Serie> Sp_listar_seriexidalmacenxidtipocomprobantexestado(int idalmacen, int idtipocomprobante) {

            return iserie.Sp_listar_seriexidalmacenxidtipocomprobantexestado(idalmacen, idtipocomprobante);
        }
        public int Sp_registrar_serie(Serie serie, Sesion sesion) {

            return iserie.Sp_registrar_serie(serie, sesion);
        }
    }

}
