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
    public class CUnidadMedida
    {
        private readonly IUnidadMedida unidadMedida = new MUnidadMedida();
        public int Sp_actualizar_unidadmedida(UnidadMedida unidad, Sesion sesion) {

            return unidadMedida.Sp_actualizar_unidadmedida(unidad, sesion);
        }
        public DataTable Sp_listar_unidadmedida() {

            return unidadMedida.Sp_listar_unidadmedida();
        }
        public List<UnidadMedida> Sp_listar_unidadmedidaxestado() {

            return unidadMedida.Sp_listar_unidadmedidaxestado();
        }
        public DataTable Sp_listar_unidadmedidaxnombre(string nombre) {

            return unidadMedida.Sp_listar_unidadmedidaxnombre(nombre);
        }

        public int Sp_registrar_unidadmedida(UnidadMedida unidad, Sesion sesion) {

            return unidadMedida.Sp_registrar_unidadmedida(unidad, sesion);
        }
    }
}
