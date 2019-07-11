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
    public partial class RadFormAlmacen : Telerik.WinControls.UI.RadForm
    {
        private DataTable almacenes = null;
        private DataTable sucursales = null;
        public Sesion Sesion { get; set; }

        public RadFormAlmacen()
        {
            InitializeComponent();
        }

        private void RadFormAlmacen_Load(object sender, EventArgs e)
        {
            try
            {
                
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_almacen.AutoGenerateColumns = false;
                Sp_listar_sucursal();
                radDrop_estado.SelectedIndex = 0;
            }
            catch (Exception ex) {

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

        private void radText_nombre_TextChanged(object sender, EventArgs e)
        {
            radText_nombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_direccion_TextChanged(object sender, EventArgs e)
        {
            radText_direccion.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_telefono_TextChanged(object sender, EventArgs e)
        {
            radText_telefono.CharacterCasing = CharacterCasing.Upper;
        }

        private void radButton_limpiar_Click(object sender, EventArgs e)
        {
            try
            {
                radText_cod.Text = string.Empty;
                radDrop_estado.SelectedIndex = 0;
                radDrop_sucursal.SelectedIndex = 0;
                radText_nombre.Text = string.Empty;
                radText_direccion.Text = string.Empty;
                radText_telefono.Text = string.Empty;
                radGridView_almacen.DataSource = null;
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
                Sp_listar_almacen();
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

                        Sp_listar_almacenxnombre();
                    }

                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radGridView_almacen_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_almacen.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_almacen.Rows[e.RowIndex].Cells["idalmacen"].Value.ToString();
                        radDrop_sucursal.SelectedValue =int.Parse( radGridView_almacen.Rows[e.RowIndex].Cells["idsucursal"].Value.ToString());
                        radText_nombre.Text = radGridView_almacen.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                        radText_direccion.Text = radGridView_almacen.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                        radText_telefono.Text = radGridView_almacen.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                        radDrop_estado.Text = radGridView_almacen.Rows[e.RowIndex].Cells["estado"].Value.ToString();

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
                    if (radText_nombre.Text.Length > 0 && radText_direccion.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar almacen?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_almacen();
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información...", "Advertencia");
                    }
                }
                else
                {

                    if (radText_nombre.Text.Length > 0 && radText_direccion.Text.Length > 0)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar almacen?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_actualizar_almacen();
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información...", "Advertencia");
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void RadFormAlmacen_Shown(object sender, EventArgs e)
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
        /************************Mis Metodos******************************/
        public void Sp_listar_sucursal()
        {

            sucursales = null;            
            try
            {
                sucursales = CControl.cSucursal.Sp_listar_sucursal();

                if (sucursales != null)
                {

                    if (sucursales.Rows.Count > 0)
                    {
                        radDrop_sucursal.DataSource = sucursales;
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

        public void Sp_listar_almacen() {

            almacenes = null;
            radGridView_almacen.DataSource = null;

            try {

                almacenes = CControl.cAlmacen.Sp_listar_almacen();

                if (almacenes != null) {

                    if (almacenes.Rows.Count > 0) {

                        radGridView_almacen.DataSource = almacenes;

                    }
                }

            }catch(Exception ex)
            {
                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_almacenxnombre()
        {

            almacenes = null;
            radGridView_almacen.DataSource = null;

            try
            {

                almacenes = CControl.cAlmacen.Sp_listar_almacenxnombre(radText_nombre.Text.ToString());

                if (almacenes != null)
                {

                    if (almacenes.Rows.Count > 0)
                    {

                        radGridView_almacen.DataSource = almacenes;

                    }
                }

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_almacen() {

            int id = -1;
            try
            {
                id = CControl.cAlmacen.Sp_registrar_almacen(
                        new Almacen() {
                            Sucursal=new Sucursal() {
                                Idsucursal=int.Parse(radDrop_sucursal.SelectedValue.ToString())                               
                            },
                            Nombre=radText_nombre.Text,
                            Direccion=radText_direccion.Text,
                            Telefono=radText_telefono.Text

                        },
                      Sesion
                    );

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_almacenxnombre();
                }
                else {

                    RadMessageBox.Show("Problemas para registrar almacen...","Advertencia");
                }
            }
            catch (Exception ex) {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }


        public void Sp_actualizar_almacen()
        {

            int filas_afectadas = -1;
            try
            {
                filas_afectadas = CControl.cAlmacen.Sp_actualizar_almacen(
                        new Almacen()
                        {
                            Idalmacen=int.Parse(radText_cod.Text),
                            Sucursal = new Sucursal()
                            {
                                Idsucursal = int.Parse(radDrop_sucursal.SelectedValue.ToString())
                            },
                            Nombre = radText_nombre.Text,
                            Direccion = radText_direccion.Text,
                            Telefono = radText_telefono.Text,
                            Estado=radDrop_estado.SelectedIndex==0?1:0
                        },
                       Sesion
                    );

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_almacenxnombre();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar almacen...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

       
    }
}
