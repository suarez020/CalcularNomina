namespace CalcularNomina
{
    partial class FrmCalcularSalarioJuanRubio
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
            this.lblCalcularNomina = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblSalarioDia = new System.Windows.Forms.Label();
            this.lblDiasLaborados = new System.Windows.Forms.Label();
            this.lblTotalDevendado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtSalarioDia = new System.Windows.Forms.TextBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.txtValorDevengado = new System.Windows.Forms.TextBox();
            this.btnAlmacenarRegistro = new System.Windows.Forms.Button();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalcularNomina
            // 
            this.lblCalcularNomina.AutoSize = true;
            this.lblCalcularNomina.Location = new System.Drawing.Point(177, 4);
            this.lblCalcularNomina.Name = "lblCalcularNomina";
            this.lblCalcularNomina.Size = new System.Drawing.Size(98, 13);
            this.lblCalcularNomina.TabIndex = 0;
            this.lblCalcularNomina.Text = "Calcular la Nomina ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(36, 89);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(40, 13);
            this.lblIdentificacion.TabIndex = 2;
            this.lblIdentificacion.Text = "Cedula";
            // 
            // lblSalarioDia
            // 
            this.lblSalarioDia.AutoSize = true;
            this.lblSalarioDia.Location = new System.Drawing.Point(36, 118);
            this.lblSalarioDia.Name = "lblSalarioDia";
            this.lblSalarioDia.Size = new System.Drawing.Size(92, 13);
            this.lblSalarioDia.TabIndex = 3;
            this.lblSalarioDia.Text = "Asignar salario dia";
            // 
            // lblDiasLaborados
            // 
            this.lblDiasLaborados.AutoSize = true;
            this.lblDiasLaborados.Location = new System.Drawing.Point(36, 145);
            this.lblDiasLaborados.Name = "lblDiasLaborados";
            this.lblDiasLaborados.Size = new System.Drawing.Size(81, 13);
            this.lblDiasLaborados.TabIndex = 4;
            this.lblDiasLaborados.Text = "Dias Laborados";
            // 
            // lblTotalDevendado
            // 
            this.lblTotalDevendado.AutoSize = true;
            this.lblTotalDevendado.Location = new System.Drawing.Point(168, 251);
            this.lblTotalDevendado.Name = "lblTotalDevendado";
            this.lblTotalDevendado.Size = new System.Drawing.Size(117, 13);
            this.lblTotalDevendado.TabIndex = 5;
            this.lblTotalDevendado.Text = "Valor Total Devengado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(138, 93);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 7;
            // 
            // txtSalarioDia
            // 
            this.txtSalarioDia.Location = new System.Drawing.Point(138, 119);
            this.txtSalarioDia.Name = "txtSalarioDia";
            this.txtSalarioDia.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioDia.TabIndex = 8;
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(138, 155);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(100, 20);
            this.txtDiasLaborados.TabIndex = 9;
            // 
            // txtValorDevengado
            // 
            this.txtValorDevengado.Location = new System.Drawing.Point(291, 248);
            this.txtValorDevengado.Name = "txtValorDevengado";
            this.txtValorDevengado.Size = new System.Drawing.Size(178, 20);
            this.txtValorDevengado.TabIndex = 10;
            // 
            // btnAlmacenarRegistro
            // 
            this.btnAlmacenarRegistro.Location = new System.Drawing.Point(153, 196);
            this.btnAlmacenarRegistro.Name = "btnAlmacenarRegistro";
            this.btnAlmacenarRegistro.Size = new System.Drawing.Size(327, 23);
            this.btnAlmacenarRegistro.TabIndex = 11;
            this.btnAlmacenarRegistro.Text = "Guardar Registro Del Empleado";
            this.btnAlmacenarRegistro.UseVisualStyleBackColor = true;
            this.btnAlmacenarRegistro.Click += new System.EventHandler(this.btnAlmacenarRegistro_Click);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(153, 225);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(327, 23);
            this.btnCalcularSalario.TabIndex = 12;
            this.btnCalcularSalario.Text = "Calcular Salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(85, 308);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 13;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmCalcularSalarioJuanRubio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 415);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnAlmacenarRegistro);
            this.Controls.Add(this.txtValorDevengado);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.txtSalarioDia);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTotalDevendado);
            this.Controls.Add(this.lblDiasLaborados);
            this.Controls.Add(this.lblSalarioDia);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCalcularNomina);
            this.Name = "FrmCalcularSalarioJuanRubio";
            this.Text = "CalcularSalarioJuanRubio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalcularNomina;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblSalarioDia;
        private System.Windows.Forms.Label lblDiasLaborados;
        private System.Windows.Forms.Label lblTotalDevendado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtSalarioDia;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.TextBox txtValorDevengado;
        private System.Windows.Forms.Button btnAlmacenarRegistro;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnSalir;
    }
}

