using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IUnidadEquivalente
    {
        int Sp_registrar_unidadequivalente(UnidadEquivalente unidad, Sesion sesion);
        int Sp_actualizar_unidadequivalente(UnidadEquivalente unidad, Sesion sesion);
        DataTable Sp_listar_unidadequivalentexproducto(int idproducto);
        List<UnidadEquivalente> Sp_listar_unidadequivalentexproductoxestado(int idproducto);
    }
}
