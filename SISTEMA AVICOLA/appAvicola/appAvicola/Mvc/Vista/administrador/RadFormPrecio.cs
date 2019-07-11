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
    public partial class RadFormPrecio : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        public Precio Precio { get; set; }

        private List<TipoPrecio> lista_precio = null;
        private List<Moneda> lista_moneda = null;
        public RadFormPrecio()
        {
            InitializeComponent();
        }

        private void RadFormPrecio_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radDrop_estado.SelectedIndex = 0;
                Sp_listar_tipoprecioxestado();
                Sp_listar_monedaxestado();

                if (Precio != null)
                {

                    radText_cod.Text = Precio.Idprecio == 0 ? string.Empty : Precio.Idprecio.ToString();
                    if (Precio.Tipoprecio.Idtipoprecio == 0)
                    {
                        radDrop_tipoprecio.SelectedIndex = 0;
                    }
                    else {

                        radDrop_tipoprecio.SelectedValue = Precio.Tipoprecio.Idtipoprecio;
                    }
                    radDrop_unidadmedida.Items.Add(Precio.Unidadequivalente.Unidadmedida.Sigla);
                    radDrop_unidadmedida.SelectedIndex = 0;
                    radText_valor.Text = Precio.Valor.ToString();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_valor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radText_valor_Leave(object sender, EventArgs e)
        {
            try
            {

                if (radText_valor.Text.Length == 0)
                {

                    radText_valor.Text = "0.00";
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
        private void RadFormPrecio_Shown(object sender, EventArgs e)
        {
            try
            {

                radText_valor.Focus();
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
                    if (radDrop_tipoprecio.SelectedItem != null && radText_valor.Text.Length > 0)
                    {
                        if (Es_numero(radText_valor.Text))
                        {
                            if (decimal.Parse(radText_valor.Text) > 0)
                            {
                                DialogResult respuesta = RadMessageBox.Show("¿Desea registrar precio?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                if (respuesta == DialogResult.Yes)
                                {
                                    Sp_registrar_precio();
                                }
                            }
                            else
                            {

                                MessageBox.Show("Valor debe ser mayor/igual a 0.00...", "Advertencia");
                            }
                        }
                        else
                        {

                            MessageBox.Show("Valor ingresado no es un número...", "Advertencia");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {

                    if (radDrop_tipoprecio.SelectedItem != null && radText_valor.Text.Length > 0)
                    {
                        if (Es_numero(radText_valor.Text))
                        {
                            if (decimal.Parse(radText_valor.Text) > 0)
                            {
                                DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar precio?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                if (respuesta == DialogResult.Yes)
                                {
                                    Sp_actualizar_precio();
                                }
                            }
                            else
                            {

                                MessageBox.Show("Valor debe ser mayor/igual a 0.00...", "Advertencia");
                            }
                        }
                        else
                        {

                            MessageBox.Show("Valor ingresado no es un número...", "Advertencia");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /***********************************************Mis Metodos*********************************/
        public void Sp_listar_tipoprecioxestado()
        {

            try
            {
                lista_precio = null;
                radDrop_tipoprecio.DataSource = null;

                lista_precio = CControl.cTipoPrecio.Sp_listar_tipoprecioxestado();

                if (lista_precio != null)
                {

                    if (lista_precio.Count > 0)
                    {

                        radDrop_tipoprecio.DataSource = lista_precio;
                        radDrop_tipoprecio.DisplayMember = "Nombre";
                        radDrop_tipoprecio.ValueMember = "Idtipoprecio";
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_monedaxestado()
        {

            try
            {
                lista_moneda = null;
                radDrop_moneda.DataSource = null;
                lista_moneda = CControl.cMoneda.Sp_listar_monedaxestado();

                if (lista_moneda != null)
                {

                    if (lista_moneda.Count > 0)
                    {

                        radDrop_moneda.DataSource = lista_moneda;
                        radDrop_moneda.DisplayMember = "Sigla";
                        radDrop_moneda.ValueMember = "Idmoneda";
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
            try
            {
                bool isNum;
                double retNum;
                isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
                return isNum;
            }
            catch (Exception) { return false; }
        }

        public void Sp_registrar_precio() {

            int id = -1;

            try
            {
                id = CControl.cPrecio.Sp_registrar_precio(
                    new Precio() {

                        Unidadequivalente = Precio.Unidadequivalente,
                        Tipoprecio = lista_precio[radDrop_tipoprecio.SelectedIndex],
                        Moneda = lista_moneda[radDrop_moneda.SelectedIndex],
                        Valor=decimal.Parse(radText_valor.Text)
                    }
                    ,Sesion);

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Advertencia");
                    this.Close();
                }
                else
                {

                    RadMessageBox.Show("Problemas para registrar precio...", "Advertencia");
                }           
                
            }
            catch (Exception ex) {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_precio()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cPrecio.Sp_actualizar_precio(
                    new Precio()
                    {
                        Idprecio=int.Parse(radText_cod.Text),
                        Unidadequivalente = Precio.Unidadequivalente,
                        Tipoprecio = lista_precio[radDrop_tipoprecio.SelectedIndex],
                        Moneda = lista_moneda[radDrop_moneda.SelectedIndex],
                        Valor = decimal.Parse(radText_valor.Text),
                        Estado=radDrop_estado.SelectedIndex==0?1:0
                    }
                    , Sesion);

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Advertencia");
                    this.Close();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar precio...", "Advertencia");
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }        
    }
}
