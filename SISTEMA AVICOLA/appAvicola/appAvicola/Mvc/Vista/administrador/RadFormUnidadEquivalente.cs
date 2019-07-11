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
    public partial class RadFormUnidadEquivalente : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        public Producto producto { get; set; }
        public UnidadEquivalente unidadequivalente { get; set; }

        private List<UnidadMedida> lista_unidadmedida = null;
        private List<UnidadMedida> lista_unidadbase = null;
        private List<TipoUnidad> lista_tipounidad = null;
       
        public RadFormUnidadEquivalente()
        {
            InitializeComponent();
        }

        private void RadFormUnidadEquivalente_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                Sp_listar_unidadmedidaxestado();
                Sp_listar_tipounidadxestado();
                if (producto != null && unidadequivalente != null)
                {
                    radText_cod.Text = unidadequivalente.Idunidadequivalente == 0 ? string.Empty : unidadequivalente.Idunidadequivalente.ToString();
                    radText_producto.Text = producto.Nombre;
                    radDrop_estado.SelectedIndex = unidadequivalente.Estado;
                    radDrop_unidadmedida.SelectedValue = unidadequivalente.Unidadmedida.Idunidadmedida;
                    radText_equivale.Text = unidadequivalente.Equivale.ToString();
                    radDrop_unidadbase.SelectedValue = producto.Unidad.Idunidadmedida;
                }
                else {

                    RadMessageBox.Show("Problemas para cargar producto ó unidad equivalente...", "Advertencia");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radText_equivale_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radText_equivale_Leave(object sender, EventArgs e)
        {
            try
            {

                if (radText_equivale.Text.Length == 0)
                {

                    radText_equivale.Text = "0.00";
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

        private void RadFormUnidadEquivalente_Shown(object sender, EventArgs e)
        {
            try
            {

                radText_equivale.Focus();
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
                    if (radText_equivale.Text.Length > 0)
                    {
                        if (Es_numero(radText_equivale.Text))
                        {
                            if (decimal.Parse(radText_equivale.Text) > 0)
                            {
                                DialogResult respuesta = RadMessageBox.Show("¿Desea registrar unidad equivalente?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                if (respuesta == DialogResult.Yes)
                                {
                                    Sp_registrar_unidadequivalente();
                                }
                            }
                            else
                            {
                                RadMessageBox.Show("Valor equivalente no puede ser cero...", "Advertencia");
                            }
                        }
                        else
                        {

                            RadMessageBox.Show("Valor ingresado no es un número...", "Advertencia");
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }

                }
                else
                {

                    if (radText_equivale.Text.Length > 0)
                    {
                        if (Es_numero(radText_equivale.Text))
                        {
                            if (decimal.Parse(radText_equivale.Text) > 0)
                            {
                                DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar unidad equivalente?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                if (respuesta == DialogResult.Yes)
                                {
                                    Sp_actualizar_unidadequivalente();
                                }
                            }
                            else
                            {
                                RadMessageBox.Show("Valor equivalente no puede ser cero...", "Advertencia");
                            }
                        }
                        else
                        {

                            RadMessageBox.Show("Valor ingresado no es un número...", "Advertencia");
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
        /*********************************Mis Metodos*********************/
        public void Sp_listar_unidadmedidaxestado()
        {

            try
            {
                lista_unidadmedida = null;
                lista_unidadbase = null;
                radDrop_unidadmedida.DataSource = null;
                radDrop_unidadbase.DataSource = null;

                lista_unidadmedida = CControl.cUnidad.Sp_listar_unidadmedidaxestado();
                lista_unidadbase= CControl.cUnidad.Sp_listar_unidadmedidaxestado();

                if (lista_unidadmedida != null)
                {
                    if (lista_unidadmedida.Count > 0)
                    {
                        radDrop_unidadmedida.DataSource = lista_unidadmedida;
                        radDrop_unidadmedida.DisplayMember = "Sigla";
                        radDrop_unidadmedida.ValueMember = "Idunidadmedida";                      
                    }
                }

                if (lista_unidadbase != null)
                {
                    if (lista_unidadbase.Count > 0)
                    {
                        radDrop_unidadbase.DataSource = lista_unidadbase;
                        radDrop_unidadbase.DisplayMember = "Sigla";
                        radDrop_unidadbase.ValueMember = "Idunidadmedida";
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_tipounidadxestado() {

            try {

                lista_tipounidad = null;
                radDrop_tipounidad.DataSource = null;

                lista_tipounidad = CControl.cTipoUnidad.Sp_listar_tipounidadxestado();

                if (lista_tipounidad != null) {

                    if (lista_tipounidad.Count > 0) {

                        radDrop_tipounidad.DataSource = lista_tipounidad;
                        radDrop_tipounidad.DisplayMember = "Nombre";
                        radDrop_tipounidad.ValueMember = "Idtipounidad";
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
        public void Sp_registrar_unidadequivalente() {

            int id = -1;

            try
            {
                id = CControl.cUnidadEquivalente.Sp_registrar_unidadequivalente(
                        new UnidadEquivalente()
                        {

                            Producto = producto,
                            Tipounidad = new TipoUnidad() { Idtipounidad = int.Parse(radDrop_tipounidad.SelectedValue.ToString()) },
                            Unidadmedida = new UnidadMedida() { Idunidadmedida = int.Parse(radDrop_unidadmedida.SelectedValue.ToString()) },
                            Equivale = decimal.Parse(radText_equivale.Text),
                            Unidadbase = new UnidadMedida() { Idunidadmedida = int.Parse(radDrop_unidadbase.SelectedValue.ToString()) }
                        },
                        Sesion
                    );
            
                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Advertencia");
                    this.Close();
                }
                else {

                    RadMessageBox.Show("Problemas para registrar unidad equivalente...","Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_unidadequivalente()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cUnidadEquivalente.Sp_actualizar_unidadequivalente(
                        new UnidadEquivalente()
                        {
                            Idunidadequivalente=int.Parse(radText_cod.Text),
                            Producto = producto,
                            Tipounidad = new TipoUnidad() { Idtipounidad = int.Parse(radDrop_tipounidad.SelectedValue.ToString()) },
                            Unidadmedida = new UnidadMedida() { Idunidadmedida = int.Parse(radDrop_unidadmedida.SelectedValue.ToString()) },
                            Equivale = decimal.Parse(radText_equivale.Text),
                            Unidadbase = new UnidadMedida() { Idunidadmedida = int.Parse(radDrop_unidadbase.SelectedValue.ToString()) },
                            Estado=radDrop_estado.SelectedIndex==0?1:0
                        },
                        Sesion
                    );

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Advertencia");
                    this.Close();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar unidad equivalente...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
