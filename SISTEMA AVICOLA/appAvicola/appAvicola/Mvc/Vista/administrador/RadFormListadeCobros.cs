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
using System.Linq;
using Telerik.WinControls.UI;

namespace appAvicola.Mvc.Vista.administrador
{
    public partial class RadFormListadeCobros : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }

        private DataTable cobros = null;
        
        public RadFormListadeCobros()
        {
            InitializeComponent();
        }

        private void RadFormListadeCobros_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radDateTimePicker_fechainicio.Value = DateTime.Now;
                radDateTimePicker_fechafin.Value = DateTime.Now;
                radDrop_estado.SelectedIndex = 0;
                radButton_cargar.PerformClick();
                
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

        private void radButton_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridView_cobros.Rows.Count > 0)
                {
                    radGridView_cobros.MultiSelect = true;
                    radGridView_cobros.SelectAll();
                    radGridView_cobros.ClipboardCopyMode = GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataObject dataObj = radGridView_cobros.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    radGridView_cobros.MultiSelect = false;

                    RadMessageBox.Show("Puede copiarlo a cualquier editor de texto...", "Información");
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
                radGridView_cobros.DataSource = null;
                cobros = null;
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
                Sp_listar_cobroxiddeudaxfechaxestado();
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
                if (radGridView_cobros.Rows.Count > 0)
                {
                    if (radGridView_cobros.CurrentCell != null)
                    {
                        if (radGridView_cobros.CurrentCell.RowIndex != -1)
                        {
                            RadFormCobro radForm = new RadFormCobro
                            {
                                Sesion = Sesion,
                                Deuda = CControl.cDeuda.Sp_listar_deudaxiddeudaxestado(
                                        int.Parse(radGridView_cobros.Rows[radGridView_cobros.CurrentCell.RowIndex].Cells["iddeuda"].Value.ToString())
                                    ),
                                Cobro = CControl.cCobro.Sp_listar_cobroxidcobro(
                                     int.Parse(radGridView_cobros.Rows[radGridView_cobros.CurrentCell.RowIndex].Cells["idcobro"].Value.ToString())
                                ),
                                radform_listadecobros = this
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

        /*********************************Mis Metodos*************************************/
        public void Sp_listar_cobroxiddeudaxfechaxestado()
        {

            try
            {
                cobros = null;
                radGridView_cobros.DataSource = null;
                cobros = CControl.cCobro.Sp_listar_cobroxfechaxestado(                    
                     radDateTimePicker_fechainicio.Value,
                     radDateTimePicker_fechafin.Value,
                     radDrop_estado.SelectedIndex
                    );

                if (cobros != null)
                {

                    if (cobros.Rows.Count > 0)
                    {

                        radGridView_cobros.DataSource = cobros;
                        radLabel_total.Text =decimal.Round( cobros.AsEnumerable()
                                                .Where(x => x.Field<string>("estado") == "REGISTRADO")
                                                .Select(x => x.Field<decimal>("monto"))
                                                .Sum(),2).ToString();
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
