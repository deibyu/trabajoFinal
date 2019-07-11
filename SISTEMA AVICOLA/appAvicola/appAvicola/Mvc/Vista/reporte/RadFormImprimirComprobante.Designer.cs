namespace appAvicola.Mvc.Vista.reporte
{
    partial class RadFormImprimirComprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.crystalReport_comprobante = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.crystalReport_comprobante);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(342, 715);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.Text = "radPanel1";
            this.radPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // crystalReport_comprobante
            // 
            this.crystalReport_comprobante.ActiveViewIndex = -1;
            this.crystalReport_comprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReport_comprobante.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReport_comprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReport_comprobante.Location = new System.Drawing.Point(0, 0);
            this.crystalReport_comprobante.Name = "crystalReport_comprobante";
            this.crystalReport_comprobante.Size = new System.Drawing.Size(342, 715);
            this.crystalReport_comprobante.TabIndex = 0;
            this.crystalReport_comprobante.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RadFormImprimirComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 715);
            this.Controls.Add(this.radPanel1);
            this.Name = "RadFormImprimirComprobante";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Impresión";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReport_comprobante;
    }
}
