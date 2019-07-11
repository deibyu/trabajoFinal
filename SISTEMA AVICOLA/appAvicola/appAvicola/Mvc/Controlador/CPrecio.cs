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
    public class CPrecio
    {
        private readonly IPrecio iprecio = new MPrecio();

        public int Sp_actualizar_precio(Precio precio, Sesion sesion) {

            return iprecio.Sp_actualizar_precio(precio, sesion);
        }
        public DataTable Sp_listar_precioxidunidadequivalente(int idunidadequivalente) {

            return iprecio.Sp_listar_precioxidunidadequivalente(idunidadequivalente);
        }
        public List<Precio> Sp_listar_precioxidunidadequivalentexestado(int idunidadequivalente) {

            return iprecio.Sp_listar_precioxidunidadequivalentexestado(idunidadequivalente);
        }
        public int Sp_registrar_precio(Precio precio, Sesion sesion) {

            return iprecio.Sp_registrar_precio(precio, sesion);
        }
    }
}
