using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAvicola.Mvc.Controlador
{
    public class CControl
    {
        public static readonly CTipoDocumento cTipoDocumento = new CTipoDocumento();
        public static readonly CEmpresa cEmpresa = new CEmpresa();
        public static readonly CSucursal cSucursal = new CSucursal();
        public static readonly CAlmacen cAlmacen = new CAlmacen();
        public static readonly CUsuario cUsuario = new CUsuario();
        public static readonly CTipoUsuario cTipoUsuario = new CTipoUsuario();
        public static readonly CCliente cCliente = new CCliente();
        public static readonly CUnidadMedida cUnidad = new CUnidadMedida();
        public static readonly CCategoria cCategoria = new CCategoria();
        public static readonly CProducto cProducto = new CProducto();
        public static readonly CUnidadEquivalente cUnidadEquivalente = new CUnidadEquivalente();
        public static readonly CTipoUnidad cTipoUnidad = new CTipoUnidad();
        public static readonly CPrecio cPrecio = new CPrecio();
        public static readonly CTipoPrecio cTipoPrecio = new CTipoPrecio();
        public static readonly CMoneda cMoneda = new CMoneda();
        public static readonly CTipoComprobante cTipoComprobante = new CTipoComprobante();
        public static readonly CSerie cSerie = new CSerie();
        public static readonly CComprobante cComprobante = new CComprobante();
        public static readonly CDeuda cDeuda = new CDeuda();
        public static readonly CCobro cCobro = new CCobro();
        public static readonly CTipoCobro cTipoCobro = new CTipoCobro();
    }
}
