namespace VirtualRaceUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.btnCrearCarrera = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbListadoAutos = new System.Windows.Forms.GroupBox();
            this.gpbAuto = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombrePioloto = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.lsbAutos = new System.Windows.Forms.ListBox();
            this.cmbCorrerCarreraPor = new System.Windows.Forms.ComboBox();
            this.lblCorrerCarreraPor = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gpbCarrera.SuspendLayout();
            this.gpbListadoAutos.SuspendLayout();
            this.gpbAuto.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.lblFecha);
            this.gpbCarrera.Controls.Add(this.btnCrearCarrera);
            this.gpbCarrera.Controls.Add(this.txtFecha);
            this.gpbCarrera.Controls.Add(this.txtLugar);
            this.gpbCarrera.Controls.Add(this.lblLugar);
            this.gpbCarrera.Controls.Add(this.txtNombre);
            this.gpbCarrera.Controls.Add(this.lblNombre);
            this.gpbCarrera.Location = new System.Drawing.Point(12, 12);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(562, 100);
            this.gpbCarrera.TabIndex = 0;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "&Carrera";
            // 
            // btnCrearCarrera
            // 
            this.btnCrearCarrera.Location = new System.Drawing.Point(444, 49);
            this.btnCrearCarrera.Name = "btnCrearCarrera";
            this.btnCrearCarrera.Size = new System.Drawing.Size(93, 23);
            this.btnCrearCarrera.TabIndex = 6;
            this.btnCrearCarrera.Text = "&Crear Carrera";
            this.btnCrearCarrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrera.Click += new System.EventHandler(this.btnCrearCarrera_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(304, 49);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(172, 49);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 3;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(169, 32);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "&Lugar:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(38, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "&Nombre:";
            // 
            // gpbListadoAutos
            // 
            this.gpbListadoAutos.Controls.Add(this.lsbAutos);
            this.gpbListadoAutos.Location = new System.Drawing.Point(325, 118);
            this.gpbListadoAutos.Name = "gpbListadoAutos";
            this.gpbListadoAutos.Size = new System.Drawing.Size(249, 375);
            this.gpbListadoAutos.TabIndex = 1;
            this.gpbListadoAutos.TabStop = false;
            this.gpbListadoAutos.Text = "&Listado de autos";
            // 
            // gpbAuto
            // 
            this.gpbAuto.Controls.Add(this.btnAgregarAuto);
            this.gpbAuto.Controls.Add(this.lblFabricante);
            this.gpbAuto.Controls.Add(this.lblNombrePioloto);
            this.gpbAuto.Controls.Add(this.cmbFabricante);
            this.gpbAuto.Controls.Add(this.txtNombrePiloto);
            this.gpbAuto.Location = new System.Drawing.Point(12, 118);
            this.gpbAuto.Name = "gpbAuto";
            this.gpbAuto.Size = new System.Drawing.Size(307, 161);
            this.gpbAuto.TabIndex = 1;
            this.gpbAuto.TabStop = false;
            this.gpbAuto.Text = "&Auto";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(25, 93);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(100, 21);
            this.cmbFabricante.TabIndex = 4;
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(25, 46);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePiloto.TabIndex = 3;
            this.txtNombrePiloto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.txtResultado);
            this.gpbResultado.Controls.Add(this.btnCorrerCarrera);
            this.gpbResultado.Controls.Add(this.lblCantidad);
            this.gpbResultado.Controls.Add(this.numCantidad);
            this.gpbResultado.Controls.Add(this.lblCorrerCarreraPor);
            this.gpbResultado.Controls.Add(this.cmbCorrerCarreraPor);
            this.gpbResultado.Location = new System.Drawing.Point(12, 285);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(307, 208);
            this.gpbResultado.TabIndex = 1;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "&Resultados";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(304, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "&Fecha:";
            // 
            // lblNombrePioloto
            // 
            this.lblNombrePioloto.AutoSize = true;
            this.lblNombrePioloto.Location = new System.Drawing.Point(25, 30);
            this.lblNombrePioloto.Name = "lblNombrePioloto";
            this.lblNombrePioloto.Size = new System.Drawing.Size(75, 13);
            this.lblNombrePioloto.TabIndex = 5;
            this.lblNombrePioloto.Text = "&Nombre piloto:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(25, 77);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(60, 13);
            this.lblFabricante.TabIndex = 6;
            this.lblFabricante.Text = "&Fabricante:";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(174, 65);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(98, 37);
            this.btnAgregarAuto.TabIndex = 7;
            this.btnAgregarAuto.Text = "&Agregar auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // lsbAutos
            // 
            this.lsbAutos.FormattingEnabled = true;
            this.lsbAutos.Location = new System.Drawing.Point(7, 20);
            this.lsbAutos.Name = "lsbAutos";
            this.lsbAutos.Size = new System.Drawing.Size(236, 342);
            this.lsbAutos.TabIndex = 0;
            // 
            // cmbCorrerCarreraPor
            // 
            this.cmbCorrerCarreraPor.FormattingEnabled = true;
            this.cmbCorrerCarreraPor.Location = new System.Drawing.Point(6, 44);
            this.cmbCorrerCarreraPor.Name = "cmbCorrerCarreraPor";
            this.cmbCorrerCarreraPor.Size = new System.Drawing.Size(121, 21);
            this.cmbCorrerCarreraPor.TabIndex = 0;
            // 
            // lblCorrerCarreraPor
            // 
            this.lblCorrerCarreraPor.AutoSize = true;
            this.lblCorrerCarreraPor.Location = new System.Drawing.Point(6, 29);
            this.lblCorrerCarreraPor.Name = "lblCorrerCarreraPor";
            this.lblCorrerCarreraPor.Size = new System.Drawing.Size(92, 13);
            this.lblCorrerCarreraPor.TabIndex = 1;
            this.lblCorrerCarreraPor.Text = "&Correr carrera por:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(7, 88);
            this.numCantidad.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            this.numCantidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 72);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "&Cantidad:";
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(150, 51);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(142, 54);
            this.btnCorrerCarrera.TabIndex = 4;
            this.btnCorrerCarrera.Text = "¡&Correr carrera!";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            this.btnCorrerCarrera.Click += new System.EventHandler(this.btnCorrerCarrera_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 115);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(286, 80);
            this.txtResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 499);
            this.Controls.Add(this.gpbListadoAutos);
            this.Controls.Add(this.gpbAuto);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbListadoAutos.ResumeLayout(false);
            this.gpbAuto.ResumeLayout(false);
            this.gpbAuto.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.Button btnCrearCarrera;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gpbListadoAutos;
        private System.Windows.Forms.GroupBox gpbAuto;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblNombrePioloto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.ListBox lsbAutos;
        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCorrerCarreraPor;
        private System.Windows.Forms.ComboBox cmbCorrerCarreraPor;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

