using appAvicola.Mvc.Clases;
using appAvicola.Mvc.Vista.caja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace appAvicola.Mvc.Vista.administrador
{
    public partial class RadFormPrincipal : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        public RadFormPrincipal()
        {
            InitializeComponent();
        }

        private void RadFormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radLabelElement_empresa.Text = Sesion.Empresa.Razonsocial;
                radLabelElement_sucursal.Text = Sesion.Sucursal.Razonsocial;
                radLabelElement_almacen.Text = Sesion.Almacen.Nombre;
                radLabelElement_usuario.Text = Sesion.Usuario.Cuenta;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_empresa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormEmpresa"] != null)
                {
                    Application.OpenForms["RadFormEmpresa"].Activate();
                }
                else
                {
                    RadFormEmpresa radForm = new RadFormEmpresa
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_sucursal_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormSucursal"] != null)
                {
                    Application.OpenForms["RadFormSucursal"].Activate();
                }
                else
                {
                    RadFormSucursal radForm = new RadFormSucursal
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_almacen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormAlmacen"] != null)
                {
                    Application.OpenForms["RadFormAlmacen"].Activate();
                }
                else
                {
                    RadFormAlmacen radForm = new RadFormAlmacen
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_mantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormUsuario"] != null)
                {
                    Application.OpenForms["RadFormUsuario"].Activate();
                }
                else
                {
                    RadFormUsuario radForm = new RadFormUsuario
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_accesoalmacen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormUsuarioAlmacen"] != null)
                {
                    Application.OpenForms["RadFormUsuarioAlmacen"].Activate();
                }
                else
                {
                    RadFormUsuarioAlmacen radForm = new RadFormUsuarioAlmacen
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormCliente"] != null)
                {
                    Application.OpenForms["RadFormCliente"].Activate();
                }
                else
                {
                    RadFormCliente radForm = new RadFormCliente
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_unidadmedida_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormUnidadMedida"] != null)
                {
                    Application.OpenForms["RadFormUnidadMedida"].Activate();
                }
                else
                {
                    RadFormUnidadMedida radForm = new RadFormUnidadMedida
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_categoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormCategoria"] != null)
                {
                    Application.OpenForms["RadFormCategoria"].Activate();
                }
                else
                {
                    RadFormCategoria radForm = new RadFormCategoria
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_producto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormProducto"] != null)
                {
                    Application.OpenForms["RadFormProducto"].Activate();
                }
                else
                {
                    RadFormProducto radForm = new RadFormProducto
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_mantenimiento_tipo_comprobante_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormTipoComprobante"] != null)
                {
                    Application.OpenForms["RadFormTipoComprobante"].Activate();
                }
                else
                {
                    RadFormTipoComprobante radForm = new RadFormTipoComprobante
                    {
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_serie_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormSerie"] != null)
                {
                    Application.OpenForms["RadFormSerie"].Activate();
                }
                else
                {
                    RadFormSerie radForm = new RadFormSerie
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_listadeventa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormListadeComprobantes"] != null)
                {
                    Application.OpenForms["RadFormListadeComprobantes"].Activate();
                }
                else
                {
                    RadFormListadeComprobantes radForm = new RadFormListadeComprobantes
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_emitir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormComprobante"] != null)
                {
                    Application.OpenForms["RadFormComprobante"].Activate();
                }
                else
                {
                    RadFormComprobante radForm = new RadFormComprobante
                    {
                        Sesion = Sesion,                       
                        MdiParent = this                      
                    };

                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_ventaxcliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormListadeComprobantesporCliente"] != null)
                {
                    Application.OpenForms["RadFormListadeComprobantesporCliente"].Activate();
                }
                else
                {
                    RadFormListadeComprobantesporCliente radForm = new RadFormListadeComprobantesporCliente
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_deudaxcliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormDeudaporCliente"] != null)
                {
                    Application.OpenForms["RadFormDeudaporCliente"].Activate();
                }
                else
                {
                    RadFormDeudaporCliente radForm = new RadFormDeudaporCliente
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void radMenuItem_listadecobros_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["RadFormListadeCobros"] != null)
                {
                    Application.OpenForms["RadFormListadeCobros"].Activate();
                }
                else
                {
                    RadFormListadeCobros radForm = new RadFormListadeCobros
                    {
                        Sesion = Sesion,
                        MdiParent = this
                    };
                    radForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
