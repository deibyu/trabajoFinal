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
    public partial class RadFormCobro : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        public Deuda Deuda { get; set; }
        public Cobro Cobro { get; set; }
        public RadFormListadeCobrosxDeuda radform_listadecobro { get; set; }
        public RadFormListadeCobros radform_listadecobros { get; set; }

        private List<TipoCobro> lista_tipocobro;
        public RadFormCobro()
        {
            InitializeComponent();
        }

        private void RadFormCobro_Load(object sender, EventArgs e)
        {
            try
            {
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radDrop_estado.SelectedIndex = 0;
                radDateTimePicker_fechaemision.Value = DateTime.Now;
                Sp_listar_tipocobroxestado();

                if (Deuda != null) { radText_montodeuda.Text = Deuda.Montoactual.ToString(); }

                if (radform_listadecobro != null || radform_listadecobros!=null) {

                    radText_monto.ReadOnly = true;
                    radButton_limpiar.Enabled = false;
                    Mostrar_Cobro();
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void RadFormCobro_Shown(object sender, EventArgs e)
        {
            try
            {
                radText_monto.Focus();
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

        private void radText_monto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radText_monto_Leave(object sender, EventArgs e)
        {
            try
            {

                if (radText_monto.Text.Length == 0)
                {

                    radText_monto.Text = "0.00";
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_monto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radText_monto.Text.Length != 0)
                {
                    if (Es_numero(radText_monto.Text))
                    {
                        if (decimal.Parse(radText_monto.Text) > 0 && decimal.Parse(radText_monto.Text) <= decimal.Parse(radText_montodeuda.Text))
                        {
                            Calcular_Saldo();
                        }
                        else
                        {

                            RadMessageBox.Show("El monto de pago debe ser maryor a (0) y/ó menor a la deuda" + decimal.Parse(radText_montodeuda.Text));
                        }
                    }
                }
                else
                {

                    radText_monto.Text = "0.00";
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_cuentabancaria_TextChanged(object sender, EventArgs e)
        {
            radText_cuentabancaria.CharacterCasing = CharacterCasing.Upper;
        }

        private void radText_descripcion_TextChanged(object sender, EventArgs e)
        {
            radText_descripcion.CharacterCasing = CharacterCasing.Upper;
        }

        private void radDrop_tipocobro_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (radDrop_tipocobro.SelectedValue != null)
                {

                    if (radDrop_tipocobro.SelectedValue.ToString() != "appAvicola.Mvc.Clases.TipoCobro")
                    {

                        switch (int.Parse(radDrop_tipocobro.SelectedValue.ToString()))
                        {

                            case 1:
                                radText_cuentabancaria.Text = string.Empty;
                                radText_numerooperacion.Text = string.Empty;
                                radText_cuentabancaria.Enabled = false;
                                radText_numerooperacion.Enabled = false;
                                break;
                            case 2:
                                radText_cuentabancaria.Text = string.Empty;
                                radText_numerooperacion.Text = string.Empty;
                                radText_cuentabancaria.Enabled = true;
                                radText_numerooperacion.Enabled = true;
                                break;
                        }
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
                radDrop_tipocobro.SelectedIndex = 0;
                radDateTimePicker_fechaemision.Value = DateTime.Now;
                radText_cuentabancaria.Text = string.Empty;
                radText_numerooperacion.Text = string.Empty;
                radText_monto.Text = "0.00";
                radText_saldo.Text = "0.00";
                radText_descripcion.Text = string.Empty;

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

                    if (radText_monto.Text.Length > 0)
                    {
                        if (Es_numero(radText_monto.Text))
                        {
                            if (decimal.Parse(radText_monto.Text) > 0 && decimal.Parse(radText_monto.Text) <= decimal.Parse(radText_montodeuda.Text))
                            {
                                if (radDrop_tipocobro.SelectedValue != null)
                                {
                                    if (radDrop_tipocobro.SelectedValue.ToString() != "System.Data.DataRowView")
                                    {
                                        if (int.Parse(radDrop_tipocobro.SelectedValue.ToString()) == 2)
                                        {
                                            if (radText_cuentabancaria.Text.Length == 0 && radText_numerooperacion.Text.Length == 0)
                                            {
                                                RadMessageBox.Show("Por favor ingrese número de cuenta y número de operación...", "Advertencia");
                                                return;
                                            }

                                        }

                                        DialogResult respuesta = RadMessageBox.Show("¿Desea registrar cobro?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                        if (respuesta == DialogResult.Yes)
                                        {
                                            Sp_registrar_cobro();
                                        }
                                    }
                                }
                            }
                            else
                            {

                                RadMessageBox.Show("El monto de pago debe ser maryor a (0) y/ó menor a la deuda" + decimal.Parse(radText_montodeuda.Text) + "...", "Advertencia");
                            }
                        }
                        else
                        {

                            RadMessageBox.Show("Monto ingresado no es un número...", "Advertencia");
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                        radText_monto.Text = "0.00";
                    }
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
                if (radText_cod.Text.Length > 0)
                {
                    if (Deuda != null)
                    {
                        if (Cobro != null)
                        {
                            if (Cobro.Estado == 1)
                            {
                                DialogResult respuesta = RadMessageBox.Show("¿Desea anular cobro?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                if (respuesta == DialogResult.Yes)
                                {
                                    Sp_anular_cobro();
                                }
                            }
                            else {

                                RadMessageBox.Show("Cobro se encuentra anulado...", "Advertencia");
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
        /*************************************Mis Metodos****************************/
        public void Mostrar_Cobro() {
            try
            {

                if (Cobro != null) {

                    radText_cod.Text = Cobro.Idcobro.ToString();
                    radDrop_estado.SelectedIndex = Cobro.Estado == 1 ? 0 : 1;
                    radDateTimePicker_fechaemision.Value = Cobro.Fechacobro;
                    radDrop_tipocobro.SelectedValue = Cobro.Tipocobro.Idtipocobro;
                    radText_cuentabancaria.Text = Cobro.Cuentabancaria;
                    radText_numerooperacion.Text = Cobro.Noperacion;
                    radText_monto.Text = Cobro.Monto.ToString();
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
        public void Sp_listar_tipocobroxestado()
        {

            try
            {
                lista_tipocobro = null;
                radDrop_tipocobro.DataSource = null;
                lista_tipocobro = CControl.cTipoCobro.Sp_listar_tipocobroxestado();

                if (lista_tipocobro != null)
                {
                    if (lista_tipocobro.Count > 0)
                    {

                        radDrop_tipocobro.DataSource = lista_tipocobro;
                        radDrop_tipocobro.ValueMember = "Idtipocobro";
                        radDrop_tipocobro.DisplayMember = "Nombre";
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Calcular_Saldo()
        {

            decimal deudaactual = 0.00m;
            decimal monto = 0.00m;
            decimal saldo = 0.00m;

            try
            {

                deudaactual = decimal.Parse(radText_montodeuda.Text);
                monto = decimal.Parse(radText_monto.Text);
                saldo = deudaactual - monto;

                radText_saldo.Text = saldo.ToString();
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_registrar_cobro()
        {

            int id = -1;
            try
            {

                id = CControl.cCobro.Sp_registrar_cobro(new Cobro()
                {
                    Deuda = Deuda,
                    Fechacobro = radDateTimePicker_fechaemision.Value,
                    Tipocobro = new TipoCobro()
                    {
                        Idtipocobro = int.Parse(radDrop_tipocobro.SelectedValue.ToString())
                    },
                    Cuentabancaria = radText_cuentabancaria.Text,
                    Noperacion = radText_numerooperacion.Text,
                    Monto = decimal.Parse(radText_monto.Text),
                    Observacion = radText_descripcion.Text
                },
                Sesion);

                if (id > 0)
                {
                    Cobro = CControl.cCobro.Sp_listar_cobroxidcobro(id);
                    RadMessageBox.Show("Registro correcto...", "Información");
                    radText_cod.Text = id.ToString();
                }
                else {

                    RadMessageBox.Show("Problemas para registrar cobro...","Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_anular_cobro() {

            int filas_afectadas = 1;
            try {

                filas_afectadas = CControl.cCobro.Sp_anular_cobro(
                        Deuda.Iddeuda,
                        int.Parse(radText_cod.Text),
                        Sesion
                    );

                if (filas_afectadas > 0) {

                    RadMessageBox.Show("Anulación correcta...", "Información");
                    this.Close();
                }
                else
                {

                    RadMessageBox.Show("Problemas para anular cobro...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }        
    }
}
