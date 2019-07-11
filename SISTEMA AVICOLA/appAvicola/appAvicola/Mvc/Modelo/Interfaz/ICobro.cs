using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ICobro
    {
        int Sp_registrar_cobro(Cobro cobro, Sesion sesion);
        int Sp_anular_cobro(int ideuda, int idcobro, Sesion sesion);
        DataTable Sp_listar_cobroxiddeudaxfechaxestado(int ideuda, DateTime fechainicio, DateTime fechafin, int estado);
        Cobro Sp_listar_cobroxidcobro(int idcobro);
        DataTable Sp_listar_cobroxfechaxestado( DateTime fechainicio, DateTime fechafin, int estado);
    }
}
