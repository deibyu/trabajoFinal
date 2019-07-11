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
    public class CAlmacen
    {
        private readonly IAlmacen ialmacen = new MAlmacen();

        public int Sp_actualizar_almacen(Almacen almacen, Sesion sesion) {

            return ialmacen.Sp_actualizar_almacen(almacen, sesion);
        }

        public DataTable Sp_listar_almacen() {

            return ialmacen.Sp_listar_almacen();
        }

        public List<Almacen> Sp_listar_almacenxidsucursal(int idsucursal) {

            return ialmacen.Sp_listar_almacenxidsucursal(idsucursal);
        }

        public DataTable Sp_listar_almacenxnombre(string nombre) {

            return ialmacen.Sp_listar_almacenxnombre(nombre);
        }

        public int Sp_registrar_almacen(Almacen almacen, Sesion sesion) {

            return ialmacen.Sp_registrar_almacen(almacen, sesion);
        }

        public List<Almacen> Sp_listar_almacenxestado() {

            return ialmacen.Sp_listar_almacenxestado();
        }
    }
}
