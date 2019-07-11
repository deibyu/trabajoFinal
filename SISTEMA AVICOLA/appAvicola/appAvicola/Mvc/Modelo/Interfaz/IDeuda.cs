using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IDeuda
    {
        Deuda Sp_listar_deudaxidclientexestado(int idcliente);
        Deuda Sp_listar_deudaxiddeudaxestado(int iddeuda);
        DataTable Sp_listar_deudaxidclientexestado_(int idcliente);
    }
}
