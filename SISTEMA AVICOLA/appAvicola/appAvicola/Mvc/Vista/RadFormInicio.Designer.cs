namespace appAvicola.Mvc.Vista
{
    partial class RadFormInicio
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
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton_cancelar = new Telerik.WinControls.UI.RadButton();
            this.radButton_aceptar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radText_clave = new Telerik.WinControls.UI.RadTextBox();
            this.radText_usuario = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radDrop_almacen = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radDrop_sucursal = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDrop_empresa = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_aceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radText_clave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radText_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_almacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_sucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radButton_cancelar);
            this.radPanel1.Controls.Add(this.radButton_aceptar);
            this.radPanel1.Controls.Add(this.radGroupBox1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(365, 326);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // radButton_cancelar
            // 
            this.radButton_cancelar.Image = global::appAvicola.Properties.Resources.cancelar;
            this.radButton_cancelar.Location = new System.Drawing.Point(201, 261);
            this.radButton_cancelar.Name = "radButton_cancelar";
            this.radButton_cancelar.Size = new System.Drawing.Size(91, 36);
            this.radButton_cancelar.TabIndex = 17;
            this.radButton_cancelar.Text = "Cancelar";
            this.radButton_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_cancelar.ThemeName = "TelerikMetroBlue";
            this.radButton_cancelar.Click += new System.EventHandler(this.radButton_cancelar_Click);
            // 
            // radButton_aceptar
            // 
            this.radButton_aceptar.Image = global::appAvicola.Properties.Resources.aceptar;
            this.radButton_aceptar.Location = new System.Drawing.Point(85, 261);
            this.radButton_aceptar.Name = "radButton_aceptar";
            this.radButton_aceptar.Size = new System.Drawing.Size(91, 36);
            this.radButton_aceptar.TabIndex = 16;
            this.radButton_aceptar.Text = "Aceptar";
            this.radButton_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButton_aceptar.ThemeName = "TelerikMetroBlue";
            this.radButton_aceptar.Click += new System.EventHandler(this.radButton_guardar_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radText_clave);
            this.radGroupBox1.Controls.Add(this.radText_usuario);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radDrop_almacen);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radDrop_sucursal);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radDrop_empresa);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderText = "Acceso al Sistema";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(343, 232);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Acceso al Sistema";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radText_clave
            // 
            this.radText_clave.Location = new System.Drawing.Point(121, 188);
            this.radText_clave.Name = "radText_clave";
            this.radText_clave.PasswordChar = '*';
            this.radText_clave.Size = new System.Drawing.Size(152, 24);
            this.radText_clave.TabIndex = 12;
            this.radText_clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radText_clave.ThemeName = "TelerikMetroBlue";
            this.radText_clave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radText_clave_KeyDown);
            // 
            // radText_usuario
            // 
            this.radText_usuario.Location = new System.Drawing.Point(121, 154);
            this.radText_usuario.Name = "radText_usuario";
            this.radText_usuario.Size = new System.Drawing.Size(152, 24);
            this.radText_usuario.TabIndex = 11;
            this.radText_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radText_usuario.ThemeName = "TelerikMetroBlue";
            this.radText_usuario.TextChanged += new System.EventHandler(this.radText_usuario_TextChanged);
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(65, 190);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(42, 19);
            this.radLabel5.TabIndex = 10;
            this.radLabel5.Text = "Clave :";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(65, 156);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(54, 19);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "Usuario :";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radDrop_almacen
            // 
            this.radDrop_almacen.DropDownMinSize = new System.Drawing.Size(400, 0);
            this.radDrop_almacen.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDrop_almacen.Location = new System.Drawing.Point(74, 113);
            this.radDrop_almacen.Name = "radDrop_almacen";
            this.radDrop_almacen.Size = new System.Drawing.Size(243, 24);
            this.radDrop_almacen.TabIndex = 8;
            this.radDrop_almacen.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDrop_almacen.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 116);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(60, 19);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Almacen :";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radDrop_sucursal
            // 
            this.radDrop_sucursal.DropDownMinSize = new System.Drawing.Size(400, 0);
            this.radDrop_sucursal.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDrop_sucursal.Location = new System.Drawing.Point(74, 79);
            this.radDrop_sucursal.Name = "radDrop_sucursal";
            this.radDrop_sucursal.Size = new System.Drawing.Size(243, 24);
            this.radDrop_sucursal.TabIndex = 6;
            this.radDrop_sucursal.ThemeName = "TelerikMetroBlue";
            this.radDrop_sucursal.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDrop_sucursal_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDrop_sucursal.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 82);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(58, 19);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Sucursal :";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radDrop_empresa
            // 
            this.radDrop_empresa.DropDownMinSize = new System.Drawing.Size(400, 0);
            this.radDrop_empresa.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDrop_empresa.Location = new System.Drawing.Point(74, 43);
            this.radDrop_empresa.Name = "radDrop_empresa";
            this.radDrop_empresa.Size = new System.Drawing.Size(243, 24);
            this.radDrop_empresa.TabIndex = 4;
            this.radDrop_empresa.ThemeName = "TelerikMetroBlue";
            this.radDrop_empresa.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDrop_empresa_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDrop_empresa.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 46);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 19);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Empresa :";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // RadFormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 326);
            this.Controls.Add(this.radPanel1);
            this.MaximizeBox = false;
            this.Name = "RadFormInicio";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.RadFormInicio_Load);
            this.Shown += new System.EventHandler(this.RadFormInicio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton_aceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radText_clave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radText_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_almacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_sucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDrop_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox radText_usuario;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList radDrop_almacen;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList radDrop_sucursal;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList radDrop_empresa;
        private Telerik.WinControls.UI.RadTextBox radText_clave;
        private Telerik.WinControls.UI.RadButton radButton_cancelar;
        private Telerik.WinControls.UI.RadButton radButton_aceptar;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}
