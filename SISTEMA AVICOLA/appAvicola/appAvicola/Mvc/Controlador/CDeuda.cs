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
    public class CDeuda
    {
        private IDeuda ideuda = new MDeuda();
        public Deuda Sp_listar_deudaxidclientexestado(int idcliente) {

            return ideuda.Sp_listar_deudaxidclientexestado(idcliente);
        }
        public DataTable Sp_listar_deudaxidclientexestado_(int idcliente) {

            return ideuda.Sp_listar_deudaxidclientexestado_(idcliente);
        }
        public Deuda Sp_listar_deudaxiddeudaxestado(int iddeuda) {

            return ideuda.Sp_listar_deudaxiddeudaxestado(iddeuda);
        }
    }
}
