using appAvicola.Mvc.Clases;
using appAvicola.Mvc.Controlador;
using appAvicola.Mvc.Vista.administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace appAvicola.Mvc.Vista
{
    public partial class RadFormInicio : Telerik.WinControls.UI.RadForm
    {
        private Usuario usuario = null;
        private List<Empresa> lista_empresa = null;
        private List<Sucursal> lista_sucursal = null;
        private List<Almacen> lista_almacen = null;
        public RadFormInicio()
        {
            InitializeComponent();
        }

        private void RadFormInicio_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                Sp_listar_empresaxestado();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_usuario_TextChanged(object sender, EventArgs e)
        {
            radText_usuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void radDrop_empresa_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (lista_empresa != null)
                {
                    Sp_listar_sucursalxidempresa();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radDrop_sucursal_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (lista_sucursal != null)
                {
                    Sp_listar_almacenxidsucursal();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void RadFormInicio_Shown(object sender, EventArgs e)
        {
            try
            {
                radText_usuario.Focus();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista_empresa != null && lista_sucursal != null && lista_almacen != null)
                {

                    if (radText_usuario.Text.Length > 0 && radText_clave.Text.Length > 0)
                    {

                        Sp_listar_usuarioxcuentaxclave();
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_clave_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Enter) {

                    radButton_aceptar.PerformClick();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }
        /****************************Mis Documento***********************/
        public void Sp_listar_empresaxestado()
        {
            try
            {
                radDrop_empresa.DataSource = null;
                lista_empresa = null;

                lista_empresa = CControl.cEmpresa.Sp_listar_empresaxestado();

                if (lista_empresa != null)
                {

                    if (lista_empresa.Count > 0)
                    {

                        radDrop_empresa.DataSource = lista_empresa;
                        radDrop_empresa.DisplayMember = "Razonsocial";
                        radDrop_empresa.ValueMember = "Idempresa";
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_sucursalxidempresa()
        {
            try
            {
                radDrop_sucursal.DataSource = null;
                lista_sucursal = null;

                lista_sucursal = CControl.cSucursal.Sp_listar_sucursalxidempresa(lista_empresa[radDrop_empresa.SelectedIndex].Idempresa);

                if (lista_sucursal != null)
                {
                    if (lista_sucursal.Count > 0)
                    {
                        radDrop_sucursal.DataSource = lista_sucursal;
                        radDrop_sucursal.DisplayMember = "Razonsocial";
                        radDrop_sucursal.ValueMember = "Idsucursal";
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_almacenxidsucursal()
        {

            try
            {
                lista_almacen = null;
                radDrop_almacen.DataSource = null;

                lista_almacen = CControl.cAlmacen.Sp_listar_almacenxidsucursal(lista_sucursal[radDrop_sucursal.SelectedIndex].Idsucursal);

                if (lista_almacen != null)
                {

                    if (lista_almacen.Count > 0)
                    {

                        radDrop_almacen.DataSource = lista_almacen;
                        radDrop_almacen.DisplayMember = "Nombre";
                        radDrop_almacen.ValueMember = "Idalmacen";
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void Sp_listar_usuarioxcuentaxclave()
        {

            try
            {
                usuario = null;
                usuario = CControl.cUsuario.Sp_listar_usuarioxcuentaxclave(
                        lista_almacen[radDrop_almacen.SelectedIndex],
                        new Usuario()
                        {

                            Cuenta = radText_usuario.Text,
                            Clave = radText_clave.Text
                        }
                    );

                if (usuario != null)
                {
                    this.Visible = false;

                    RadFormPrincipal radForm = new RadFormPrincipal
                    {
                        Sesion = new Sesion()
                        {
                            Empresa = lista_empresa[radDrop_empresa.SelectedIndex],
                            Sucursal = lista_sucursal[radDrop_sucursal.SelectedIndex],
                            Almacen = lista_almacen[radDrop_almacen.SelectedIndex],
                            Usuario = usuario
                        }
                    };
                    if (usuario.Tipousuario.Idtipousuario == 2) { radForm.radMenuItem_herramientas.Visibility = ElementVisibility.Hidden; }           
                    radForm.ShowDialog();
                    radText_usuario.Text = string.Empty;
                    radText_clave.Text = string.Empty;
                    this.Visible = true;
                    radText_usuario.Focus();
                }
                else
                {

                    RadMessageBox.Show("Problema de Usuario/Clave", "Advertencia");
                    radText_usuario.Text = string.Empty;
                    radText_clave.Text = string.Empty;
                    radText_usuario.Focus();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

       
    }
}
