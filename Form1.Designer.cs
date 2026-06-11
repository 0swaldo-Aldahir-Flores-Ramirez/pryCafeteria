namespace pryCafeteria
{
    partial class fmrCafeteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrCafeteria));
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBebida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbBebidaCaliente = new System.Windows.Forms.RadioButton();
            this.rdbBebidaFria = new System.Windows.Forms.RadioButton();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.rdbBebidaAlcoholica = new System.Windows.Forms.RadioButton();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.Bisque;
            this.grb1.Controls.Add(this.rdbBebidaAlcoholica);
            this.grb1.Controls.Add(this.btnAgregar);
            this.grb1.Controls.Add(this.txtExtra);
            this.grb1.Controls.Add(this.lblExtra);
            this.grb1.Controls.Add(this.cmbTamaño);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.txtPrecio);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.txtBebida);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.rdbBebidaCaliente);
            this.grb1.Controls.Add(this.rdbBebidaFria);
            this.grb1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(328, 521);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Captura de Bebidas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(119, 440);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 51);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(17, 390);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(213, 28);
            this.txtExtra.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(13, 367);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(147, 20);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Cantidad de hielo";
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmbTamaño.Location = new System.Drawing.Point(17, 305);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(213, 28);
            this.cmbTamaño.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamaño";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(17, 223);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(213, 28);
            this.txtPrecio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // txtBebida
            // 
            this.txtBebida.Location = new System.Drawing.Point(17, 159);
            this.txtBebida.Name = "txtBebida";
            this.txtBebida.Size = new System.Drawing.Size(213, 28);
            this.txtBebida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la bebida";
            // 
            // rdbBebidaCaliente
            // 
            this.rdbBebidaCaliente.AutoSize = true;
            this.rdbBebidaCaliente.Location = new System.Drawing.Point(143, 63);
            this.rdbBebidaCaliente.Name = "rdbBebidaCaliente";
            this.rdbBebidaCaliente.Size = new System.Drawing.Size(153, 24);
            this.rdbBebidaCaliente.TabIndex = 1;
            this.rdbBebidaCaliente.TabStop = true;
            this.rdbBebidaCaliente.Text = "Bebida Caliente";
            this.rdbBebidaCaliente.UseVisualStyleBackColor = true;
            this.rdbBebidaCaliente.CheckedChanged += new System.EventHandler(this.rdbBebidaCaliente_CheckedChanged);
            // 
            // rdbBebidaFria
            // 
            this.rdbBebidaFria.AutoSize = true;
            this.rdbBebidaFria.Location = new System.Drawing.Point(17, 63);
            this.rdbBebidaFria.Name = "rdbBebidaFria";
            this.rdbBebidaFria.Size = new System.Drawing.Size(120, 24);
            this.rdbBebidaFria.TabIndex = 0;
            this.rdbBebidaFria.TabStop = true;
            this.rdbBebidaFria.Text = "Bebida Fria";
            this.rdbBebidaFria.UseVisualStyleBackColor = true;
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.lsbLista);
            this.grb2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb2.Location = new System.Drawing.Point(364, 12);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(357, 296);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = "Bebidas Agregadas";
            // 
            // lsbLista
            // 
            this.lsbLista.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 20;
            this.lsbLista.Location = new System.Drawing.Point(6, 27);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(345, 244);
            this.lsbLista.TabIndex = 0;
            this.lsbLista.SelectedIndexChanged += new System.EventHandler(this.lsbLista_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(367, 311);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 20);
            this.lblDescripcion.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(367, 356);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 19);
            this.lblCantidad.TabIndex = 3;
            // 
            // rdbBebidaAlcoholica
            // 
            this.rdbBebidaAlcoholica.AutoSize = true;
            this.rdbBebidaAlcoholica.Location = new System.Drawing.Point(60, 93);
            this.rdbBebidaAlcoholica.Name = "rdbBebidaAlcoholica";
            this.rdbBebidaAlcoholica.Size = new System.Drawing.Size(171, 24);
            this.rdbBebidaAlcoholica.TabIndex = 11;
            this.rdbBebidaAlcoholica.TabStop = true;
            this.rdbBebidaAlcoholica.Text = "Bebida Alcoholica";
            this.rdbBebidaAlcoholica.UseVisualStyleBackColor = true;
            // 
            // fmrCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(733, 552);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafeteria";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TextBox txtBebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbBebidaCaliente;
        private System.Windows.Forms.RadioButton rdbBebidaFria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.RadioButton rdbBebidaAlcoholica;
    }
}

