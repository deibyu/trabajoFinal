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
    public partial class RadFormSerie : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        private List<Almacen> lista_almacen = null;
        private List<TipoComprobante> lista_tipocomprobante = null;
        private DataTable series = null;
        public RadFormSerie()
        {
            InitializeComponent();
        }

        private void RadFormSerie_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radDrop_estado.SelectedIndex = 0;
                Sp_listar_almacenxestado();
                Sp_listar_tipocomprobantexestado();


            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }
        private void radText_serie_TextChanged(object sender, EventArgs e)
        {
            try
            {
                radText_serie.CharacterCasing = CharacterCasing.Upper;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_correlativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
                radDrop_almacen.SelectedIndex = 0;
                radDrop_tipocomprobante.SelectedIndex = 0;
                radText_serie.Text = string.Empty;
                radText_correlativo.Text = string.Empty;
                radGridView_serie.DataSource = null;
                series = null;
                radText_serie.Focus();
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

                Sp_listar_seriexidalmacenxidtipocomprobante();
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
                    if (radText_serie.Text.Length == 4 && radText_correlativo.Text.Length > 0)
                    {

                        if (Es_numero(radText_correlativo.Text))
                        {
                            DialogResult respuesta = RadMessageBox.Show("¿Desea registrar serie?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                            if (respuesta == DialogResult.Yes)
                            {

                                Sp_registrar_serie();
                            }
                        }
                        else
                        {

                            RadMessageBox.Show("El valor ingresado no es un número...", "Advertencia");
                        }
                    }
                    else
                    {
                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {
                    if (radText_serie.Text.Length == 4 && radText_correlativo.Text.Length > 0)
                    {

                        if (Es_numero(radText_correlativo.Text))
                        {
                            DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar serie?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                            if (respuesta == DialogResult.Yes)
                            {

                                Sp_actualizar_serie();
                            }
                        }
                        else
                        {

                            RadMessageBox.Show("El valor ingresado no es un número...", "Advertencia");
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

        private void RadFormSerie_Shown(object sender, EventArgs e)
        {
            try
            {

                radText_serie.Focus();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radGridView_serie_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_serie.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_serie.Rows[e.RowIndex].Cells["idserie"].Value.ToString();
                        radDrop_almacen.SelectedValue =int.Parse(radGridView_serie.Rows[e.RowIndex].Cells["idalmacen"].Value.ToString());
                        radDrop_tipocomprobante.SelectedValue = int.Parse(radGridView_serie.Rows[e.RowIndex].Cells["idtipocomprobante"].Value.ToString());
                        radText_serie.Text = radGridView_serie.Rows[e.RowIndex].Cells["nserie"].Value.ToString();
                        radText_correlativo.Text = radGridView_serie.Rows[e.RowIndex].Cells["ncorrelativo"].Value.ToString();
                        radDrop_estado.Text = radGridView_serie.Rows[e.RowIndex].Cells["estado"].Value.ToString();

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /********************************Mis Metodos*************************************************/
        public void Sp_listar_almacenxestado()
        {

            try
            {
                lista_almacen = null;
                radDrop_almacen.DataSource = null;

                lista_almacen = CControl.cAlmacen.Sp_listar_almacenxestado();

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

        public void Sp_listar_tipocomprobantexestado()
        {

            try
            {
                lista_tipocomprobante = null;
                radDrop_tipocomprobante.DataSource = null;

                lista_tipocomprobante = CControl.cTipoComprobante.Sp_listar_tipocomprobantexestado();

                if (lista_tipocomprobante != null)
                {

                    if (lista_tipocomprobante.Count > 0)
                    {

                        radDrop_tipocomprobante.DataSource = lista_tipocomprobante;
                        radDrop_tipocomprobante.DisplayMember = "Sigla";
                        radDrop_tipocomprobante.ValueMember = "Idtipocomprobante";
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_seriexidalmacenxidtipocomprobante()
        {

            try
            {

                series = null;
                radGridView_serie.DataSource = null;

                series = CControl.cSerie.Sp_listar_seriexidalmacenxidtipocomprobante(
                        int.Parse(radDrop_almacen.SelectedValue.ToString()),
                        int.Parse(radDrop_tipocomprobante.SelectedValue.ToString())
                    );

                if (series != null)
                {

                    if (series.Rows.Count > 0)
                    {

                        radGridView_serie.DataSource = series;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_serie()
        {

            int id = -1;

            try
            {
                id = CControl.cSerie.Sp_registrar_serie(
                        new Serie()
                        {
                            Almacen = new Almacen()
                            {
                                Idalmacen = int.Parse(radDrop_almacen.SelectedValue.ToString())
                            },
                            Tipocomprobante = new TipoComprobante()
                            {
                                Idtipocomprobante = int.Parse(radDrop_tipocomprobante.SelectedValue.ToString())
                            },
                            Nserie = radText_serie.Text,
                            Ncorrelativo = int.Parse(radText_correlativo.Text)
                        },
                        Sesion
                    );

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_seriexidalmacenxidtipocomprobante();
                }
                else
                {

                    RadMessageBox.Show("Problemas para registrar serie...", "Información");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_serie()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cSerie.Sp_actualizar_serie(
                        new Serie()
                        {
                            Idserie = int.Parse(radText_cod.Text),
                            Almacen = new Almacen()
                            {
                                Idalmacen = int.Parse(radDrop_almacen.SelectedValue.ToString())
                            },
                            Tipocomprobante = new TipoComprobante()
                            {
                                Idtipocomprobante = int.Parse(radDrop_tipocomprobante.SelectedValue.ToString())
                            },
                            Nserie = radText_serie.Text,
                            Ncorrelativo = int.Parse(radText_correlativo.Text),
                            Estado = radDrop_estado.SelectedIndex == 0 ? 1 : 0
                        },
                        Sesion
                    );


                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_seriexidalmacenxidtipocomprobante();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar serie...", "Información");
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }


        public bool Es_numero(object Expression)
        {
            try
            {
                bool isNum;
                double retNum;
                isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
                return isNum;
            }
            catch (Exception) { return false; }
        }      
    }
}
