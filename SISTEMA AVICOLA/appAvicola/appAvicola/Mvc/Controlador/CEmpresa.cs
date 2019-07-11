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
    public class CEmpresa
    {
        private readonly IEmpresa iempresa = new MEmpresa();

        public int Sp_actualizar_empresa(Empresa empresa, Sesion sesion)
        {
            return iempresa.Sp_actualizar_empresa(empresa, sesion);
        }

        public DataTable Sp_listar_empresa() {

            return iempresa.Sp_listar_empresa();
        }

        public Empresa Sp_listar_empresaxnumeroruc(string ruc) {

            return iempresa.Sp_listar_empresaxnumeroruc(ruc);
        }

        public DataTable Sp_listar_empresaxrazonsocial(string razonsocial) {

            return iempresa.Sp_listar_empresaxrazonsocial(razonsocial);
        }

        public DataTable Sp_listar_empresaxruc(string ruc) {

            return iempresa.Sp_listar_empresaxruc(ruc);
        }

        public int Sp_registrar_empresa(Empresa empresa, Sesion sesion) {

            return iempresa.Sp_registrar_empresa(empresa, sesion);
        }

        public List<Empresa> Sp_listar_empresaxestado() {

            return iempresa.Sp_listar_empresaxestado();
        }
    }
}
