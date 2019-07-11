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
    public class CUsuario
    {
        private readonly IUsuario iusuario = new MUsuario();

        public int Sp_actualizar_usuario(Usuario usuario, Sesion sesion) {

            return iusuario.Sp_actualizar_usuario(usuario, sesion);
        }

        public DataTable Sp_listar_usuario() {

            return iusuario.Sp_listar_usuario();
        }

        public DataTable Sp_listar_usuarioxnombreyapellido(string nombreyapellido) {

            return iusuario.Sp_listar_usuarioxnombreyapellido(nombreyapellido);
        }

        public int Sp_registrar_usuario(Usuario usuario, Sesion sesion) {

            return iusuario.Sp_registrar_usuario(usuario, sesion);
        }

        public Usuario Sp_listar_usuarioxcuentaxclave(Almacen almacen, Usuario usuario) {

            return iusuario.Sp_listar_usuarioxcuentaxclave(almacen, usuario);
        }

        public int Sp_registrar_usuarioalmacen(Almacen almacen, Usuario usuario, Sesion sesion) {

            return iusuario.Sp_registrar_usuarioalmacen(almacen, usuario, sesion);
        }

        public DataTable Sp_listar_usuarioalmacen() {

            return iusuario.Sp_listar_usuarioalmacen();
        }

        public int Sp_actualizar_usuarioalmacen(int idusuarioalmacen, Almacen almacen, Usuario usuario, int estado, Sesion sesion) {

            return iusuario.Sp_actualizar_usuarioalmacen(idusuarioalmacen, almacen, usuario, estado, sesion);
        }
    }
}
