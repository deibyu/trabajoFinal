using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface ICategoria
    {
        int Sp_registrar_categoria(Categoria categoria, Sesion sesion);
        int Sp_actualizar_categoria(Categoria categoria, Sesion sesion);
        DataTable Sp_listar_categoria();
        DataTable Sp_listar_categoriaxnombre(string nombre);
        List<Categoria> Sp_listar_categoriaxestado();
    }
}
