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
    public partial class RadFormUsuario : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        private DataTable usuarios = null;
        private List<TipoUsuario> lista_tipousuario = null;
        public RadFormUsuario()
        {
            InitializeComponent();
        }

        private void RadFormUsuario_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_usuario.AutoGenerateColumns = false;
                radDrop_estado.SelectedIndex = 0;
                Sp_listar_tipousuarioxestado();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_apellidoynombre_TextChanged(object sender, EventArgs e)
        {
            radText_apellidoynombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_cuenta_TextChanged(object sender, EventArgs e)
        {
            radText_cuenta.CharacterCasing = CharacterCasing.Upper;
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

        private void RadFormUsuario_Shown(object sender, EventArgs e)
        {
            try
            {
                radText_apellidoynombre.Focus();
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
                Sp_listar_usuario();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_apellidoynombre_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (radText_apellidoynombre.Text.Length > 0)
                    {

                        Sp_listar_usuarioxnombreyapellido();

                    }

                }
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
                radDrop_tipousuario.SelectedIndex = 0;
                radText_apellidoynombre.Text = string.Empty;
                radText_cuenta.Text = string.Empty;
                radTextBox_clave.Text = string.Empty;
                radGridView_usuario.DataSource = null;

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }

        private void radGridView_usuario_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_usuario.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_usuario.Rows[e.RowIndex].Cells["idusuario"].Value.ToString();
                        radDrop_tipousuario.SelectedValue = int.Parse(radGridView_usuario.Rows[e.RowIndex].Cells["idtipousuario"].Value.ToString());
                        radText_apellidoynombre.Text = radGridView_usuario.Rows[e.RowIndex].Cells["nombreyapellido"].Value.ToString();
                        radText_cuenta.Text = radGridView_usuario.Rows[e.RowIndex].Cells["cuenta"].Value.ToString();
                        radTextBox_clave.Text = radGridView_usuario.Rows[e.RowIndex].Cells["clave"].Value.ToString();
                        radDrop_estado.Text = radGridView_usuario.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }
        /**********************Mis Metodos**********************/
        public void Sp_listar_tipousuarioxestado()
        {

            try
            {
                lista_tipousuario = null;
                radDrop_tipousuario.DataSource = null;

                lista_tipousuario = CControl.cTipoUsuario.Sp_listar_tipousuarioxestado();

                if (lista_tipousuario != null)
                {

                    if (lista_tipousuario.Count > 0)
                    {

                        radDrop_tipousuario.DataSource = lista_tipousuario;
                        radDrop_tipousuario.DisplayMember = "Nombre";
                        radDrop_tipousuario.ValueMember = "Idtipousuario";
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_usuario()
        {

            try
            {
                usuarios = null;
                radGridView_usuario.DataSource = null;

                usuarios = CControl.cUsuario.Sp_listar_usuario();

                if (usuarios != null)
                {

                    if (usuarios.Rows.Count > 0)
                    {

                        radGridView_usuario.DataSource = usuarios;
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_usuarioxnombreyapellido()
        {

            try
            {
                usuarios = null;
                radGridView_usuario.DataSource = null;

                usuarios = CControl.cUsuario.Sp_listar_usuarioxnombreyapellido(radText_apellidoynombre.Text);

                if (usuarios != null)
                {

                    if (usuarios.Rows.Count > 0)
                    {

                        radGridView_usuario.DataSource = usuarios;
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_usuario()
        {

            int id = -1;
            try
            {

                id = CControl.cUsuario.Sp_registrar_usuario(
                    new Usuario()
                    {
                        Tipousuario=lista_tipousuario[radDrop_tipousuario.SelectedIndex],
                        Nombreyapellido=radText_apellidoynombre.Text,
                        Cuenta = radText_cuenta.Text,
                        Clave = radTextBox_clave.Text,
                    }, 
                    Sesion);

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_usuarioxnombreyapellido();
                }
                else {

                    RadMessageBox.Show("Problemas para registrar usuario...","Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_usuario()
        {

            int filas_afectadas = -1;
            try
            {

                filas_afectadas = CControl.cUsuario.Sp_actualizar_usuario(
                    new Usuario()
                    {
                        Idusuario = int.Parse(radText_cod.Text),
                        Tipousuario = lista_tipousuario[radDrop_tipousuario.SelectedIndex],
                        Nombreyapellido = radText_apellidoynombre.Text,
                        Cuenta = radText_cuenta.Text,
                        Clave = radTextBox_clave.Text,
                        Estado = radDrop_estado.SelectedIndex == 0 ? 1:0
                    },
                    Sesion);

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_usuarioxnombreyapellido();
                }
                else
                {

                    RadMessageBox.Show("Problemas para registrar usuario...", "Advertencia");
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
                    if (lista_tipousuario != null && radText_apellidoynombre.Text.Length > 0
                        && radText_cuenta.Text.Length > 0
                        && radTextBox_clave.Text.Length > 0)
                    {

                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar usuario?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_usuario();
                        }

                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }

                }
                else
                {
                    if (lista_tipousuario != null && radText_apellidoynombre.Text.Length > 0
                       && radText_cuenta.Text.Length > 0
                       && radTextBox_clave.Text.Length > 0)
                    {

                        DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar usuario?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_usuario();
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
