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
    public class CCategoria
    {
        private readonly ICategoria icategoria = new MCategoria();

        public int Sp_actualizar_categoria(Categoria categoria, Sesion sesion) {

            return icategoria.Sp_actualizar_categoria(categoria, sesion);
        }

        public DataTable Sp_listar_categoria() {

            return icategoria.Sp_listar_categoria();
        }
        public List<Categoria> Sp_listar_categoriaxestado() {

            return icategoria.Sp_listar_categoriaxestado();
        }
        public DataTable Sp_listar_categoriaxnombre(string nombre) {

            return icategoria.Sp_listar_categoriaxnombre(nombre);
        }
        public int Sp_registrar_categoria(Categoria categoria, Sesion sesion) {

            return icategoria.Sp_registrar_categoria(categoria, sesion);
        }
    }
}
