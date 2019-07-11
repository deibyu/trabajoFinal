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
    public partial class RadFormTipoComprobante : Telerik.WinControls.UI.RadForm
    {
        private DataTable tiposcomprobantes = null;
        public RadFormTipoComprobante()
        {
            InitializeComponent();
        }

        private void RadFormTipoComprobante_Load(object sender, EventArgs e)
        {
            try
            {

                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
                Sp_listar_tipocomprobante();


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

        /***************************************Mis Metodos************************/
        public void Sp_listar_tipocomprobante() {

            try
            {
                tiposcomprobantes = null;
                radGridView_tipocomprobante.DataSource = null;
                tiposcomprobantes = CControl.cTipoComprobante.Sp_listar_tipocomprobante();

                if (tiposcomprobantes != null) {

                    if (tiposcomprobantes.Rows.Count > 0) {

                        radGridView_tipocomprobante.DataSource = tiposcomprobantes;
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
