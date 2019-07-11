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
using System.Drawing.Printing;
using appAvicola.Mvc.Vista.reporte;

namespace appAvicola.Mvc.Vista.administrador
{
    public partial class RadFormComprobante : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        public Comprobante comprobante { get; set; }
        public List<DetalleComprobante> lista_detallecomprobante { get; set; }
        public RadFormListadeComprobantes radform_listadecomprobantes { get; set; }
        public RadFormListadeComprobantesporCliente radform_listadecomprobantesxcliente { get; set; }

        private List<Categoria> lista_categoria = null;
        private List<UnidadEquivalente> lista_unidadequivalente = null;
        private List<Precio> lista_precio = null;
        private List<TipoComprobante> lista_tipocomprobante = null;
        private List<Serie> lista_serie = null;
        private List<Cliente> lista_cliente = null;
        private Deuda deuda = null;
        private DataTable productos = null;
        private DataSet data = null;

        public RadFormComprobante()
        {
            InitializeComponent();

            radDrop_producto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            radDrop_producto.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

            radDrop_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            radDrop_cliente.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        private void RadFormComprobante_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                Sp_listar_categoriaxestado();
                Sp_listar_tipocomprobantexestado();
                Sp_listar_clientexestado();
                radDateTimePicker_fechaemision.Value = DateTime.Now;

                if (radform_listadecomprobantes != null || radform_listadecomprobantesxcliente != null)
                {

                    radButton_limpiar.Enabled = false;
                    radDrop_tipocomprobante.Enabled = false;
                    radDrop_serie.Enabled = false;
                    radDateTimePicker_fechaemision.Enabled = false;
                    radDrop_cliente.Enabled = false;
                    Ver_Comprobante();
                    WindowState = FormWindowState.Normal;
                    StartPosition = FormStartPosition.CenterScreen;
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }
        private void radDrop_categoria_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (radDrop_categoria.SelectedValue != null)
                {

                    Sp_listar_productoxcategoriaxestadoxnombre();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radDrop_producto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (radDrop_producto.SelectedValue != null)
                {
                    if (radDrop_producto.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        Sp_listar_unidadequivalentexproductoxestado();
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }
        private void radDrop_unidadventa_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (radDrop_unidadventa.SelectedItem != null)
                {
                    Sp_listar_precioxidunidadequivalentexestado();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radDrop_tipoprecio_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (radDrop_tipoprecio.SelectedItem != null)
                {
                    if (lista_precio != null)
                    {

                        if (lista_precio.Count > 0)
                        {

                            radText_precio.Text = decimal.Round(lista_precio[radDrop_tipoprecio.SelectedIndex].Valor, 2).ToString();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }


                if (e.KeyChar == '.' && (sender as RadTextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (!char.IsControl(e.KeyChar))
                {

                    RadTextBox textBox = (RadTextBox)sender;

                    if (textBox.Text.IndexOf('.') > -1 &&
                             textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                    {
                        e.Handled = true;
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void RadFormComprobante_Shown(object sender, EventArgs e)
        {
            try
            {
                radDrop_categoria.Focus();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }


                if (e.KeyChar == '.' && (sender as RadTextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (!char.IsControl(e.KeyChar))
                {

                    RadTextBox textBox = (RadTextBox)sender;

                    if (textBox.Text.IndexOf('.') > -1 &&
                             textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                    {
                        e.Handled = true;
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_pesobruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }


                if (e.KeyChar == '.' && (sender as RadTextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (!char.IsControl(e.KeyChar))
                {

                    RadTextBox textBox = (RadTextBox)sender;

                    if (textBox.Text.IndexOf('.') > -1 &&
                             textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                    {
                        e.Handled = true;
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_tara_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }


                if (e.KeyChar == '.' && (sender as RadTextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (!char.IsControl(e.KeyChar))
                {

                    RadTextBox textBox = (RadTextBox)sender;

                    if (textBox.Text.IndexOf('.') > -1 &&
                             textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                    {
                        e.Handled = true;
                    }

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

        private void radText_precio_Leave(object sender, EventArgs e)
        {
            try
            {
                if (radText_precio.Text.Length == 0)
                {

                    if (radDrop_tipoprecio.SelectedItem != null)
                    {
                        if (lista_precio != null)
                        {
                            if (lista_precio.Count > 0)
                            {

                                radText_precio.Text = lista_precio[radDrop_tipoprecio.SelectedIndex].Valor.ToString();
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_cantidad_Leave(object sender, EventArgs e)
        {
            try
            {
                if (radText_cantidad.Text.Length == 0)
                {
                    radText_cantidad.Text = "0.00";
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_pesobruto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (radText_pesobruto.Text.Length == 0)
                {
                    radText_pesobruto.Text = "0.00";
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_tara_Leave(object sender, EventArgs e)
        {
            try
            {
                if (radText_tara.Text.Length == 0)
                {
                    radText_tara.Text = "0.00";
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_pesobruto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radText_pesobruto.Text.Length > 0)
                {
                    Calcular_PesoNeto();
                    Calcular_PrecioTotal();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_tara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radText_tara.Text.Length > 0)
                {
                    Calcular_PesoNeto();
                    Calcular_PrecioTotal();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_precio_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (radText_precio.Text.Length > 0)
                {
                    Calcular_PrecioTotal();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_cantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radText_cantidad.Text.Length > 0)
                {
                    Calcular_PrecioTotal();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radText_correlativo.Text.Length == 0)
                {
                    //radText_cantidad.Text.Length > 0 && decimal.Parse(radText_cantidad.Text) > 0 &&
                    if (radText_precio.Text.Length > 0
                        && radText_pesobruto.Text.Length > 0 && radText_tara.Text.Length > 0)
                    {
                        if (Es_numero(radText_cantidad.Text) && Es_numero(radText_precio.Text)
                            && Es_numero(radText_pesobruto.Text) && Es_numero(radText_tara.Text))
                        {
                            if (decimal.Parse(radText_precio.Text) > 0)
                            {
                                Agregar_DetalleComprobante();
                            }
                            else
                            {

                                RadMessageBox.Show(" Und/P.Unit deben ser mayor a cero (0) ...", "Advertencia");
                            }
                        }
                        else
                        {

                            RadMessageBox.Show("Valor ingresado no es número ...", "Advertencia");
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada Und/P.Unit...", "Advertencia");
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
                comprobante = null;
                lista_serie = null;
                lista_detallecomprobante = null;
                radText_correlativo.Text = string.Empty;

                radDrop_categoria.SelectedValue = 1;
                radDrop_unidadventa.SelectedIndex = 0;
                radDrop_tipocomprobante.SelectedValue = 2;
                radDrop_cliente.SelectedValue = 1;
                radText_cantidad.Text = "0.00";
                radText_pesobruto.Text = "0.00";
                radText_tara.Text = "0.00";
                radTex_pesoneto.Text = "0.00";
                radText_preciototal.Text = "0.00";
                radText_totalventa.Text = "0.00";
                radText_deudainicial.Text = "0.00";
                radText_deudaacumulada.Text = "0.00";
                radText_montocobrado.Text = "0.00";
                radText_deudaactual.Text = "0.00";
                radGridView_detallecomprobante.DataSource = null;
                radDateTimePicker_fechaemision.Value = DateTime.Now;
                radCheck_redondeo.Checked = false;
                txtGlosa.Text = "";
                radDrop_categoria.Focus();


            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radGridView_detallecomprobante_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {

            try
            {
                if (radGridView_detallecomprobante.Rows.Count > 0)
                {
                    if (radText_correlativo.Text.Length == 0)
                    {
                        if (e.RowIndex != -1)
                        {
                            DialogResult respuesta = RadMessageBox.Show("¿Desea quitar producto?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                            if (respuesta == DialogResult.Yes)
                            {
                                if (radGridView_detallecomprobante.Rows.Count == 1)
                                {
                                    radButton_limpiar.PerformClick();
                                }
                                else
                                {
                                    if (lista_detallecomprobante != null)
                                    {
                                        if (lista_detallecomprobante.Count > 0)
                                        {
                                            lista_detallecomprobante.RemoveAt(e.RowIndex);

                                            for (int i = 0; i < lista_detallecomprobante.Count; i++)
                                            {

                                                lista_detallecomprobante[i].Iddetallecomprobante = i + 1;
                                            }

                                            Crear_Tabla();
                                        }
                                    }
                                }
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radDrop_tipocomprobante_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (radDrop_tipocomprobante.SelectedValue != null)
                {
                    if (radDrop_tipocomprobante.SelectedValue.ToString() != "appAvicola.Mvc.Clases.TipoComprobante")
                    {
                        if (radText_correlativo.Text.Length == 0)
                        {
                            Sp_listar_seriexidalmacenxidtipocomprobantexestado();

                            if (int.Parse(radDrop_tipocomprobante.SelectedValue.ToString()) == 1)
                            {

                                radText_totalventa.ReadOnly = false;
                            }
                            else
                            {

                                radText_totalventa.ReadOnly = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_totalventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }


                if (e.KeyChar == '.' && (sender as RadTextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (!char.IsControl(e.KeyChar))
                {

                    RadTextBox textBox = (RadTextBox)sender;

                    if (textBox.Text.IndexOf('.') > -1 &&
                             textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                    {
                        e.Handled = true;
                    }

                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_totalventa_Leave(object sender, EventArgs e)
        {
            try
            {
                if (radText_totalventa.Text.Length == 0)
                {
                    radText_totalventa.Text = "0.00";
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
                if (radText_correlativo.Text.Length == 0)
                {
                    if (radDrop_tipocomprobante.SelectedValue != null
                        && radDrop_serie.SelectedValue != null
                        && radDrop_cliente.SelectedValue != null
                        && radDrop_producto.SelectedValue != null)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar comprobante?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_registrar_comprobante();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void radButton_recargarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (radText_correlativo.Text.Length == 0)
                {
                    Sp_listar_categoriaxestado();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_recargarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (radText_correlativo.Text.Length == 0)
                {
                    Sp_listar_clientexestado();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_anular_Click(object sender, EventArgs e)
        {
            try
            {
                if (comprobante != null)
                {
                    if (comprobante.Estado == 1)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea anular comprobante?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_anular_comprobantexidcomprobante();
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Comprobante se encuentra anulado...", "Advertencia");
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

                if (radText_correlativo.Text.Length != 0)
                {

                    if (comprobante != null)
                    {

                        if (comprobante.Estado == 1)
                        {
                            if (deuda != null)
                            {

                                if (deuda.Montoactual > 0)
                                {
                                    RadFormCobro radForm = new RadFormCobro
                                    {
                                        Sesion = Sesion,
                                        Deuda = deuda
                                    };
                                    radForm.ShowDialog();
                                    radButton_impirmir.PerformClick();
                                }

                                deuda = CControl.cDeuda.Sp_listar_deudaxidclientexestado(comprobante.Cliente.Idcliente);

                                if (deuda != null)
                                {
                                    radText_deudainicial.Text = deuda.Montoinicial.ToString();
                                    radText_deudaacumulada.Text = deuda.Montototal.ToString();
                                    radText_montocobrado.Text = deuda.Montocobrado.ToString();
                                    radText_deudaactual.Text = deuda.Montoactual.ToString();
                                }
                                else
                                {

                                    RadMessageBox.Show("Problemas para cargar deuda..", "Advertencia");
                                }
                            }
                        }
                        else
                        {

                            RadMessageBox.Show("Comprobante se encuentra anulado...", "Advertencia");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radCheck_redondeo_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            try
            {
                if (radText_correlativo.Text.Length == 0)
                {
                    if (radCheck_redondeo.Checked)
                    {
                        if (radText_totalventa.Text.Length > 0)
                        {
                            if (Es_numero(radText_totalventa.Text))
                            {
                                if (decimal.Parse(radText_totalventa.Text) > 0)
                                {

                                    radText_totalventa.Text = (decimal.Round((decimal.Parse(radText_totalventa.Text) * 2), MidpointRounding.AwayFromZero) / 2).ToString();
                                }
                            }
                            else
                            {

                                radText_totalventa.Text = "0.00";
                            }
                        }
                        else
                        {

                            radText_totalventa.Text = "0.00";
                        }
                    }
                    else
                    {

                        if (radGridView_detallecomprobante.Rows.Count > 0)
                        {

                            if (lista_detallecomprobante != null)
                            {

                                radText_totalventa.Text = lista_detallecomprobante.Select(x => x.Total).Sum().ToString();
                            }
                            else
                            {

                                radText_totalventa.Text = "0.00";
                            }
                        }
                        else
                        {

                            radText_totalventa.Text = "0.00";
                        }
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
                if (radGridView_detallecomprobante.Rows.Count > 0)
                {
                    radGridView_detallecomprobante.MultiSelect = true;
                    radGridView_detallecomprobante.SelectAll();
                    radGridView_detallecomprobante.ClipboardCopyMode = GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataObject dataObj = radGridView_detallecomprobante.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    radGridView_detallecomprobante.MultiSelect = false;

                    RadMessageBox.Show("Puede copiarlo a cualquier editor de texto...", "Información");
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
        public void Sp_listar_categoriaxestado()
        {

            try
            {
                lista_categoria = null;
                radDrop_categoria.DataSource = null;

                lista_categoria = CControl.cCategoria.Sp_listar_categoriaxestado();

                if (lista_categoria != null)
                {

                    if (lista_categoria.Count > 0)
                    {

                        radDrop_categoria.DataSource = lista_categoria;
                        radDrop_categoria.ValueMember = "Idcategoria";
                        radDrop_categoria.DisplayMember = "Nombre";
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_productoxcategoriaxestadoxnombre()
        {

            try
            {
                productos = null;
                radDrop_producto.DataSource = null;

                productos = CControl.cProducto.Sp_listar_productoxcategoriaxestadoxnombre(
                        lista_categoria[radDrop_categoria.SelectedIndex],
                        ""
                    );
                if (productos != null)
                {
                    if (productos.Rows.Count > 0)
                    {
                        radDrop_producto.DataSource = productos;
                        radDrop_producto.ValueMember = "idproducto";
                        radDrop_producto.DisplayMember = "prnombre";
                    }
                }


            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_unidadequivalentexproductoxestado()
        {

            try
            {
                lista_unidadequivalente = null;
                radDrop_unidadventa.Items.Clear();

                lista_unidadequivalente = CControl.cUnidadEquivalente.Sp_listar_unidadequivalentexproductoxestado(
                        int.Parse(radDrop_producto.SelectedValue.ToString())
                    );

                if (lista_unidadequivalente != null)
                {

                    if (lista_unidadequivalente.Count > 0)
                    {

                        foreach (UnidadEquivalente uq in lista_unidadequivalente)
                        {

                            if (uq.Tipounidad.Idtipounidad == 3)
                            {
                                radDrop_unidadventa.Items.Add(uq.Unidadmedida.Sigla);
                            }
                        }

                        radDrop_unidadventa.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_precioxidunidadequivalentexestado()
        {
            try
            {
                lista_precio = null;
                radDrop_tipoprecio.Items.Clear();

                lista_precio = CControl.cPrecio.Sp_listar_precioxidunidadequivalentexestado(Obtener_UnidadEquivalente());

                if (lista_precio != null)
                {

                    if (lista_precio.Count > 0)
                    {

                        foreach (Precio p in lista_precio)
                        {

                            radDrop_tipoprecio.Items.Add(p.Tipoprecio.Nombre);
                        }

                        radDrop_tipoprecio.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public bool Es_numero(object Expression)
        {
            bool isNum;
            double retNum;

            try
            {
                isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
                return isNum;
            }
            catch (Exception) { return false; }
        }

        public void Calcular_PesoNeto()
        {

            decimal pesobruto = 0.00m;
            decimal pesotara = 0.00m;
            decimal pesoneto = 0.00m;

            try
            {

                pesobruto = decimal.Parse(radText_pesobruto.Text);
                pesotara = decimal.Parse(radText_tara.Text);
                pesoneto = pesobruto - pesotara;
                radTex_pesoneto.Text = decimal.Round(pesoneto, 2).ToString();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }
        public void Calcular_PrecioTotal()
        {
            decimal preciounit = 0.00m;
            decimal unidad = 0.00m;
            decimal pesoneto = 0.00m;
            decimal preciototal = 0.00m;
            try
            {
                preciounit = decimal.Parse(radText_precio.Text);
                unidad = decimal.Parse(radText_cantidad.Text);
                pesoneto = decimal.Parse(radTex_pesoneto.Text);

                if (pesoneto == 0.00m)
                {
                    preciototal = preciounit * unidad;
                }
                else
                {

                    preciototal = pesoneto * preciounit;
                }

                radText_preciototal.Text = decimal.Round(preciototal, 2).ToString();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }

        public void Agregar_DetalleComprobante()
        {

            try
            {


                if (lista_detallecomprobante == null)
                {
                    lista_detallecomprobante = new List<DetalleComprobante>()
                    {
                        new DetalleComprobante(){

                            Iddetallecomprobante=1,
                            Producto=new Producto(){
                                Idproducto=int.Parse(radDrop_producto.SelectedValue.ToString()),
                                Nombre=radDrop_producto.Text
                            },
                            Unidadequivalente=new UnidadEquivalente(){
                                Idunidadequivalente=Obtener_UnidadEquivalente(),
                                Unidadmedida=new UnidadMedida(){
                                    Sigla=radDrop_unidadventa.Text
                                }
                            },
                            Nunidad=decimal.Parse(radText_cantidad.Text),
                            Pbruto=decimal.Parse(radText_pesobruto.Text),
                            Ptara=decimal.Parse(radText_tara.Text),
                            Pneto=decimal.Parse(radTex_pesoneto.Text),
                            Preciounitario=decimal.Parse(radText_precio.Text),
                            Subtotal=decimal.Round((decimal.Parse(radText_preciototal.Text)/1.18m),2),
                            Igv=decimal.Round((decimal.Parse(radText_preciototal.Text)/1.18m)*0.18m,2),
                            Total=decimal.Parse(radText_preciototal.Text)
                        }
                    };
                }
                else
                {

                    lista_detallecomprobante.Add(new DetalleComprobante()
                    {

                        Iddetallecomprobante = lista_detallecomprobante.Count + 1,
                        Producto = new Producto()
                        {
                            Idproducto = int.Parse(radDrop_producto.SelectedValue.ToString()),
                            Nombre = radDrop_producto.Text
                        },
                        Unidadequivalente = new UnidadEquivalente()
                        {
                            Idunidadequivalente = Obtener_UnidadEquivalente(),
                            Unidadmedida = new UnidadMedida()
                            {
                                Sigla = radDrop_unidadventa.Text
                            }
                        },
                        Nunidad = decimal.Parse(radText_cantidad.Text),
                        Pbruto = decimal.Parse(radText_pesobruto.Text),
                        Ptara = decimal.Parse(radText_tara.Text),
                        Pneto = decimal.Parse(radTex_pesoneto.Text),
                        Preciounitario = decimal.Parse(radText_precio.Text),
                        Subtotal = decimal.Round((decimal.Parse(radText_preciototal.Text) / 1.18m), 2),
                        Igv = decimal.Round((decimal.Parse(radText_preciototal.Text) / 1.18m) * 0.18m, 2),
                        Total = decimal.Parse(radText_preciototal.Text)
                    });
                }

                Crear_Tabla();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Crear_Tabla()
        {

            DataTable tabla = null;
            DataRow fila = null;
            decimal suma = 0;
            try
            {
                if (lista_detallecomprobante != null)
                {

                    if (lista_detallecomprobante.Count > 0)
                    {

                        tabla = new DataTable();
                        tabla.Columns.Add("item");
                        tabla.Columns.Add("producto");
                        tabla.Columns.Add("cantidad");
                        tabla.Columns.Add("umedida");
                        tabla.Columns.Add("pesobruto");
                        tabla.Columns.Add("pesotara");
                        tabla.Columns.Add("pesoneto");
                        tabla.Columns.Add("preciounitario");
                        tabla.Columns.Add("preciototal");

                        foreach (DetalleComprobante dt in lista_detallecomprobante)
                        {

                            fila = tabla.NewRow();
                            fila["item"] = dt.Iddetallecomprobante.ToString();
                            fila["producto"] = dt.Producto.Nombre.ToString();
                            fila["cantidad"] = dt.Nunidad.ToString();
                            fila["umedida"] = dt.Unidadequivalente.Unidadmedida.Sigla.ToString();
                            fila["pesobruto"] = dt.Pbruto.ToString();
                            fila["pesotara"] = dt.Ptara.ToString();
                            fila["pesoneto"] = dt.Pneto.ToString();
                            fila["preciounitario"] = dt.Preciounitario.ToString();
                            fila["preciototal"] = dt.Total.ToString();

                            suma += dt.Total;

                            tabla.Rows.Add(fila);
                        }

                        radGridView_detallecomprobante.DataSource = tabla;
                        radText_totalventa.Text = decimal.Round(suma, 2).ToString();

                       // radDrop_categoria.SelectedValue = 1;
                        radDrop_unidadventa.SelectedIndex = 0;
                        radText_cantidad.Text = "0.00";
                        radText_pesobruto.Text = "0.00";
                        radText_tara.Text = "0.00";
                        radTex_pesoneto.Text = "0.00";
                        radText_preciototal.Text = "0.00";
                        radDrop_categoria.Focus();
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
                        radDrop_tipocomprobante.DisplayMember = "Nombre";
                        radDrop_tipocomprobante.ValueMember = "Idtipocomprobante";
                        radDrop_tipocomprobante.SelectedValue = 2;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_seriexidalmacenxidtipocomprobantexestado()
        {

            try
            {
                lista_serie = null;
                radDrop_serie.DataSource = null;
                lista_serie = CControl.cSerie.Sp_listar_seriexidalmacenxidtipocomprobantexestado(
                    Sesion.Almacen.Idalmacen, int.Parse(radDrop_tipocomprobante.SelectedValue.ToString()));

                if (lista_serie != null)
                {

                    if (lista_serie.Count > 0)
                    {

                        radDrop_serie.DataSource = lista_serie;
                        radDrop_serie.ValueMember = "Idserie";
                        radDrop_serie.DisplayMember = "Nserie";
                    }
                }


            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public int Obtener_UnidadEquivalente()
        {

            int idunidadequivalente = -1;
            try
            {
                idunidadequivalente = int.Parse(
                                               lista_unidadequivalente.Where(
                                                                          x => x.Unidadmedida.Sigla == radDrop_unidadventa.Text &&
                                                                          x.Tipounidad.Idtipounidad == 3 &&
                                                                          x.Producto.Idproducto == int.Parse(radDrop_producto.SelectedValue.ToString())
                                                                          ).Select(x => x.Idunidadequivalente).ToList()[0].ToString());
                return idunidadequivalente;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
                return -1;
            }
        }
        public void Sp_registrar_comprobante()
        {
            int id = -1;
            bool correcto = false;
            try
            {
                deuda = null;

                if (radDrop_tipocomprobante.SelectedValue != null)
                {
                    if (radDrop_tipocomprobante.SelectedValue.ToString() != "appAvicola.Mvc.Clases.TipoComprobante")
                    {
                        if (int.Parse(radDrop_tipocomprobante.SelectedValue.ToString()) == 1)
                        {
                            if (radText_totalventa.Text.Length > 0)
                            {
                                if (Es_numero(radText_totalventa.Text))
                                {
                                    if (decimal.Parse(radText_totalventa.Text) > 0)
                                    {
                                        comprobante = new Comprobante()
                                        {
                                            Serie = new Serie()
                                            {
                                                Idserie = int.Parse(radDrop_serie.SelectedValue.ToString())
                                            },
                                            Fechaemision = radDateTimePicker_fechaemision.Value,
                                            Cliente = new Cliente()
                                            {
                                                Idcliente = int.Parse(radDrop_cliente.SelectedValue.ToString())
                                            },
                                            Subtotal = decimal.Round((decimal.Parse(radText_totalventa.Text) / 1.18m), 2),
                                            Igv = decimal.Round(((decimal.Parse(radText_totalventa.Text) / 1.18m) * 0.18m), 2),
                                            Total = decimal.Parse(radText_totalventa.Text),
                                            Glosa = txtGlosa.Text
                                        };
                                        comprobante.Lista_detallecomprobante = new List<DetalleComprobante>()
                                        {
                                            new DetalleComprobante() {

                                                Producto=new Producto()
                                                {
                                                    Idproducto=int.Parse(radDrop_producto.SelectedValue.ToString())
                                                },
                                                Unidadequivalente=new UnidadEquivalente(){
                                                    Idunidadequivalente=Obtener_UnidadEquivalente()
                                                },
                                                Nunidad=0.00m,
                                                Pbruto=0.00m,
                                                Ptara=0.00m,
                                                Pneto=0.00m,
                                                Preciounitario=0.00m,
                                                Subtotal=0.00m,
                                                Igv=0.00m,
                                                Total=0.00m
                                            }
                                        };

                                        correcto = true;
                                    }
                                    else
                                    {

                                        RadMessageBox.Show("Total venta del cliente debe ser mayor a cero (0)...", "Advertencia");
                                    }
                                }
                                else
                                {

                                    RadMessageBox.Show("Total venta del cliente no es un número...", "Advertencia");
                                }
                            }
                            else
                            {

                                RadMessageBox.Show("Ingrese total venta del cliente...", "Advertencia");
                            }
                        }
                        else
                        {

                            if (radGridView_detallecomprobante.Rows.Count > 0)
                            {
                                comprobante = new Comprobante()
                                {
                                    Serie = new Serie()
                                    {
                                        Idserie = int.Parse(radDrop_serie.SelectedValue.ToString())
                                    },
                                    Fechaemision = radDateTimePicker_fechaemision.Value,
                                    Cliente = new Cliente()
                                    {
                                        Idcliente = int.Parse(radDrop_cliente.SelectedValue.ToString())
                                    },
                                    Subtotal = decimal.Round((decimal.Parse(radText_totalventa.Text) / 1.18m), 2),
                                    Igv = decimal.Round(((decimal.Parse(radText_totalventa.Text) / 1.18m) * 0.18m), 2),
                                    Total = decimal.Parse(radText_totalventa.Text),
                                    Glosa = txtGlosa.Text
                                };

                                comprobante.Lista_detallecomprobante = lista_detallecomprobante;

                                correcto = true;
                            }
                        }

                        if (correcto)
                        {
                            id = CControl.cComprobante.Sp_registrar_comprobante(comprobante, Sesion);

                            if (id > 0)
                            {
                                comprobante = CControl.cComprobante.Sp_listar_comprobantexidcomprobante(id);

                                if (comprobante != null)
                                {
                                    radText_correlativo.Text = comprobante.Ncomprobante;
                                    deuda = CControl.cDeuda.Sp_listar_deudaxidclientexestado(comprobante.Cliente.Idcliente);

                                    if (deuda != null)
                                    {
                                        radText_deudainicial.Text = deuda.Montoinicial.ToString();
                                        radText_deudaacumulada.Text = deuda.Montototal.ToString();
                                        radText_montocobrado.Text = deuda.Montocobrado.ToString();
                                        radText_deudaactual.Text = deuda.Montoactual.ToString();

                                        RadMessageBox.Show("Registro correcto...", "Información");
                                        radButton_pagar.PerformClick();
                                    }
                                    else
                                    {

                                        RadMessageBox.Show("Problemas para cargar deuda..", "Advertencia");
                                    }


                                }
                                else
                                {

                                    RadMessageBox.Show("Problemas para cargar comprobante..", "Advertencia");
                                }
                            }
                            else
                            {

                                RadMessageBox.Show("Problemas para registrar comprobante...", "Advertencia");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }


        public void Ver_Comprobante()
        {

            try
            {
                if (comprobante != null)
                {
                    Crear_Tabla();

                    radDrop_tipocomprobante.SelectedValue = comprobante.Serie.Tipocomprobante.Idtipocomprobante;
                    radDrop_serie.SelectedValue = comprobante.Serie.Idserie;
                    radDateTimePicker_fechaemision.Value = comprobante.Fechaemision;
                    radText_correlativo.Text = comprobante.Ncomprobante;
                    radDrop_cliente.SelectedValue = comprobante.Cliente.Idcliente;
                    radText_totalventa.Text = comprobante.Total.ToString();
                    radText_totalventa.ReadOnly = true;
                    deuda = CControl.cDeuda.Sp_listar_deudaxidclientexestado(comprobante.Cliente.Idcliente);
                    txtGlosa.Text = comprobante.Glosa;

                    if (deuda != null)
                    {
                        radText_deudainicial.Text = deuda.Montoinicial.ToString();
                        radText_deudaacumulada.Text = deuda.Montototal.ToString();
                        radText_montocobrado.Text = deuda.Montocobrado.ToString();
                        radText_deudaactual.Text = deuda.Montoactual.ToString();
                    }
                    else
                    {

                        RadMessageBox.Show("Problemas para cargar deuda..", "Advertencia");
                    }
                }
                else
                {

                    RadMessageBox.Show("Problemas para cargar comprobante..", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_anular_comprobantexidcomprobante()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cComprobante.Sp_anular_comprobantexidcomprobante(comprobante.Idcomprobante, Sesion);
                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Anulación correcta...", "Información");

                    deuda = CControl.cDeuda.Sp_listar_deudaxidclientexestado(comprobante.Cliente.Idcliente);

                    if (deuda != null)
                    {
                        radText_deudainicial.Text = deuda.Montoinicial.ToString();
                        radText_deudaacumulada.Text = deuda.Montototal.ToString();
                        radText_montocobrado.Text = deuda.Montocobrado.ToString();
                        radText_deudaactual.Text = deuda.Montoactual.ToString();
                    }
                    else
                    {
                        RadMessageBox.Show("Problemas para cargar deuda..", "Advertencia");
                    }
                }
                else
                {

                    RadMessageBox.Show("Problemas para anular comprobante...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radButton_impirmir_Click(object sender, EventArgs e)
        {
            try
            {

                if (radText_correlativo.Text.Length > 0)
                {
                    if (comprobante != null)
                    {
                        DialogResult respuesta = RadMessageBox.Show("¿Desea ocultar precios?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            Sp_imprimir_comprobante(1);
                        }
                        else
                        {

                            Sp_imprimir_comprobante(0);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public string Impresora_Pordefecto()
        {

            string nombreimpresora = "";
            try
            {

                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    PrinterSettings a = new PrinterSettings();
                    a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                    if (a.IsDefaultPrinter)
                    {
                        nombreimpresora = PrinterSettings.InstalledPrinters[i].ToString();

                    }
                }

                return nombreimpresora;
            }
            catch (Exception)
            {
                return nombreimpresora;
            }
        }
        public void Sp_imprimir_comprobante(int ocultar)
        {

            string nombreimpresora = "";
            data = null;

            try
            {
                nombreimpresora = Impresora_Pordefecto();

                if (nombreimpresora != "")
                {
                    data = CControl.cComprobante.Sp_imprimir_comprobante(comprobante.Idcomprobante, ocultar);

                    if (data != null)
                    {
                        RadFormImprimirComprobante frm = new RadFormImprimirComprobante();
                        RptComprobante rpt = new RptComprobante();
                        rpt.SetDataSource(data);
                        CrystalDecisions.CrystalReports.Engine.PrintOptions rptoption = rpt.PrintOptions;
                        frm.crystalReport_comprobante.ReportSource = rpt;
                        rptoption.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(0, 0, 0, 20));
                        rpt.PrintOptions.PrinterName = nombreimpresora;
                        if (radCheckBox_impresion.Checked)
                        {
                            rpt.PrintToPrinter(1, false, 1, 1);
                        }
                        frm.ShowDialog(this);
                        rpt.Close();
                        rpt.Dispose();
                    }
                    else
                    {
                        RadMessageBox.Show("Problemas para cargar reporte del comprobante...", "Advertencia");
                    }
                }
                else
                {
                    RadMessageBox.Show("No se ha configurado impresora por defecto...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

       
    }
}
