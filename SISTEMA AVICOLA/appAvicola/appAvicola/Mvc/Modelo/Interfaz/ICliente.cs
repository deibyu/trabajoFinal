using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ICliente
    {
        int Sp_registrar_cliente(Cliente cliente, Sesion sesion);
        int Sp_actualizar_cliente(Cliente cliente, Sesion sesion);
        DataTable Sp_listar_cliente();
        DataTable Sp_listar_clientexrazonsocial(string razonsocial);
        List<Cliente> Sp_listar_clientexestado();
    }
}
