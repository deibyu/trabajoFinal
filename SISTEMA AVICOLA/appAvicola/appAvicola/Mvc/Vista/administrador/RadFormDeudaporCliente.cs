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
    public partial class RadFormDeudaporCliente : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        private List<Cliente> lista_cliente = null;
        private DataTable deudas = null;
        public RadFormDeudaporCliente()
        {
            InitializeComponent();
            radDrop_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            radDrop_cliente.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void RadFormDeudaporCliente_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                Sp_listar_clientexestado();
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
                if (radGridView_deudas.Rows.Count > 0)
                {
                    radGridView_deudas.MultiSelect = true;
                    radGridView_deudas.SelectAll();
                    radGridView_deudas.ClipboardCopyMode = GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataObject dataObj = radGridView_deudas.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    radGridView_deudas.MultiSelect = false;

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
                radGridView_deudas.DataSource = null;
                deudas = null;
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
                if (radDrop_cliente.SelectedValue != null)
                {
                    Sp_listar_deudaxidclientexestado_();
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
                if (radGridView_deudas.Rows.Count > 0)
                {
                    if (radGridView_deudas.CurrentCell != null)
                    {
                        if (radGridView_deudas.CurrentCell.RowIndex != -1)
                        {
                            RadFormListadeCobrosxDeuda radForm = new RadFormListadeCobrosxDeuda
                            {
                                Sesion = Sesion,
                                Deuda = new Deuda()
                                {
                                    Iddeuda = int.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["iddeuda"].Value.ToString()),
                                    Cliente = new Cliente()
                                    {
                                        Idcliente = int.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["idcliente"].Value.ToString())
                                    },
                                    Montoinicial = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montoinicial"].Value.ToString()),
                                    Montototal = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montototal"].Value.ToString()),
                                    Montocobrado = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montocobrado"].Value.ToString()),
                                    Montoactual = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montoactual"].Value.ToString()),
                                    Estado = int.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["estado"].Value.ToString())
                                }
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

        private void radButton_pagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridView_deudas.Rows.Count > 0)
                {
                    if (radGridView_deudas.CurrentCell != null)
                    {
                        if (radGridView_deudas.CurrentCell.RowIndex != -1)
                        {
                            RadFormCobro radForm = new RadFormCobro
                            {
                                Sesion = Sesion,
                                Deuda = new Deuda()
                                {
                                    Iddeuda = int.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["iddeuda"].Value.ToString()),
                                    Cliente = new Cliente()
                                    {
                                        Idcliente = int.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["idcliente"].Value.ToString())
                                    },
                                    Montoinicial = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montoinicial"].Value.ToString()),
                                    Montototal = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montototal"].Value.ToString()),
                                    Montocobrado = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montocobrado"].Value.ToString()),
                                    Montoactual = decimal.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["montoactual"].Value.ToString()),
                                    Estado = int.Parse(radGridView_deudas.Rows[radGridView_deudas.CurrentCell.RowIndex].Cells["estado"].Value.ToString())
                                }
                            };
                            radForm.ShowDialog();

                            radButton_cargar.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /**********************************************************Mis Metodos*****************************************************/
        public void Sp_listar_clientexestado()
        {

            try
            {
                lista_cliente = null;
                radDrop_cliente.DataSource = null;
                lista_cliente = CControl.cCliente.Sp_listar_clientexestado();

                if (lista_cliente != null)
                {

                    if (lista_cliente.Count > 0)
                    {

                        radDrop_cliente.DataSource = lista_cliente;
                        radDrop_cliente.ValueMember = "Idcliente";
                        radDrop_cliente.DisplayMember = "Razonsocial";
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_deudaxidclientexestado_()
        {

            try
            {
                radLabel_total.Text = "0.00";
                radGridView_deudas.DataSource = null;
                deudas = null;

                deudas = CControl.cDeuda.Sp_listar_deudaxidclientexestado_(
                    int.Parse(radDrop_cliente.SelectedValue.ToString())
                    );

                if (deudas != null)
                {

                    if (deudas.Rows.Count > 0)
                    {

                        radGridView_deudas.DataSource = deudas;
                        radLabel_total.Text = decimal.Round(deudas.AsEnumerable()
                                                .Select(x => x.Field<decimal>("montoactual"))
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
