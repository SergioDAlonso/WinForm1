namespace WinForm1
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
            this.bttFinalizar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.cbxPropietario = new System.Windows.Forms.CheckBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.numGrupoFamiliar = new System.Windows.Forms.NumericUpDown();
            this.rbIzq = new System.Windows.Forms.RadioButton();
            this.rbCentro = new System.Windows.Forms.RadioButton();
            this.rbDerecha = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblGrupoFamilia = new System.Windows.Forms.Label();
            this.lblPolitico = new System.Windows.Forms.Label();
            this.gbPolitico = new System.Windows.Forms.GroupBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGrupoFamiliar)).BeginInit();
            this.gbPolitico.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttFinalizar
            // 
            this.bttFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttFinalizar.FlatAppearance.BorderSize = 2;
            this.bttFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bttFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttFinalizar.Location = new System.Drawing.Point(19, 255);
            this.bttFinalizar.Name = "bttFinalizar";
            this.bttFinalizar.Size = new System.Drawing.Size(80, 44);
            this.bttFinalizar.TabIndex = 10;
            this.bttFinalizar.Text = "Finalizar";
            this.bttFinalizar.UseVisualStyleBackColor = true;
            this.bttFinalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(361, 190);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 13);
            this.lblSaludo.TabIndex = 7;
            // 
            // cbxPropietario
            // 
            this.cbxPropietario.AutoSize = true;
            this.cbxPropietario.Location = new System.Drawing.Point(134, 161);
            this.cbxPropietario.Name = "cbxPropietario";
            this.cbxPropietario.Size = new System.Drawing.Size(99, 17);
            this.cbxPropietario.TabIndex = 5;
            this.cbxPropietario.Text = "Soy propietario.";
            this.cbxPropietario.UseVisualStyleBackColor = true;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.CustomFormat = "d/m/y";
            this.dtNacimiento.Location = new System.Drawing.Point(131, 127);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtNacimiento.TabIndex = 4;
            // 
            // numGrupoFamiliar
            // 
            this.numGrupoFamiliar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numGrupoFamiliar.Location = new System.Drawing.Point(235, 188);
            this.numGrupoFamiliar.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numGrupoFamiliar.Name = "numGrupoFamiliar";
            this.numGrupoFamiliar.Size = new System.Drawing.Size(120, 20);
            this.numGrupoFamiliar.TabIndex = 6;
            // 
            // rbIzq
            // 
            this.rbIzq.AutoSize = true;
            this.rbIzq.Location = new System.Drawing.Point(4, 12);
            this.rbIzq.Name = "rbIzq";
            this.rbIzq.Size = new System.Drawing.Size(68, 17);
            this.rbIzq.TabIndex = 1;
            this.rbIzq.Text = "Izquierda";
            this.rbIzq.UseVisualStyleBackColor = true;
            // 
            // rbCentro
            // 
            this.rbCentro.AutoSize = true;
            this.rbCentro.Checked = true;
            this.rbCentro.Location = new System.Drawing.Point(78, 12);
            this.rbCentro.Name = "rbCentro";
            this.rbCentro.Size = new System.Drawing.Size(56, 17);
            this.rbCentro.TabIndex = 0;
            this.rbCentro.TabStop = true;
            this.rbCentro.Text = "Centro";
            this.rbCentro.UseVisualStyleBackColor = true;
            // 
            // rbDerecha
            // 
            this.rbDerecha.AutoSize = true;
            this.rbDerecha.Location = new System.Drawing.Point(157, 12);
            this.rbDerecha.Name = "rbDerecha";
            this.rbDerecha.Size = new System.Drawing.Size(66, 17);
            this.rbDerecha.TabIndex = 1;
            this.rbDerecha.Text = "Derecha";
            this.rbDerecha.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 93);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(111, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(189, 38);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Carga Perfil";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 96);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(16, 127);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblNacimiento.TabIndex = 13;
            this.lblNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(12, 161);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(112, 13);
            this.lblPropietario.TabIndex = 14;
            this.lblPropietario.Text = "¿Es usted propietario?";
            // 
            // lblGrupoFamilia
            // 
            this.lblGrupoFamilia.AutoSize = true;
            this.lblGrupoFamilia.Location = new System.Drawing.Point(16, 190);
            this.lblGrupoFamilia.Name = "lblGrupoFamilia";
            this.lblGrupoFamilia.Size = new System.Drawing.Size(211, 13);
            this.lblGrupoFamilia.TabIndex = 15;
            this.lblGrupoFamilia.Text = "¿Cuantas personas comparten la vivienda?";
            // 
            // lblPolitico
            // 
            this.lblPolitico.AutoSize = true;
            this.lblPolitico.Location = new System.Drawing.Point(16, 231);
            this.lblPolitico.Name = "lblPolitico";
            this.lblPolitico.Size = new System.Drawing.Size(166, 13);
            this.lblPolitico.TabIndex = 9;
            this.lblPolitico.Text = "¿Cual es su alineamineto politico?";
            // 
            // gbPolitico
            // 
            this.gbPolitico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPolitico.Controls.Add(this.rbCentro);
            this.gbPolitico.Controls.Add(this.rbIzq);
            this.gbPolitico.Controls.Add(this.rbDerecha);
            this.gbPolitico.Location = new System.Drawing.Point(188, 214);
            this.gbPolitico.Name = "gbPolitico";
            this.gbPolitico.Size = new System.Drawing.Size(251, 32);
            this.gbPolitico.TabIndex = 17;
            this.gbPolitico.TabStop = false;
            this.gbPolitico.Text = "Elija uno:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(404, 58);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(125, 13);
            this.lblDestino.TabIndex = 8;
            this.lblDestino.Text = "Elija un destino preferido:";
            // 
            // cbDestino
            // 
            this.cbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(535, 55);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(176, 21);
            this.cbDestino.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(752, 311);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.gbPolitico);
            this.Controls.Add(this.lblPolitico);
            this.Controls.Add(this.lblGrupoFamilia);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.numGrupoFamiliar);
            this.Controls.Add(this.dtNacimiento);
            this.Controls.Add(this.cbxPropietario);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.bttFinalizar);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(768, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGrupoFamiliar)).EndInit();
            this.gbPolitico.ResumeLayout(false);
            this.gbPolitico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttFinalizar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.CheckBox cbxPropietario;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.NumericUpDown numGrupoFamiliar;
        private System.Windows.Forms.RadioButton rbIzq;
        private System.Windows.Forms.RadioButton rbCentro;
        private System.Windows.Forms.RadioButton rbDerecha;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblGrupoFamilia;
        private System.Windows.Forms.Label lblPolitico;
        private System.Windows.Forms.GroupBox gbPolitico;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cbDestino;
    }
}

