namespace appAvicola.Mvc.Vista.administrador
{
    partial class RadFormDeudaporCliente
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView_deudas = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel_total = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radDrop_cliente = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel15 = new Telerik.WinControls.UI.RadLabel();
            this.radButton_ver = new Telerik.WinControls.UI.RadButton();
            this.radButton_copiar = new Telerik.WinControls.UI.RadButton();
            this.radButton_cancelar = new Telerik.WinControls.UI.RadButton();
            this.radButton_limpiar = new Telerik.WinControls.UI.RadButton();
            this.radButton_cargar = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton_pagar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_deudas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_deudas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_ver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_copiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radGridView_deudas);
            this.radGroupBox1.HeaderText = "Lista";
            this.radGroupBox1.Location = new System.Drawing.Point(19, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(656, 284);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Lista";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radGridView_deudas
            // 
            this.radGridView_deudas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView_deudas.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.radGridView_deudas.MasterTemplate.AllowAddNewRow = false;
            this.radGridView_deudas.MasterTemplate.AllowColumnReorder = false;
            this.radGridView_deudas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn15.FieldName = "iddeuda";
            gridViewTextBoxColumn15.HeaderText = "COD";
            gridViewTextBoxColumn15.Name = "iddeuda";
            gridViewTextBoxColumn15.Width = 133;
            gridViewTextBoxColumn16.FieldName = "idcliente";
            gridViewTextBoxColumn16.HeaderText = "COD CLIENTE";
            gridViewTextBoxColumn16.IsVisible = false;
            gridViewTextBoxColumn16.Name = "idcliente";
            gridViewTextBoxColumn16.Width = 200;
            gridViewTextBoxColumn17.FieldName = "montoinicial";
            gridViewTextBoxColumn17.HeaderText = "MONTO INICIAL";
            gridViewTextBoxColumn17.Name = "montoinicial";
            gridViewTextBoxColumn17.Width = 123;
            gridViewTextBoxColumn18.FieldName = "montototal";
            gridViewTextBoxColumn18.HeaderText = "MONTO TOTAL";
            gridViewTextBoxColumn18.Name = "montototal";
            gridViewTextBoxColumn18.Width = 123;
            gridViewTextBoxColumn19.FieldName = "montocobrado";
            gridViewTextBoxColumn19.HeaderText = "MONTO COBRADO";
            gridViewTextBoxColumn19.Name = "montocobrado";
            gridViewTextBoxColumn19.Width = 123;
            gridViewTextBoxColumn20.FieldName = "montoactual";
            gridViewTextBoxColumn20.HeaderText = "MONTO ACTUAL";
            gridViewTextBoxColumn20.Name = "montoactual";
            gridViewTextBoxColumn20.Width = 153;
            gridViewTextBoxColumn21.FieldName = "estado";
            gridViewTextBoxColumn21.HeaderText = "ESTADO";
            gridViewTextBoxColumn21.IsVisible = false;
            gridViewTextBoxColumn21.Name = "estado";
            gridViewTextBoxColumn21.Width = 48;
            this.radGridView_deudas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21});
            this.radGridView_deudas.MasterTemplate.ShowFilteringRow = false;
            this.radGridView_deudas.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView_deudas.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridView_deudas.Name = "radGridView_deudas";
            this.radGridView_deudas.ReadOnly = true;
            this.radGridView_deudas.ShowGroupPanel = false;
            this.radGridView_deudas.Size = new System.Drawing.Size(652, 264);
            this.radGridView_deudas.TabIndex = 0;
            this.radGridView_deudas.Text = "radGridView1";
            this.radGridView_deudas.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radGroupBox2.Controls.Add(this.radButton_pagar);
            this.radGroupBox2.Controls.Add(this.radLabel_total);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.radDrop_cliente);
            this.radGroupBox2.Controls.Add(this.radLabel15);
            this.radGroupBox2.Controls.Add(this.radButton_ver);
            this.radGroupBox2.Controls.Add(this.radButton_copiar);
            this.radGroupBox2.Controls.Add(this.radButton_cancelar);
            this.radGroupBox2.Controls.Add(this.radButton_limpiar);
            this.radGroupBox2.Controls.Add(this.radButton_cargar);
            this.radGroupBox2.HeaderText = "Filtros de Búsqueda";
            this.radGroupBox2.Location = new System.Drawing.Point(19, 302);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(656, 127);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Filtros de Búsqueda";
            this.radGroupBox2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel_total
            // 
            this.radLabel_total.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radLabel_total.Location = new System.Drawing.Point(480, 25);
            this.radLabel_total.Name = "radLabel_total";
            this.radLabel_total.Size = new System.Drawing.Size(59, 33);
            this.radLabel_total.TabIndex = 46;
            this.radLabel_total.Text = " 0.00";
            this.radLabel_total.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radLabel5.Location = new System.Drawing.Point(437, 25);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(37, 33);
            this.radLabel5.TabIndex = 45;
            this.radLabel5.Text = "S/.";
            // 
            // radDrop_cliente
            // 
            this.radDrop_cliente.Location = new System.Drawing.Point(79, 30);
            this.radDrop_cliente.Name = "radDrop_cliente";
            this.radDrop_cliente.Size = new System.Drawing.Size(346, 24);
            this.radDrop_cliente.TabIndex = 44;
            this.radDrop_cliente.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel15
            // 
            this.radLabel15.Location = new System.Drawing.Point(17, 33);
            this.radLabel15.Name = "radLabel15";
            this.radLabel15.Size = new System.Drawing.Size(46, 18);
            this.radLabel15.TabIndex = 43;
            this.radLabel15.Text = "Cliente :";
            this.radLabel15.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radButton_ver
            // 
            this.radButton_ver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButton_ver.Image = global::appAvicola.Properties.Resources.editar;
            this.radButton_ver.Location = new System.Drawing.Point(317, 75);
            this.radButton_ver.Name = "radButton_ver";
            this.radButton_ver.Size = new System.Drawing.Size(112, 36);
            this.radButton_ver.TabIndex = 39;
            this.radButton_ver.Text = "Ver Cobros";
            this.radButton_ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_ver.ThemeName = "TelerikMetroBlue";
            this.radButton_ver.Click += new System.EventHandler(this.radButton_ver_Click);
            // 
            // radButton_copiar
            // 
            this.radButton_copiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButton_copiar.Image = global::appAvicola.Properties.Resources.copiar;
            this.radButton_copiar.Location = new System.Drawing.Point(437, 75);
            this.radButton_copiar.Name = "radButton_copiar";
            this.radButton_copiar.Size = new System.Drawing.Size(91, 36);
            this.radButton_copiar.TabIndex = 40;
            this.radButton_copiar.Text = "Copiar";
            this.radButton_copiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_copiar.ThemeName = "TelerikMetroBlue";
            this.radButton_copiar.Click += new System.EventHandler(this.radButton_copiar_Click);
            // 
            // radButton_cancelar
            // 
            this.radButton_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButton_cancelar.Image = global::appAvicola.Properties.Resources.cancelar;
            this.radButton_cancelar.Location = new System.Drawing.Point(539, 74);
            this.radButton_cancelar.Name = "radButton_cancelar";
            this.radButton_cancelar.Size = new System.Drawing.Size(91, 36);
            this.radButton_cancelar.TabIndex = 41;
            this.radButton_cancelar.Text = "Cancelar";
            this.radButton_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_cancelar.ThemeName = "TelerikMetroBlue";
            this.radButton_cancelar.Click += new System.EventHandler(this.radButton_cancelar_Click);
            // 
            // radButton_limpiar
            // 
            this.radButton_limpiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButton_limpiar.Image = global::appAvicola.Properties.Resources.limpiar;
            this.radButton_limpiar.Location = new System.Drawing.Point(125, 74);
            this.radButton_limpiar.Name = "radButton_limpiar";
            this.radButton_limpiar.Size = new System.Drawing.Size(91, 36);
            this.radButton_limpiar.TabIndex = 37;
            this.radButton_limpiar.Text = "limpiar";
            this.radButton_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_limpiar.ThemeName = "TelerikMetroBlue";
            this.radButton_limpiar.Click += new System.EventHandler(this.radButton_limpiar_Click);
            // 
            // radButton_cargar
            // 
            this.radButton_cargar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButton_cargar.Image = global::appAvicola.Properties.Resources.descargar;
            this.radButton_cargar.Location = new System.Drawing.Point(26, 74);
            this.radButton_cargar.Name = "radButton_cargar";
            this.radButton_cargar.Size = new System.Drawing.Size(91, 36);
            this.radButton_cargar.TabIndex = 36;
            this.radButton_cargar.Text = "Cargar";
            this.radButton_cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_cargar.ThemeName = "TelerikMetroBlue";
            this.radButton_cargar.Click += new System.EventHandler(this.radButton_cargar_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radGroupBox2);
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(698, 441);
            this.radPanel1.TabIndex = 2;
            this.radPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // radButton_pagar
            // 
            this.radButton_pagar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radButton_pagar.Image = global::appAvicola.Properties.Resources.cobro;
            this.radButton_pagar.Location = new System.Drawing.Point(222, 75);
            this.radButton_pagar.Name = "radButton_pagar";
            this.radButton_pagar.Size = new System.Drawing.Size(91, 36);
            this.radButton_pagar.TabIndex = 38;
            this.radButton_pagar.Text = "Pagar";
            this.radButton_pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_pagar.ThemeName = "TelerikMetroBlue";
            this.radButton_pagar.Click += new System.EventHandler(this.radButton_pagar_Click);
            // 
            // RadFormDeudaporCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 441);
            this.Controls.Add(this.radPanel1);
            this.Name = "RadFormDeudaporCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deuda por Cliente";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.RadFormDeudaporCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_deudas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView_deudas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_ver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_copiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton_pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView radGridView_deudas;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel_total;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList radDrop_cliente;
        private Telerik.WinControls.UI.RadLabel radLabel15;
        private Telerik.WinControls.UI.RadButton radButton_ver;
        private Telerik.WinControls.UI.RadButton radButton_copiar;
        private Telerik.WinControls.UI.RadButton radButton_cancelar;
        private Telerik.WinControls.UI.RadButton radButton_limpiar;
        private Telerik.WinControls.UI.RadButton radButton_cargar;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadButton radButton_pagar;
    }
}
