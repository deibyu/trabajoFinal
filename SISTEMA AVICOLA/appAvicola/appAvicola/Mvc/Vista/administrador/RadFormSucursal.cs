using appAvicola.Mvc.Clases;
using appAvicola.Mvc.Controlador;
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
    public partial class RadFormSucursal : Telerik.WinControls.UI.RadForm
    {
        private DataTable empresas = null;
        private DataTable sucursales = null;
        public Sesion Sesion { get; set; }

        public RadFormSucursal()
        {
            InitializeComponent();
        }

        private void RadFormSucursal_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_sucursal.AutoGenerateColumns = false;
                radDrop_estado.SelectedIndex = 0;
                Sp_listar_empresa();

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_razonsocial_TextChanged(object sender, EventArgs e)
        {
            radText_razonsocial.CharacterCasing = CharacterCasing.Upper;
        }


        private void radText_direccion_TextChanged(object sender, EventArgs e)
        {
            radText_direccion.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_sede_TextChanged(object sender, EventArgs e)
        {
            radText_sede.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_telefono_TextChanged(object sender, EventArgs e)
        {
            radText_telefono.CharacterCasing = CharacterCasing.Upper;
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
        private void radButton_limpiar_Click(object sender, EventArgs e)
        {
            try
            {
                radText_cod.Text = string.Empty;
                radDrop_estado.SelectedIndex = 0;
                radDrop_empresa.SelectedIndex = 0;
                radText_razonsocial.Text = string.Empty;
                radText_direccion.Text = string.Empty;
                radText_telefono.Text = string.Empty;
                radText_sede.Text = string.Empty;
                radGridView_sucursal.DataSource = null;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_cargar_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_listar_sucursal();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_razonsocial_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (radText_razonsocial.Text.Length > 0)
                    {

                        Sp_listar_sucursalxrazonsocial();
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void RadFormSucursal_Shown(object sender, EventArgs e)
        {
            try
            {
                radText_razonsocial.Focus();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radGridView_sucursal_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_sucursal.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_sucursal.Rows[e.RowIndex].Cells["idsucursal"].Value.ToString();
                        radDrop_empresa.SelectedValue =int.Parse(radGridView_sucursal.Rows[e.RowIndex].Cells["idempresa"].Value.ToString());
                        radText_razonsocial.Text = radGridView_sucursal.Rows[e.RowIndex].Cells["razonsocial"].Value.ToString();
                        radText_direccion.Text = radGridView_sucursal.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                        radText_telefono.Text = radGridView_sucursal.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                        radText_sede.Text = radGridView_sucursal.Rows[e.RowIndex].Cells["sede"].Value.ToString();
                        radDrop_estado.Text = radGridView_sucursal.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /*****************************Mis Metodos********************************/
        public void Sp_listar_empresa()
        {

            empresas = null;
            try
            {
                empresas = CControl.cEmpresa.Sp_listar_empresa();

                if (empresas != null)
                {

                    if (empresas.Rows.Count > 0)
                    {

                        radDrop_empresa.DataSource = empresas;
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

        public void Sp_listar_sucursal()
        {

            sucursales = null;
            radGridView_sucursal.DataSource = null;
            try
            {
                sucursales = CControl.cSucursal.Sp_listar_sucursal();

                if (sucursales != null)
                {

                    if (sucursales.Rows.Count > 0)
                    {

                        radGridView_sucursal.DataSource = sucursales;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_sucursalxrazonsocial()
        {

            sucursales = null;
            radGridView_sucursal.DataSource = null;
            try
            {
                sucursales = CControl.cSucursal.Sp_listar_sucursalxrazonsocial(radText_razonsocial.Text);

                if (sucursales != null)
                {

                    if (sucursales.Rows.Count > 0)
                    {

                        radGridView_sucursal.DataSource = sucursales;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_sucursal()
        {

            int id = -1;

            try
            {

                id = CControl.cSucursal.Sp_registrar_sucursal(
                        new Sucursal()
                        {
                            Empresa = new Empresa()
                            {
                                Idempresa = int.Parse(radDrop_empresa.SelectedValue.ToString())
                            },
                            Razonsocial = radText_razonsocial.Text,
                            Direccion = radText_direccion.Text,
                            Telefono = radText_telefono.Text,
                            Sede = radText_sede.Text,
                        },
                        Sesion
                    );

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_sucursalxrazonsocial();
                }
                else
                {

                    RadMessageBox.Show("Problemas para registrar sucursal...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }

        public void Sp_actualizar_sucursal()
        {

            int filas_afectadas = -1;

            try
            {

                filas_afectadas = CControl.cSucursal.Sp_actualizar_sucursal(
                        new Sucursal()
                        {
                            Idsucursal = int.Parse(radText_cod.Text),
                            Empresa = new Empresa()
                            {
                                Idempresa = int.Parse(radDrop_empresa.SelectedValue.ToString())
                            },
                            Razonsocial = radText_razonsocial.Text,
                            Direccion = radText_direccion.Text,
                            Telefono = radText_telefono.Text,
                            Sede = radText_sede.Text,
                            Estado=radDrop_estado.SelectedIndex==0?1:0
                        },
                        Sesion
                    );

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_sucursalxrazonsocial();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar sucursal...", "Advertencia");
                }
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

                if (radText_cod.Text.Length == 0)
                {

                    if (radText_razonsocial.Text.Length > 0 && radText_direccion.Text.Length > 0 && radText_sede.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar sucursal?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_sucursal();
                        }
                    }
                    else
                    {
                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {
                    if (radText_razonsocial.Text.Length > 0 && radText_direccion.Text.Length > 0 && radText_sede.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar sucursal?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_sucursal();
                        }
                    }
                    else
                    {
                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }
        
    }
}
