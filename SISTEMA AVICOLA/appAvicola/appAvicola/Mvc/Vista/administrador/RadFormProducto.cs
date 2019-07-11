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
    public partial class RadFormProducto : Telerik.WinControls.UI.RadForm
    {
        public Sesion Sesion { get; set; }
        DataTable productos = null;
        private List<Categoria> lista_categoria = null;
        private List<UnidadMedida> lista_unidad = null;
        private DataTable unidadesequivalentes = null;
        private DataTable precios = null;
        public RadFormProducto()
        {
            InitializeComponent();
        }

        private void RadFormProducto_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                radGridView_producto.AutoGenerateColumns = false;
                radDrop_estado.SelectedIndex = 0;
                Sp_listar_categoriaxestado();
                Sp_listar_unidadmedidaxestado();

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
                radDrop_categoria.SelectedIndex = 0;
                radText_nombre.Text = string.Empty;
                radDrop_unidad.SelectedIndex = 0;
                radText_precio.Text = "0.00";
                productos = null;
                radGridView_producto.DataSource = null;
                unidadesequivalentes = null;
                radGridView_unidadequivalente.DataSource = null;
                precios = null;
                radGridView_preciounidadequivalente.DataSource = null;
                txtOrden.Text = "";
                radText_nombre.Focus();
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

        private void RadFormProducto_Shown(object sender, EventArgs e)
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

        private void radButton_cargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radDrop_categoria.SelectedValue != null)
                {

                    Sp_listar_productoxcategoria();
                }
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
                        Sp_listar_productoxnombre();
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
                    if (radDrop_categoria.SelectedValue != null
                        && radText_nombre.Text.Length > 0
                        && radDrop_unidad.SelectedValue != null
                        && radText_precio.Text.Length > 0)
                    {

                        if (Es_numero(radText_precio.Text))
                        {
                            if (decimal.Parse(radText_precio.Text) >= 0)
                            {
                                DialogResult respuesta = RadMessageBox.Show("¿Desea registrar producto?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                if (respuesta == DialogResult.Yes)
                                {
                                    if (txtOrden.Text == "" || Convert.ToInt32(txtOrden.Text) == 0)
                                    {
                                        RadMessageBox.Show("Ingrese N° de orden para impresión de producto", "Advertencia");
                                        return;
                                    }
                                    else
                                    {
                                        Sp_registar_producto();
                                    }
                                }
                            }
                            else
                            {

                                RadMessageBox.Show("Precio no puede ser un número negativo...", "Advertencia");
                            }

                        }
                        else
                        {

                            RadMessageBox.Show("Precio no es un número...", "Advertencia");
                        }
                    }
                    else
                    {

                        RadMessageBox.Show("Por favor complete la información solicitada...", "Advertencia");
                    }
                }
                else
                {
                    if (radDrop_categoria.SelectedValue != null
                        && radText_nombre.Text.Length > 0
                        && radDrop_unidad.SelectedValue != null
                        && radText_precio.Text.Length > 0)
                    {

                        if (Es_numero(radText_precio.Text))
                        {
                            if (decimal.Parse(radText_precio.Text) >= 0)
                            {
                                DialogResult respuesta = RadMessageBox.Show("¿Desea actualizar producto?...", "Advertencia", MessageBoxButtons.YesNo, RadMessageIcon.Question);

                                if (respuesta == DialogResult.Yes)
                                {
                                    Sp_actualizar_producto();
                                }
                            }
                            else
                            {

                                RadMessageBox.Show("Precio no puede ser un número negativo...", "Advertencia");
                            }

                        }
                        else
                        {

                            RadMessageBox.Show("Precio no es un número...", "Advertencia");
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

        private void radGridView_producto_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_producto.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        radText_cod.Text = radGridView_producto.Rows[e.RowIndex].Cells["idproducto"].Value.ToString();
                        radDrop_categoria.SelectedValue = int.Parse(radGridView_producto.Rows[e.RowIndex].Cells["idcategoria"].Value.ToString());
                        radText_nombre.Text = radGridView_producto.Rows[e.RowIndex].Cells["prnombre"].Value.ToString();
                        radDrop_unidad.SelectedValue = int.Parse(radGridView_producto.Rows[e.RowIndex].Cells["idunidadmedida"].Value.ToString());
                        radText_precio.Text = radGridView_producto.Rows[e.RowIndex].Cells["precio"].Value.ToString();
                        radDrop_estado.Text = radGridView_producto.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                        txtOrden.Text= radGridView_producto.Rows[e.RowIndex].Cells["norden"].Value.ToString();
                        Sp_listar_unidadequivalentexproducto(e.RowIndex);
                        precios = null;
                        radGridView_preciounidadequivalente.DataSource = null;

                    }
                }
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

                    radText_precio.Text = "0.00";
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        private void radGridView_preciounidadequivalente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2)
                {

                    if (radGridView_preciounidadequivalente.Rows.Count > 0)
                    {
                        if (radGridView_preciounidadequivalente.CurrentCell != null)
                        {
                            if (radGridView_preciounidadequivalente.CurrentCell.RowIndex != -1)
                            {

                                RadFormPrecio radFormPrecio = new RadFormPrecio()
                                {
                                    Sesion = Sesion,
                                    Precio = new Precio()
                                    {
                                        Idprecio = e.KeyCode == Keys.F1 ? 0 : int.Parse(radGridView_preciounidadequivalente.Rows[radGridView_preciounidadequivalente.CurrentCell.RowIndex].Cells["idprecio"].Value.ToString()),
                                        Tipoprecio= e.KeyCode == Keys.F1 ? new TipoPrecio() { Idtipoprecio=0}:new TipoPrecio() { Idtipoprecio= int.Parse(radGridView_preciounidadequivalente.Rows[radGridView_preciounidadequivalente.CurrentCell.RowIndex].Cells["idtipoprecio"].Value.ToString())},
                                        Unidadequivalente = new UnidadEquivalente()
                                        {
                                            Idunidadequivalente = int.Parse(radGridView_preciounidadequivalente.Rows[radGridView_preciounidadequivalente.CurrentCell.RowIndex].Cells["idunidadequivalente"].Value.ToString()),
                                            Unidadmedida = new UnidadMedida() { Sigla = radGridView_preciounidadequivalente.Rows[radGridView_preciounidadequivalente.CurrentCell.RowIndex].Cells["umsigla"].Value.ToString() }
                                        },
                                        Valor = e.KeyCode == Keys.F1 ? 0.00m : decimal.Parse(radGridView_preciounidadequivalente.Rows[radGridView_preciounidadequivalente.CurrentCell.RowIndex].Cells["precio"].Value.ToString())
                                    }
                                };

                                radFormPrecio.ShowDialog();
                                Sp_listar_precioxidunidadequivalente(radGridView_unidadequivalente.CurrentCell.RowIndex);
                            }
                        }
                    }
                    else {

                        if (e.KeyCode == Keys.F1)
                        {
                            RadFormPrecio radFormPrecio = new RadFormPrecio()
                            {
                                Sesion = Sesion,
                                Precio = new Precio()
                                {
                                    Idprecio = 0,
                                    Tipoprecio =new TipoPrecio() { Idtipoprecio = 0 },
                                    Unidadequivalente = new UnidadEquivalente()
                                    {
                                        Idunidadequivalente = int.Parse(radGridView_unidadequivalente.Rows[radGridView_unidadequivalente.CurrentCell.RowIndex].Cells["idunidadequivalente"].Value.ToString()),
                                        Unidadmedida = new UnidadMedida() { Sigla = radGridView_unidadequivalente.Rows[radGridView_unidadequivalente.CurrentCell.RowIndex].Cells["unisigla"].Value.ToString() }
                                    },
                                    Valor = 0.00m
                                }
                            };

                            radFormPrecio.ShowDialog();
                            Sp_listar_precioxidunidadequivalente(radGridView_unidadequivalente.CurrentCell.RowIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }

        }
        private void radGridView_unidadequivalente_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int pos = 0;
            try
            {

                if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2)
                {
                    if (radGridView_unidadequivalente.Rows.Count > 0)
                    {
                        if (radGridView_unidadequivalente.CurrentCell != null)
                        {
                            if (radGridView_unidadequivalente.CurrentCell.RowIndex != -1)
                            {
                                RadFormUnidadEquivalente radFormUnidad = new RadFormUnidadEquivalente
                                {
                                    producto = new Producto()
                                    {
                                        Idproducto = int.Parse(radText_cod.Text),
                                        Categoria = new Categoria()
                                        {

                                            Idcategoria = int.Parse(radDrop_categoria.SelectedValue.ToString())
                                        },
                                        Nombre = radText_nombre.Text,
                                        Unidad = new UnidadMedida()
                                        {
                                            Idunidadmedida = int.Parse(radDrop_unidad.SelectedValue.ToString())
                                        },
                                        Precio = decimal.Parse(radText_precio.Text),
                                        Estado = radDrop_estado.SelectedIndex == 0 ? 1 : 0

                                    }
                                    ,
                                    unidadequivalente = new UnidadEquivalente()
                                    {

                                        Idunidadequivalente = e.KeyCode == Keys.F1 ? 0 : int.Parse(radGridView_unidadequivalente.Rows[radGridView_unidadequivalente.CurrentCell.RowIndex].Cells["idunidadequivalente"].Value.ToString()),
                                        Unidadmedida = e.KeyCode == Keys.F1 ? new UnidadMedida() { Idunidadmedida = 0 } : new UnidadMedida() { Idunidadmedida = int.Parse(radGridView_unidadequivalente.Rows[radGridView_unidadequivalente.CurrentCell.RowIndex].Cells["idunidadmedida"].Value.ToString()) },
                                        Equivale = e.KeyCode == Keys.F1 ? 0.00m : decimal.Parse(radGridView_unidadequivalente.Rows[radGridView_unidadequivalente.CurrentCell.RowIndex].Cells["equivale"].Value.ToString()),
                                        Estado = e.KeyCode == Keys.F1 ? 0 : radGridView_unidadequivalente.Rows[radGridView_unidadequivalente.CurrentCell.RowIndex].Cells["estado"].Value.ToString() == "ACTIVO" ? 0 : 1

                                    },
                                    Sesion = Sesion

                                };
                                radFormUnidad.ShowDialog();

                                Sp_listar_unidadequivalentexproducto(radGridView_producto.CurrentCell.RowIndex);

                            }
                        }
                    }

                }

                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {

                    if (radGridView_unidadequivalente.Rows.Count > 0)
                    {
                        if (radGridView_unidadequivalente.CurrentCell != null)
                        {
                            if (radGridView_unidadequivalente.CurrentCell.RowIndex != -1)
                            {
                                pos = radGridView_unidadequivalente.CurrentCell.RowIndex;
                                if (e.KeyCode == Keys.Up) { pos--; } else { pos++; }

                                if (pos >= 0 && pos < radGridView_unidadequivalente.Rows.Count)
                                {
                                    Sp_listar_precioxidunidadequivalente(pos);
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

        private void radGridView_producto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int pos = 0;
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    if (radGridView_producto.Rows.Count > 0)
                    {

                        if (radGridView_producto.CurrentCell != null)
                        {
                            if (radGridView_producto.CurrentCell.RowIndex != -1)
                            {
                                pos = radGridView_producto.CurrentCell.RowIndex;
                                if (e.KeyCode == Keys.Up) { pos--; } else { pos++; }

                                if (pos >= 0 && pos < radGridView_producto.Rows.Count)
                                {
                                    radText_cod.Text = radGridView_producto.Rows[pos].Cells["idproducto"].Value.ToString();
                                    radDrop_categoria.SelectedValue = int.Parse(radGridView_producto.Rows[pos].Cells["idcategoria"].Value.ToString());
                                    radText_nombre.Text = radGridView_producto.Rows[pos].Cells["prnombre"].Value.ToString();
                                    radDrop_unidad.SelectedValue = int.Parse(radGridView_producto.Rows[pos].Cells["idunidadmedida"].Value.ToString());
                                    radText_precio.Text = radGridView_producto.Rows[pos].Cells["precio"].Value.ToString();
                                    radDrop_estado.Text = radGridView_producto.Rows[pos].Cells["estado"].Value.ToString();
                                    Sp_listar_unidadequivalentexproducto(pos);
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

        private void radGridView_unidadequivalente_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView_unidadequivalente.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        Sp_listar_precioxidunidadequivalente(e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        /**************************Mis Metodos***************************/


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
                        radDrop_categoria.DisplayMember = "Nombre";
                        radDrop_categoria.ValueMember = "Idcategoria";
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_unidadmedidaxestado()
        {

            try
            {
                lista_unidad = null;
                radDrop_unidad.DataSource = null;

                lista_unidad = CControl.cUnidad.Sp_listar_unidadmedidaxestado();

                if (lista_unidad != null)
                {

                    if (lista_unidad.Count > 0)
                    {

                        radDrop_unidad.DataSource = lista_unidad;
                        radDrop_unidad.DisplayMember = "Sigla";
                        radDrop_unidad.ValueMember = "Idunidadmedida";
                    }
                }

            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_productoxcategoria()
        {

            try
            {
                productos = null;
                radGridView_producto.DataSource = null;

                productos = CControl.cProducto.Sp_listar_productoxcategoria(
                        new Categoria()
                        {
                            Idcategoria = int.Parse(radDrop_categoria.SelectedValue.ToString())
                        }
                    );

                if (productos != null)
                {

                    if (productos.Rows.Count > 0)
                    {

                        radGridView_producto.DataSource = productos;
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_productoxnombre()
        {

            try
            {
                productos = null;
                radGridView_producto.DataSource = null;

                productos = CControl.cProducto.Sp_listar_productoxnombre(radText_nombre.Text);

                if (productos != null)
                {

                    if (productos.Rows.Count > 0)
                    {
                        radGridView_producto.DataSource = productos;
                        radGridView_producto.Focus();
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

        public void Sp_registar_producto()
        {

            int id = -1;

            try
            {
                id = CControl.cProducto.Sp_registar_producto(
                    new Producto()
                    {

                        Categoria = new Categoria()
                        {

                            Idcategoria = int.Parse(radDrop_categoria.SelectedValue.ToString())
                        },
                        Nombre = radText_nombre.Text,
                        Unidad = new UnidadMedida()
                        {

                            Idunidadmedida = int.Parse(radDrop_unidad.SelectedValue.ToString())
                        },
                        Precio = decimal.Parse(radText_precio.Text),
                        norden = Convert.ToInt32(txtOrden.Text)

                    },
                    Sesion);

                if (id > 0)
                {
                    RadMessageBox.Show("Registro correcto...", "Información");
                    Sp_listar_productoxnombre();
                }
                else
                {

                    RadMessageBox.Show("Problemas para registrar producto...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_actualizar_producto()
        {

            int filas_afectadas = -1;

            try
            {
                filas_afectadas = CControl.cProducto.Sp_actualizar_producto(
                    new Producto()
                    {
                        Idproducto = int.Parse(radText_cod.Text),
                        Categoria = new Categoria()
                        {

                            Idcategoria = int.Parse(radDrop_categoria.SelectedValue.ToString())
                        },
                        Nombre = radText_nombre.Text,
                        Unidad = new UnidadMedida()
                        {

                            Idunidadmedida = int.Parse(radDrop_unidad.SelectedValue.ToString())
                        },
                        Precio = decimal.Parse(radText_precio.Text),
                        norden = Convert.ToInt32(txtOrden.Text),
                        Estado = radDrop_estado.SelectedIndex == 0 ? 1 : 0
                    },
                    Sesion);

                if (filas_afectadas > 0)
                {
                    RadMessageBox.Show("Actualización correcta...", "Información");
                    Sp_listar_productoxnombre();
                }
                else
                {

                    RadMessageBox.Show("Problemas para actualizar producto...", "Advertencia");
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_unidadequivalentexproducto(int pos)
        {

            try
            {
                unidadesequivalentes = null;
                radGridView_unidadequivalente.DataSource = null;

                if (pos != -1)
                {

                    unidadesequivalentes = CControl.cUnidadEquivalente.Sp_listar_unidadequivalentexproducto(
                            int.Parse(radGridView_producto.Rows[pos].Cells["idproducto"].Value.ToString())
                        );

                    if (unidadesequivalentes != null)
                    {

                        if (unidadesequivalentes.Rows.Count > 0)
                        {

                            radGridView_unidadequivalente.DataSource = unidadesequivalentes;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.Message.ToString());
            }
        }

        public void Sp_listar_precioxidunidadequivalente(int pos)
        {

            try
            {

                precios = null;
                radGridView_preciounidadequivalente.DataSource = null;

                precios = CControl.cPrecio.Sp_listar_precioxidunidadequivalente(
                   int.Parse(radGridView_unidadequivalente.Rows[pos].Cells["idunidadequivalente"].Value.ToString()));

                if (precios != null)
                {

                    if (precios.Rows.Count > 0)
                    {

                        radGridView_preciounidadequivalente.DataSource = precios;
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
