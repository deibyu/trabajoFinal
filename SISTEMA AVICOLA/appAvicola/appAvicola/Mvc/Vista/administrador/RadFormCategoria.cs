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
    public partial class RadFormCategoria : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        private DataTable categorias = null;
        public RadFormCategoria()
        {
            InitializeComponent();
        }

        private void RadFormCategoria_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_categoria.AutoGenerateColumns = false;
                radDrop_estado.SelectedIndex = 0;
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

        private void radButton_limpiar_Click(object sender, EventArgs e)
        {
            try
            {
                radText_cod.Text = string.Empty;
                radDrop_estado.SelectedIndex = 0;
                radText_nombre.Text = string.Empty;
                radGridView_categoria.DataSource = null;
                categorias = null;
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
                Sp_listar_categoria();
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

        private void radText_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {

                    if (radText_nombre.Text.Length > 0)
                    {
                        Sp_listar_categoriaxnombre();
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
                    if (radText_nombre.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar categoria?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_categoria();
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {
                    if (radText_nombre.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar categoria?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_categoria();
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

        private void radGridView_categoria_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_categoria.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_categoria.Rows[e.RowIndex].Cells["idcategoria"].Value.ToString();
                        radText_nombre.Text = radGridView_categoria.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                        radDrop_estado.Text = radGridView_categoria.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void RadFormCategoria_Shown(object sender, EventArgs e)
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

        /**********************Mis Metodos********************/
        public void Sp_listar_categoria()
        {

            try
            {
                categorias = null;
                radGridView_categoria.DataSource = null;

                categorias = CControl.cCategoria.Sp_listar_categoria();

                if (categorias != null)
                {

                    if (categorias.Rows.Count > 0)
                    {

                        radGridView_categoria.DataSource = categorias;
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_categoriaxnombre()
        {

            try
            {
                categorias = null;
                radGridView_categoria.DataSource = null;

                categorias = CControl.cCategoria.Sp_listar_categoriaxnombre(radText_nombre.Text);

                if (categorias != null)
                {

                    if (categorias.Rows.Count > 0)
                    {

                        radGridView_categoria.DataSource = categorias;
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_categoria()
        {

            int id = -1;

            try
            {
                id = CControl.cCategoria.Sp_registrar_categoria(
                    new Categoria()
                    {
                        Nombre = radText_nombre.Text                      
                    },
                    Sesion);

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_categoriaxnombre();
                }
                else
                {

                    RadMessageBox.Show("Problemas para registrar categoria...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }

        public void Sp_actualizar_categoria()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cCategoria.Sp_actualizar_categoria(
                    new Categoria()
                    {
                        Idcategoria = int.Parse(radText_cod.Text),
                        Nombre = radText_nombre.Text,                      
                        Estado = radDrop_estado.SelectedIndex == 0 ? 1 : 0
                    },
                    Sesion);

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_categoriaxnombre();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar categoria...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }

      
    }
}
