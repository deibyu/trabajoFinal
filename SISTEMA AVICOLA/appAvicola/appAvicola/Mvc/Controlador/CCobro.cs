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
    public class CCobro
    {
        private readonly ICobro icobro = new MCobro();
        public int Sp_anular_cobro(int ideuda, int idcobro, Sesion sesion) {

            return icobro.Sp_anular_cobro(ideuda, idcobro, sesion);
        }
        public DataTable Sp_listar_cobroxiddeudaxfechaxestado(int ideuda, DateTime fechainicio, DateTime fechafin, int estado) {

            return icobro.Sp_listar_cobroxiddeudaxfechaxestado(ideuda, fechainicio, fechafin, estado);
        }
        public int Sp_registrar_cobro(Cobro cobro, Sesion sesion) {

            return icobro.Sp_registrar_cobro(cobro, sesion);
        }
        public Cobro Sp_listar_cobroxidcobro(int idcobro) {

            return icobro.Sp_listar_cobroxidcobro(idcobro);
        }
        public DataTable Sp_listar_cobroxfechaxestado(DateTime fechainicio, DateTime fechafin, int estado) {

            return icobro.Sp_listar_cobroxfechaxestado(fechainicio, fechafin, estado);
        }
    }
}
