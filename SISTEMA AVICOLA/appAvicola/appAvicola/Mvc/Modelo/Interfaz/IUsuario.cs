using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IUsuario
    {
        int Sp_registrar_usuario(Usuario usuario, Sesion sesion);
        int Sp_actualizar_usuario(Usuario usuario, Sesion sesion);
        DataTable Sp_listar_usuario();
        DataTable Sp_listar_usuarioxnombreyapellido(string nombreyapellido);
        int Sp_registrar_usuarioalmacen(Almacen almacen, Usuario usuario, Sesion sesion);
        int Sp_actualizar_usuarioalmacen(int idusuarioalmacen, Almacen almacen, Usuario usuario, int estado, Sesion sesion);
        DataTable Sp_listar_usuarioalmacen();
        Usuario Sp_listar_usuarioxcuentaxclave(Almacen almacen, Usuario usuario);
    }
}
