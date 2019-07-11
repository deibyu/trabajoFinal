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
    public partial class RadFormUsuarioAlmacen : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        private DataTable usuariosalmacenes = null;
        private DataTable usuarios = null;
        private DataTable almacenes = null;

        public RadFormUsuarioAlmacen()
        {
            InitializeComponent();
        }

        private void RadFormUsuarioAlmacen_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_usuarioalmacen.AutoGenerateColumns = false;
                radDrop_estado.SelectedIndex = 0;
                Sp_listar_usuario();
                Sp_listar_almacen();

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
                radDrop_usuario.SelectedIndex = 0;
                radDrop_almacen.SelectedIndex = 0;
                usuariosalmacenes = null;
                radGridView_usuarioalmacen.DataSource = null;
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
                Sp_listar_usuarioalmacen();
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
                    if (radDrop_usuario.SelectedValue != null && radDrop_almacen.SelectedValue != null)
                    {

                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar acceso?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_usuarioalmacen();
                        }

                    }
                }
                else
                {

                    if (radDrop_usuario.SelectedValue != null && radDrop_almacen.SelectedValue != null)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar acceso?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_usuarioalmacen();
                        }

                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }

        private void radGridView_usuarioalmacen_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_usuarioalmacen.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_usuarioalmacen.Rows[e.RowIndex].Cells["idusuarioalmacen"].Value.ToString();
                        radDrop_usuario.SelectedValue = int.Parse(radGridView_usuarioalmacen.Rows[e.RowIndex].Cells["idusuario"].Value.ToString());
                        radDrop_almacen.SelectedValue = int.Parse(radGridView_usuarioalmacen.Rows[e.RowIndex].Cells["idalmacen"].Value.ToString());
                        radDrop_estado.Text = radGridView_usuarioalmacen.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }
        /*******************************Mis Metodos**********************/

        public void Sp_listar_usuario()
        {

            try
            {
                usuarios = null;
                radDrop_usuario.DataSource = null;
                usuarios = CControl.cUsuario.Sp_listar_usuario();

                if (usuarios != null)
                {

                    if (usuarios.Rows.Count > 0)
                    {

                        radDrop_usuario.DataSource = usuarios;
                        radDrop_usuario.DisplayMember = "Cuenta";
                        radDrop_usuario.ValueMember = "Idusuario";
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_almacen()
        {

            try
            {
                almacenes = null;
                radDrop_almacen.DataSource = null;
                almacenes = CControl.cAlmacen.Sp_listar_almacen();

                if (almacenes != null)
                {

                    if (almacenes.Rows.Count > 0)
                    {

                        radDrop_almacen.DataSource = almacenes;
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

        public void Sp_listar_usuarioalmacen()
        {

            try
            {
                usuariosalmacenes = null;
                radGridView_usuarioalmacen.DataSource = null;

                usuariosalmacenes = CControl.cUsuario.Sp_listar_usuarioalmacen();

                if (usuariosalmacenes != null)
                {

                    if (usuariosalmacenes.Rows.Count > 0)
                    {

                        radGridView_usuarioalmacen.DataSource = usuariosalmacenes;
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_usuarioalmacen() {

            int id = -1;

            try {

                id = CControl.cUsuario.Sp_registrar_usuarioalmacen(
                    new Almacen() {
                        Idalmacen = int.Parse(radDrop_almacen.SelectedValue.ToString())
                    },
                    new Usuario() {
                        Idusuario = int.Parse(radDrop_usuario.SelectedValue.ToString())
                    },
                    Sesion
                    );

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...","Información");
                    Sp_listar_usuarioalmacen();

                }
                else {

                    RadMessageBox.Show("Problemas para registrar acceso...", "Información");                  
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_usuarioalmacen()
        {

            int filas_afectadas = -1;

            try
            {

                filas_afectadas = CControl.cUsuario.Sp_actualizar_usuarioalmacen(
                    
                    int.Parse(radText_cod.Text),
                    new Almacen()
                    {
                        Idalmacen = int.Parse(radDrop_almacen.SelectedValue.ToString())
                    },
                    new Usuario()
                    {
                        Idusuario = int.Parse(radDrop_usuario.SelectedValue.ToString())
                    },
                    radDrop_estado.SelectedIndex==0?1:0,
                    Sesion
                    );

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_usuarioalmacen();

                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar acceso...", "Información");
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }        
    }
}
