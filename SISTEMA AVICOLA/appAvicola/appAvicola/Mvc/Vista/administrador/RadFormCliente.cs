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

namespace appAvicola.Mvc.Vista.caja
{
    public partial class RadFormCliente : Telerik.WinControls.UI.RadForm
    {
        private DataTable clientes = null;
        private List<TipoDocumento> lista_tipodocumento = null;
        public Sesion Sesion { get; set; }
        public RadFormCliente()
        {
            InitializeComponent();
        }

        private void RadFormCliente_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_cliente.AutoGenerateColumns = false;
                radDrop_estado.SelectedIndex = 0;
                Sp_listar_tipodocumento();

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

        private void radText_documento_TextChanged(object sender, EventArgs e)
        {
            radText_documento.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_direccion_TextChanged(object sender, EventArgs e)
        {
            radText_direccion.CharacterCasing = CharacterCasing.Upper;
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
                clientes = null;
                radText_cod.Text = string.Empty;
                radDrop_tipodocumento.SelectedIndex = 2;
                radText_documento.Text = string.Empty;
                radText_razonsocial.Text = string.Empty;
                radText_direccion.Text = string.Empty;
                radGridView_cliente.DataSource = null;
                radText_razonsocial.Focus();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void RadFormCliente_Shown(object sender, EventArgs e)
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

        private void radButton_cargar_Click(object sender, EventArgs e)
        {
            try
            {
                Sp_listar_cliente();
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

                        Sp_listar_clientexrazonsocial();
                    }
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
                    if (radDrop_tipodocumento.SelectedValue != null && radText_razonsocial.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar cliente?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_cliente();
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {

                    if (radDrop_tipodocumento.SelectedValue != null && radText_razonsocial.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar cliente?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_cliente();
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

        private void radGridView_cliente_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_cliente.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_cliente.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
                        radDrop_tipodocumento.SelectedValue = int.Parse(radGridView_cliente.Rows[e.RowIndex].Cells["idtipodocumento"].Value.ToString());
                        radText_razonsocial.Text = radGridView_cliente.Rows[e.RowIndex].Cells["razonsocial"].Value.ToString();
                        radText_documento.Text = radGridView_cliente.Rows[e.RowIndex].Cells["documento"].Value.ToString();
                        radText_direccion.Text = radGridView_cliente.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                        radDrop_estado.Text = radGridView_cliente.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /**************************Mis Metodos***********************/
        public void Sp_listar_tipodocumento()
        {

            try
            {
                lista_tipodocumento = null;
                radDrop_tipodocumento.DataSource = null;

                lista_tipodocumento = CControl.cTipoDocumento.Sp_listar_tipodocumento();

                if (lista_tipodocumento != null)
                {

                    if (lista_tipodocumento.Count > 0)
                    {

                        radDrop_tipodocumento.DataSource = lista_tipodocumento;
                        radDrop_tipodocumento.DisplayMember = "Sigla";
                        radDrop_tipodocumento.ValueMember = "Idtipodocumento";
                        radDrop_tipodocumento.SelectedIndex = 2;

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_cliente()
        {

            try
            {
                clientes = null;
                radGridView_cliente.DataSource = null;

                clientes = CControl.cCliente.Sp_listar_cliente();

                if (clientes != null) {

                    if (clientes.Rows.Count > 0) {

                        radGridView_cliente.DataSource = clientes;
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_clientexrazonsocial() {

            try
            {
                clientes = null;
                radGridView_cliente.DataSource = null;

                clientes = CControl.cCliente.Sp_listar_clientexrazonsocial(radText_razonsocial.Text);

                if (clientes != null)
                {

                    if (clientes.Rows.Count > 0)
                    {

                        radGridView_cliente.DataSource = clientes;
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_cliente() {

            int id = -1;

            try
            {
                id = CControl.cCliente.Sp_registrar_cliente(
                        new Cliente() {

                            Razonsocial=radText_razonsocial.Text,
                            Tipodocumento=new TipoDocumento() { Idtipodocumento=int.Parse(radDrop_tipodocumento.SelectedValue.ToString())},
                            Documento=radText_documento.Text,
                            Direccion=radText_direccion.Text
                        },
                        Sesion
                    );

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_clientexrazonsocial();
                }
                else {

                    RadMessageBox.Show("Problemas para registrar cliente...","Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_cliente()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cCliente.Sp_actualizar_cliente(
                        new Cliente()
                        {
                            Idcliente=int.Parse(radText_cod.Text),
                            Razonsocial = radText_razonsocial.Text,
                            Tipodocumento = new TipoDocumento() { Idtipodocumento = int.Parse(radDrop_tipodocumento.SelectedValue.ToString()) },
                            Documento = radText_documento.Text,
                            Direccion = radText_direccion.Text,
                            Estado=radDrop_estado.SelectedIndex==0?1:0
                        },
                        Sesion
                    );

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_clientexrazonsocial();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar cliente...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
