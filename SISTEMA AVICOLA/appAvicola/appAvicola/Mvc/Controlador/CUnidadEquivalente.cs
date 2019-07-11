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
   public class CUnidadEquivalente
    {
        private IUnidadEquivalente iunidad = new MUnidadEquivalente();
        public int Sp_actualizar_unidadequivalente(UnidadEquivalente unidad, Sesion sesion) {

            return iunidad.Sp_actualizar_unidadequivalente(unidad, sesion);
        }

        public DataTable Sp_listar_unidadequivalentexproducto(int idproducto)
        {
            return iunidad.Sp_listar_unidadequivalentexproducto(idproducto);
        }

        public int Sp_registrar_unidadequivalente(UnidadEquivalente unidad, Sesion sesion) {

            return iunidad.Sp_registrar_unidadequivalente(unidad, sesion);
        }

        public List<UnidadEquivalente> Sp_listar_unidadequivalentexproductoxestado(int idproducto) {

            return iunidad.Sp_listar_unidadequivalentexproductoxestado(idproducto);
        }
    }
}
