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
    public partial class RadFormUnidadMedida : Telerik.WinControls.UI.RadForm
    {
        private DataTable unidades = null;
        public Sesion Sesion { get; set; }
        public RadFormUnidadMedida()
        {
            InitializeComponent();
        }

        private void RadFormUnidadMedida_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_unidad.AutoGenerateColumns = false;
                radDrop_estado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_nombre_TextChanged(object sender, EventArgs e)
        {
            radText_nombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_sigla_TextChanged(object sender, EventArgs e)
        {
            radText_sigla.CharacterCasing = CharacterCasing.Upper;
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
                radText_nombre.Text = string.Empty;
                radText_sigla.Text = string.Empty;
                unidades = null;
                radGridView_unidad.DataSource = null;
                radText_nombre.Focus();
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
                Sp_listar_unidadmedida();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (radText_nombre.Text.Length > 0)
                    {
                        Sp_listar_unidadmedidaxnombre();
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
                    if (radText_nombre.Text.Length > 0 && radText_sigla.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar unidad?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_unidadmedida();
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {
                    if (radText_nombre.Text.Length > 0 && radText_sigla.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar unidad?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_unidadmedida();
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
        private void RadFormUnidadMedida_Shown(object sender, EventArgs e)
        {
            try
            {
                radText_nombre.Focus();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radGridView_unidad_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_unidad.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_unidad.Rows[e.RowIndex].Cells["idunidadmedida"].Value.ToString();
                        radText_nombre.Text = radGridView_unidad.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                        radText_sigla.Text = radGridView_unidad.Rows[e.RowIndex].Cells["sigla"].Value.ToString();
                        radDrop_estado.Text = radGridView_unidad.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /***********************************Mis Metodos*************************/

        public void Sp_listar_unidadmedida()
        {

            try
            {

                unidades = null;
                radGridView_unidad.DataSource = null;

                unidades = CControl.cUnidad.Sp_listar_unidadmedida();

                if (unidades != null)
                {

                    if (unidades.Rows.Count > 0)
                    {

                        radGridView_unidad.DataSource = unidades;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_unidadmedidaxnombre()
        {

            try
            {

                unidades = null;
                radGridView_unidad.DataSource = null;

                unidades = CControl.cUnidad.Sp_listar_unidadmedidaxnombre(radText_nombre.Text);

                if (unidades != null) {

                    if (unidades.Rows.Count > 0) {

                        radGridView_unidad.DataSource = unidades;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_unidadmedida() {

            int id = -1;

            try
            {
                id = CControl.cUnidad.Sp_registrar_unidadmedida(
                    new UnidadMedida()
                    {
                        Nombre=radText_nombre.Text,
                        Sigla=radText_sigla.Text
                    },
                    Sesion);

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_unidadmedidaxnombre();
                }
                else {

                    RadMessageBox.Show("Problemas para registrar unidad...","Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }

        public void Sp_actualizar_unidadmedida()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cUnidad.Sp_actualizar_unidadmedida(
                    new UnidadMedida()
                    {
                        Idunidadmedida=int.Parse(radText_cod.Text),
                        Nombre = radText_nombre.Text,
                        Sigla = radText_sigla.Text,
                        Estado=radDrop_estado.SelectedIndex==0?1:0
                    },
                    Sesion);

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_unidadmedidaxnombre();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar unidad...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }        
    }
}
