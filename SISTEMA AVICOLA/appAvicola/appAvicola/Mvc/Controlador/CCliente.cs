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
    public class CCliente
    {
        private readonly ICliente icliente = new MCliente();

        public int Sp_actualizar_cliente(Cliente cliente, Sesion sesion) {

            return icliente.Sp_actualizar_cliente(cliente, sesion);
        }

        public DataTable Sp_listar_cliente() {

            return icliente.Sp_listar_cliente();
        }

        public List<Cliente> Sp_listar_clientexestado() {

            return icliente.Sp_listar_clientexestado();
        }

        public DataTable Sp_listar_clientexrazonsocial(string razonsocial) {

            return icliente.Sp_listar_clientexrazonsocial(razonsocial);
        }

        public int Sp_registrar_cliente(Cliente cliente, Sesion sesion) {

            return icliente.Sp_registrar_cliente(cliente, sesion);
        }
    }
}
