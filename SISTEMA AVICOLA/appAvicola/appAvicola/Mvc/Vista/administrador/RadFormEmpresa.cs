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
using Telerik.WinControls.UI;

namespace appAvicola.Mvc.Vista.administrador
{
    public partial class RadFormEmpresa : Telerik.WinControls.UI.RadForm
    {
        private List<TipoDocumento> tipoDocumentos = null;
        private DataTable empresas = null;
        public Sesion Sesion { get; set; }

        public RadFormEmpresa()
        {
            InitializeComponent();
        }

        private void RadFormEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_empresa.AutoGenerateColumns = false;
                Sp_listar_tipodocumento();
                radDrop_estado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RadTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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

        private void RadFormEmpresa_Shown(object sender, EventArgs e)
        {
            try
            {
                radText_numero.Focus();
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
                radDrop_tipodocumento.SelectedIndex = 0;
                radText_numero.Text = string.Empty;
                radText_razonsocial.Text = string.Empty;
                radText_direccion.Text = string.Empty;
                radText_telefono.Text = string.Empty;
                radGridView_empresa.DataSource = null;
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
                Sp_listar_empresa();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_numero_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (radText_numero.Text.Length > 0)
                    {

                        Sp_listar_empresaxruc();
                    }
                }
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
                        Sp_listar_empresaxrazonsocial();
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radGridView_empresa_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_empresa.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_empresa.Rows[e.RowIndex].Cells["idempresa"].Value.ToString();
                        radDrop_tipodocumento.SelectedValue =int.Parse( radGridView_empresa.Rows[e.RowIndex].Cells["idtipodocumento"].Value.ToString());
                        radText_razonsocial.Text = radGridView_empresa.Rows[e.RowIndex].Cells["razonsocial"].Value.ToString();
                        radText_numero.Text = radGridView_empresa.Rows[e.RowIndex].Cells["ruc"].Value.ToString();
                        radText_direccion.Text = radGridView_empresa.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                        radText_telefono.Text = radGridView_empresa.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                        radDrop_estado.Text = radGridView_empresa.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /********************Mis Metodos*************************/
        public void Sp_listar_tipodocumento()
        {

            tipoDocumentos = null;
            try
            {
                tipoDocumentos = CControl.cTipoDocumento.Sp_listar_tipodocumento();

                if (tipoDocumentos != null)
                {

                    if (tipoDocumentos.Count > 0)
                    {
                        radDrop_tipodocumento.Items.Add(tipoDocumentos[1].Sigla);
                        radDrop_tipodocumento.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_empresa()
        {

            radGridView_empresa.DataSource = null;
            empresas = null;
            try
            {
                empresas = CControl.cEmpresa.Sp_listar_empresa();
                if (empresas != null)
                {

                    if (empresas.Rows.Count > 0)
                    {

                        radGridView_empresa.DataSource = empresas;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_empresaxruc()
        {

            radGridView_empresa.DataSource = null;
            empresas = null;
            try
            {
                empresas = CControl.cEmpresa.Sp_listar_empresaxruc(radText_numero.Text);
                if (empresas != null)
                {

                    if (empresas.Rows.Count > 0)
                    {

                        radGridView_empresa.DataSource = empresas;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_empresaxrazonsocial()
        {

            radGridView_empresa.DataSource = null;
            empresas = null;
            try
            {
                empresas = CControl.cEmpresa.Sp_listar_empresaxruc(radText_razonsocial.Text);
                if (empresas != null)
                {

                    if (empresas.Rows.Count > 0)
                    {

                        radGridView_empresa.DataSource = empresas;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_empresa()
        {

            int id = -1;
            try
            {
                id = CControl.cEmpresa.Sp_registrar_empresa(
                         new Empresa()
                         {

                             Razonsocial = radText_razonsocial.Text,
                             Tipodocumento = tipoDocumentos[1],
                             Ruc = radText_numero.Text,
                             Direccion = radText_direccion.Text,
                             Telefono = radText_telefono.Text

                         },
                        Sesion
                );

                if (id > 0)
                {

                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_empresaxruc();

                }
                else
                {

                    RadMessageBox.Show("Problemas para registrar empresa...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_empresa()
        {

            int filas_afectadas = -1;
            try
            {
                filas_afectadas = CControl.cEmpresa.Sp_actualizar_empresa(
                         new Empresa()
                         {
                             Idempresa = int.Parse(radText_cod.Text),
                             Razonsocial = radText_razonsocial.Text,
                             Tipodocumento = tipoDocumentos[1],
                             Ruc = radText_numero.Text,
                             Direccion = radText_direccion.Text,
                             Telefono = radText_telefono.Text,
                             Estado=radDrop_estado.SelectedIndex==0?1:0
                         },
                       Sesion
                );

                if (filas_afectadas > 0)
                {

                    RadMessageBox.Show("Actualización correcta..", "Información");
                    Sp_listar_empresaxruc();

                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar empresa...", "Advertencia");
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
                    if (radText_numero.Text.Length == 11 && radText_razonsocial.Text.Length > 0 && radText_direccion.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar empresa?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_empresa();
                        }
                    }
                    else
                    {
                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {
                    if (radText_numero.Text.Length == 11 && radText_razonsocial.Text.Length > 0 && radText_direccion.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar empresa?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_empresa();
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
