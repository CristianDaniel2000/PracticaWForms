namespace RegistroMonitores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.dtgDatosMonitores = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIdElimnar = new System.Windows.Forms.Label();
            this.txtElimar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosMonitores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(18, 288);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(183, 29);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AccessibleDescription = "";
            this.lblMarca.AccessibleName = "";
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(15, 29);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(15, 71);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(15, 115);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(84, 13);
            this.lblNumeroSerie.TabIndex = 3;
            this.lblNumeroSerie.Text = "Número de serie";
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(15, 157);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(60, 13);
            this.lblEtiqueta.TabIndex = 4;
            this.lblEtiqueta.Text = "ID Etiqueta";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(15, 198);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(69, 13);
            this.lblResponsable.TabIndex = 5;
            this.lblResponsable.Text = "Responsable";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(15, 243);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // dtgDatosMonitores
            // 
            this.dtgDatosMonitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosMonitores.Location = new System.Drawing.Point(221, 45);
            this.dtgDatosMonitores.Name = "dtgDatosMonitores";
            this.dtgDatosMonitores.Size = new System.Drawing.Size(544, 285);
            this.dtgDatosMonitores.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AccessibleDescription = "";
            this.lblTitulo.AccessibleName = "";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(353, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 13);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "INVENTARIO DE SERVIDORES - CRIS PRACTICA";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(72, 29);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(129, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(72, 68);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(129, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(105, 112);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(96, 20);
            this.txtNumSerie.TabIndex = 11;
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Location = new System.Drawing.Point(105, 150);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(96, 20);
            this.txtEtiqueta.TabIndex = 12;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(105, 195);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(96, 20);
            this.txtResponsable.TabIndex = 13;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(72, 243);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(129, 20);
            this.txtUbicacion.TabIndex = 14;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(18, 334);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(183, 29);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar Registros";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(232, 365);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIdElimnar
            // 
            this.lblIdElimnar.AutoSize = true;
            this.lblIdElimnar.Location = new System.Drawing.Point(229, 342);
            this.lblIdElimnar.Name = "lblIdElimnar";
            this.lblIdElimnar.Size = new System.Drawing.Size(18, 13);
            this.lblIdElimnar.TabIndex = 18;
            this.lblIdElimnar.Text = "ID";
            // 
            // txtElimar
            // 
            this.txtElimar.Location = new System.Drawing.Point(253, 342);
            this.txtElimar.Name = "txtElimar";
            this.txtElimar.Size = new System.Drawing.Size(73, 20);
            this.txtElimar.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.txtElimar);
            this.Controls.Add(this.lblIdElimnar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtgDatosMonitores);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosMonitores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.DataGridView dtgDatosMonitores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdElimnar;
        private System.Windows.Forms.TextBox txtElimar;
    }
}

