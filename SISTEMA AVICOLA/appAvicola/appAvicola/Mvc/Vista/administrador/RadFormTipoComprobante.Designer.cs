namespace appAvicola.Mvc.Vista.administrador
{
    partial class RadFormTipoComprobante
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton_cancelar = new Telerik.WinControls.UI.RadButton();
            this.radGridView_tipocomprobante = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_tipocomprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_tipocomprobante.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radButton_cancelar);
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(503, 263);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radGridView_tipocomprobante);
            this.radGroupBox1.HeaderText = "Tipos de Comprobante";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(479, 199);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Tipos de Comprobante";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radButton_cancelar
            // 
            this.radButton_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton_cancelar.Image = global::appAvicola.Properties.Resources.cancelar;
            this.radButton_cancelar.Location = new System.Drawing.Point(400, 217);
            this.radButton_cancelar.Name = "radButton_cancelar";
            this.radButton_cancelar.Size = new System.Drawing.Size(91, 36);
            this.radButton_cancelar.TabIndex = 10;
            this.radButton_cancelar.Text = "Cancelar";
            this.radButton_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_cancelar.ThemeName = "TelerikMetroBlue";
            this.radButton_cancelar.Click += new System.EventHandler(this.radButton_cancelar_Click);
            // 
            // radGridView_tipocomprobante
            // 
            this.radGridView_tipocomprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView_tipocomprobante.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.radGridView_tipocomprobante.MasterTemplate.AllowAddNewRow = false;
            this.radGridView_tipocomprobante.MasterTemplate.AllowColumnReorder = false;
            this.radGridView_tipocomprobante.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn9.FieldName = "idtipocomprobante";
            gridViewTextBoxColumn9.HeaderText = "COD";
            gridViewTextBoxColumn9.Name = "idtipocomprobante";
            gridViewTextBoxColumn9.Width = 119;
            gridViewTextBoxColumn10.FieldName = "nombre";
            gridViewTextBoxColumn10.HeaderText = "NOMBRE";
            gridViewTextBoxColumn10.Name = "nombre";
            gridViewTextBoxColumn10.Width = 119;
            gridViewTextBoxColumn11.FieldName = "sigla";
            gridViewTextBoxColumn11.HeaderText = "SIGLA";
            gridViewTextBoxColumn11.Name = "sigla";
            gridViewTextBoxColumn11.Width = 119;
            gridViewTextBoxColumn12.FieldName = "estado";
            gridViewTextBoxColumn12.HeaderText = "ESTADO";
            gridViewTextBoxColumn12.Name = "estado";
            gridViewTextBoxColumn12.Width = 120;
            this.radGridView_tipocomprobante.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.radGridView_tipocomprobante.MasterTemplate.ShowFilteringRow = false;
            this.radGridView_tipocomprobante.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView_tipocomprobante.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView_tipocomprobante.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridView_tipocomprobante.Name = "radGridView_tipocomprobante";
            this.radGridView_tipocomprobante.ReadOnly = true;
            this.radGridView_tipocomprobante.ShowGroupPanel = false;
            this.radGridView_tipocomprobante.ShowHeaderCellButtons = true;
            this.radGridView_tipocomprobante.Size = new System.Drawing.Size(475, 179);
            this.radGridView_tipocomprobante.TabIndex = 0;
            this.radGridView_tipocomprobante.Text = "radGridView1";
            this.radGridView_tipocomprobante.ThemeName = "TelerikMetroBlue";
            // 
            // RadFormTipoComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 263);
            this.Controls.Add(this.radPanel1);
            this.Name = "RadFormTipoComprobante";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Tipo Comprobante";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.RadFormTipoComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_tipocomprobante.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_tipocomprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton_cancelar;
        private Telerik.WinControls.UI.RadGridView radGridView_tipocomprobante;
    }
}
