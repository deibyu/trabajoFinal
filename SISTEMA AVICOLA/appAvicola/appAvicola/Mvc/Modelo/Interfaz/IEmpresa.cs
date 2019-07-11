using appAvicola.Mvc.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Modelo.Interfaz
{
    interface IEmpresa
    {
        int Sp_registrar_empresa(Empresa empresa, Sesion sesion);
        int Sp_actualizar_empresa(Empresa empresa, Sesion sesion);
        DataTable Sp_listar_empresa();
        DataTable Sp_listar_empresaxrazonsocial(string razonsocial);
        DataTable Sp_listar_empresaxruc(string ruc);
        Empresa Sp_listar_empresaxnumeroruc(string ruc);
        List<Empresa> Sp_listar_empresaxestado();
    }
}
