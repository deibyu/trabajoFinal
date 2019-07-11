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
    public class CSucursal
    {
        private readonly ISucursal isucursal = new MSucursal();

        public int Sp_actualizar_sucursal(Sucursal sucursal, Sesion sesion) {

            return isucursal.Sp_actualizar_sucursal(sucursal, sesion);
        }

        public DataTable Sp_listar_sucursal() {

            return isucursal.Sp_listar_sucursal();
        }

        public List<Sucursal> Sp_listar_sucursalxidempresa(int idempresa) {

            return isucursal.Sp_listar_sucursalxidempresa(idempresa);
        }

        public DataTable Sp_listar_sucursalxrazonsocial(string razonsocial) {

            return isucursal.Sp_listar_sucursalxrazonsocial(razonsocial);
        }

        public int Sp_registrar_sucursal(Sucursal sucursal, Sesion sesion) {

            return isucursal.Sp_registrar_sucursal(sucursal, sesion);
        }
    }
}
