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
using System.Linq;

namespace appAvicola.Mvc.Vista.administrador
{
    public partial class RadFormListadeComprobantes : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        private DataTable comprobantes = null;
        public RadFormListadeComprobantes()
        {
            InitializeComponent();
        }

        private void RadFormListadeComprobantes_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radDateTimePicker_fechainicio.Value = DateTime.Now;
                radDateTimePicker_fechafin.Value = DateTime.Now;
                radDrop_estado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }
        private void radText_ncomprobante_KeyPress(object sender, KeyPressEventArgs e)
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
                radGridView_comprobantes.DataSource = null;
                comprobantes = null;
                radText_ncomprobante.Text = string.Empty;
                radDateTimePicker_fechainicio.Value = DateTime.Now;
                radDateTimePicker_fechafin.Value = DateTime.Now;
                radDrop_estado.SelectedIndex = 0;
                radLabel_total.Text = "0.00";

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
                Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }
        private void radText_ncomprobante_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (radText_ncomprobante.Text.Length > 0)
                    {

                        radButton_cargar.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridView_comprobantes.Rows.Count > 0)
                {
                    radGridView_comprobantes.MultiSelect = true;
                    radGridView_comprobantes.SelectAll();
                    radGridView_comprobantes.ClipboardCopyMode = GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataObject dataObj = radGridView_comprobantes.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    radGridView_comprobantes.MultiSelect = false;

                    RadMessageBox.Show("Puede copiarlo a cualquier editor de texto...", "Información");
                }

            }
            catch (Exception ex) {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /**********************************************Mis Metodos**********************************/
        public void Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado() {

            try
            {
                radLabel_total.Text = "0.00";
                radGridView_comprobantes.DataSource = null;
                comprobantes = null;

                comprobantes = CControl.cComprobante.Sp_listar_comprobantexidalmacenxfechaxncomprobantexestado(
                       Sesion.Almacen.Idalmacen,
                       radDateTimePicker_fechainicio.Value,
                       radDateTimePicker_fechafin.Value,
                       radText_ncomprobante.Text,
                       radDrop_estado.SelectedIndex
                    );

                if (comprobantes!=null) {

                    if (comprobantes.Rows.Count > 0) {

                        radGridView_comprobantes.DataSource = comprobantes;
                        radLabel_total.Text = decimal.Round(comprobantes.AsEnumerable()
                                                .Where(x => x.Field<string>("estado") == "REGISTRADO")
                                                .Select(x => x.Field<decimal>("total"))
                                                .Sum(),2).ToString();

                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_ver_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridView_comprobantes.Rows.Count > 0)
                {
                    if (radGridView_comprobantes.CurrentCell != null) {

                        if (radGridView_comprobantes.CurrentCell.RowIndex != -1) {


                            RadFormComprobante radForm = new RadFormComprobante
                            {
                                Sesion = Sesion,                        
                                comprobante=CControl.cComprobante.Sp_listar_comprobantexidcomprobante(
                                    int.Parse(radGridView_comprobantes.Rows[radGridView_comprobantes.CurrentCell.RowIndex].Cells["idcomprobante"].Value.ToString())    
                                ),
                                lista_detallecomprobante= CControl.cComprobante.Sp_listar_detallecomprobantexidcomprobante(
                                    int.Parse(radGridView_comprobantes.Rows[radGridView_comprobantes.CurrentCell.RowIndex].Cells["idcomprobante"].Value.ToString())
                                ),
                                radform_listadecomprobantes=this
                            };
                            radForm.ShowDialog();
                        }
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
