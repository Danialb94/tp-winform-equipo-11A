namespace presentacion
{
    partial class frmAltaArticulo
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
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.txtboxCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtboxNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtboxDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.cmbMarcaArticulo = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaArticulo = new System.Windows.Forms.ComboBox();
            this.txtboxPrecioArticulo = new System.Windows.Forms.TextBox();
            this.btnAceptarNuevoArticulo = new System.Windows.Forms.Button();
            this.btnCancelarNuevoArticulo = new System.Windows.Forms.Button();
            this.lblImagenArticulo = new System.Windows.Forms.Label();
            this.txtboxUrlImagenArticulo = new System.Windows.Forms.TextBox();
            this.picbImagenArticulo = new System.Windows.Forms.PictureBox();
            this.lblAltaArticulo = new System.Windows.Forms.Label();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.lblObligatorioCodigoAlta = new System.Windows.Forms.Label();
            this.lblObligatorioNombreAlta = new System.Windows.Forms.Label();
            this.lblObligatorioPrecioAlta = new System.Windows.Forms.Label();
            this.lblCamposObligatoriosfrmAlta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImgAgregadas = new System.Windows.Forms.Label();
            this.gbxNavegadorImg = new System.Windows.Forms.GroupBox();
            this.btnNavegarAtras = new System.Windows.Forms.Button();
            this.btnNavegarAdelante = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbImagenArticulo)).BeginInit();
            this.gbxNavegadorImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(80, 107);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Codigo:";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(76, 132);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "Nombre:";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(58, 156);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionArticulo.TabIndex = 2;
            this.lblDescripcionArticulo.Text = "Descripción:";
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.Location = new System.Drawing.Point(84, 180);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaArticulo.TabIndex = 3;
            this.lblMarcaArticulo.Text = "Marca:";
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(68, 206);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaArticulo.TabIndex = 4;
            this.lblCategoriaArticulo.Text = "Categoria:";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Location = new System.Drawing.Point(83, 232);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioArticulo.TabIndex = 5;
            this.lblPrecioArticulo.Text = "Precio:";
            // 
            // txtboxCodigoArticulo
            // 
            this.txtboxCodigoArticulo.Location = new System.Drawing.Point(143, 105);
            this.txtboxCodigoArticulo.Name = "txtboxCodigoArticulo";
            this.txtboxCodigoArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtboxCodigoArticulo.TabIndex = 0;
            this.txtboxCodigoArticulo.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // txtboxNombreArticulo
            // 
            this.txtboxNombreArticulo.Location = new System.Drawing.Point(143, 129);
            this.txtboxNombreArticulo.Name = "txtboxNombreArticulo";
            this.txtboxNombreArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtboxNombreArticulo.TabIndex = 1;
            this.txtboxNombreArticulo.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // txtboxDescripcionArticulo
            // 
            this.txtboxDescripcionArticulo.Location = new System.Drawing.Point(143, 154);
            this.txtboxDescripcionArticulo.Name = "txtboxDescripcionArticulo";
            this.txtboxDescripcionArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtboxDescripcionArticulo.TabIndex = 2;
            // 
            // cmbMarcaArticulo
            // 
            this.cmbMarcaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaArticulo.FormattingEnabled = true;
            this.cmbMarcaArticulo.Location = new System.Drawing.Point(143, 178);
            this.cmbMarcaArticulo.Name = "cmbMarcaArticulo";
            this.cmbMarcaArticulo.Size = new System.Drawing.Size(121, 21);
            this.cmbMarcaArticulo.TabIndex = 3;
           
            // cmbCategoriaArticulo
            // 
            this.cmbCategoriaArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaArticulo.FormattingEnabled = true;
            this.cmbCategoriaArticulo.Location = new System.Drawing.Point(143, 204);
            this.cmbCategoriaArticulo.Name = "cmbCategoriaArticulo";
            this.cmbCategoriaArticulo.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaArticulo.TabIndex = 4;
            // 
            // txtboxPrecioArticulo
            // 
            this.txtboxPrecioArticulo.Location = new System.Drawing.Point(143, 230);
            this.txtboxPrecioArticulo.Name = "txtboxPrecioArticulo";
            this.txtboxPrecioArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtboxPrecioArticulo.TabIndex = 5;
            this.txtboxPrecioArticulo.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnAceptarNuevoArticulo
            // 
            this.btnAceptarNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarNuevoArticulo.Location = new System.Drawing.Point(336, 328);
            this.btnAceptarNuevoArticulo.Name = "btnAceptarNuevoArticulo";
            this.btnAceptarNuevoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevoArticulo.TabIndex = 9;
            this.btnAceptarNuevoArticulo.Text = "Aceptar";
            this.btnAceptarNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnAceptarNuevoArticulo.Click += new System.EventHandler(this.btnAceptarNuevoArticulo_Click);
            // 
            // btnCancelarNuevoArticulo
            // 
            this.btnCancelarNuevoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarNuevoArticulo.Location = new System.Drawing.Point(417, 328);
            this.btnCancelarNuevoArticulo.Name = "btnCancelarNuevoArticulo";
            this.btnCancelarNuevoArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevoArticulo.TabIndex = 10;
            this.btnCancelarNuevoArticulo.Text = "Cancelar";
            this.btnCancelarNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoArticulo.Click += new System.EventHandler(this.btnCancelarNuevoArticulo_Click);
            // 
            // lblImagenArticulo
            // 
            this.lblImagenArticulo.AutoSize = true;
            this.lblImagenArticulo.Location = new System.Drawing.Point(64, 257);
            this.lblImagenArticulo.Name = "lblImagenArticulo";
            this.lblImagenArticulo.Size = new System.Drawing.Size(61, 13);
            this.lblImagenArticulo.TabIndex = 14;
            this.lblImagenArticulo.Text = "Url Imagen:";
            // 
            // txtboxUrlImagenArticulo
            // 
            this.txtboxUrlImagenArticulo.Location = new System.Drawing.Point(143, 257);
            this.txtboxUrlImagenArticulo.Name = "txtboxUrlImagenArticulo";
            this.txtboxUrlImagenArticulo.Size = new System.Drawing.Size(102, 20);
            this.txtboxUrlImagenArticulo.TabIndex = 6;
            this.txtboxUrlImagenArticulo.TextChanged += new System.EventHandler(this.txtboxUrlImagenArticulo_Leave);
            this.txtboxUrlImagenArticulo.Leave += new System.EventHandler(this.txtboxUrlImagenArticulo_Leave);
            // 
            // picbImagenArticulo
            // 
            this.picbImagenArticulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picbImagenArticulo.Location = new System.Drawing.Point(285, 63);
            this.picbImagenArticulo.Name = "picbImagenArticulo";
            this.picbImagenArticulo.Size = new System.Drawing.Size(184, 198);
            this.picbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbImagenArticulo.TabIndex = 16;
            this.picbImagenArticulo.TabStop = false;
            // 
            // lblAltaArticulo
            // 
            this.lblAltaArticulo.AutoSize = true;
            this.lblAltaArticulo.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaArticulo.Location = new System.Drawing.Point(50, 48);
            this.lblAltaArticulo.Name = "lblAltaArticulo";
            this.lblAltaArticulo.Size = new System.Drawing.Size(228, 29);
            this.lblAltaArticulo.TabIndex = 17;
            this.lblAltaArticulo.Text = "Alta de Articulo: ";
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(364, 268);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(104, 22);
            this.btnAgregarImg.TabIndex = 8;
            this.btnAgregarImg.Text = "Agregar Imagen";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // lblObligatorioCodigoAlta
            // 
            this.lblObligatorioCodigoAlta.AutoSize = true;
            this.lblObligatorioCodigoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioCodigoAlta.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorioCodigoAlta.Location = new System.Drawing.Point(262, 107);
            this.lblObligatorioCodigoAlta.Name = "lblObligatorioCodigoAlta";
            this.lblObligatorioCodigoAlta.Size = new System.Drawing.Size(17, 24);
            this.lblObligatorioCodigoAlta.TabIndex = 19;
            this.lblObligatorioCodigoAlta.Text = "*";
            // 
            // lblObligatorioNombreAlta
            // 
            this.lblObligatorioNombreAlta.AutoSize = true;
            this.lblObligatorioNombreAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioNombreAlta.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorioNombreAlta.Location = new System.Drawing.Point(261, 131);
            this.lblObligatorioNombreAlta.Name = "lblObligatorioNombreAlta";
            this.lblObligatorioNombreAlta.Size = new System.Drawing.Size(17, 24);
            this.lblObligatorioNombreAlta.TabIndex = 20;
            this.lblObligatorioNombreAlta.Text = "*";
            // 
            // lblObligatorioPrecioAlta
            // 
            this.lblObligatorioPrecioAlta.AutoSize = true;
            this.lblObligatorioPrecioAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorioPrecioAlta.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorioPrecioAlta.Location = new System.Drawing.Point(261, 230);
            this.lblObligatorioPrecioAlta.Name = "lblObligatorioPrecioAlta";
            this.lblObligatorioPrecioAlta.Size = new System.Drawing.Size(17, 24);
            this.lblObligatorioPrecioAlta.TabIndex = 21;
            this.lblObligatorioPrecioAlta.Text = "*";
            // 
            // lblCamposObligatoriosfrmAlta
            // 
            this.lblCamposObligatoriosfrmAlta.AutoSize = true;
            this.lblCamposObligatoriosfrmAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObligatoriosfrmAlta.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatoriosfrmAlta.Location = new System.Drawing.Point(58, 308);
            this.lblCamposObligatoriosfrmAlta.Name = "lblCamposObligatoriosfrmAlta";
            this.lblCamposObligatoriosfrmAlta.Size = new System.Drawing.Size(135, 16);
            this.lblCamposObligatoriosfrmAlta.TabIndex = 22;
            this.lblCamposObligatoriosfrmAlta.Text = " Campos obligatorios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // lblImgAgregadas
            // 
            this.lblImgAgregadas.AutoSize = true;
            this.lblImgAgregadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgAgregadas.Location = new System.Drawing.Point(141, 280);
            this.lblImgAgregadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImgAgregadas.Name = "lblImgAgregadas";
            this.lblImgAgregadas.Size = new System.Drawing.Size(89, 9);
            this.lblImgAgregadas.TabIndex = 24;
            this.lblImgAgregadas.Text = "No agregó imagenes aún";
            // 
            // gbxNavegadorImg
            // 
            this.gbxNavegadorImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxNavegadorImg.Controls.Add(this.btnNavegarAtras);
            this.gbxNavegadorImg.Controls.Add(this.btnNavegarAdelante);
            this.gbxNavegadorImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxNavegadorImg.Location = new System.Drawing.Point(293, 267);
            this.gbxNavegadorImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxNavegadorImg.Name = "gbxNavegadorImg";
            this.gbxNavegadorImg.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxNavegadorImg.Size = new System.Drawing.Size(60, 22);
            this.gbxNavegadorImg.TabIndex = 7;
            this.gbxNavegadorImg.TabStop = false;
            // 
            // btnNavegarAtras
            // 
            this.btnNavegarAtras.Location = new System.Drawing.Point(0, 0);
            this.btnNavegarAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNavegarAtras.Name = "btnNavegarAtras";
            this.btnNavegarAtras.Size = new System.Drawing.Size(20, 22);
            this.btnNavegarAtras.TabIndex = 17;
            this.btnNavegarAtras.Text = "<";
            this.btnNavegarAtras.UseVisualStyleBackColor = true;
            this.btnNavegarAtras.Click += new System.EventHandler(this.btnNavegarAtras_Click);
            // 
            // btnNavegarAdelante
            // 
            this.btnNavegarAdelante.Location = new System.Drawing.Point(40, 0);
            this.btnNavegarAdelante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNavegarAdelante.Name = "btnNavegarAdelante";
            this.btnNavegarAdelante.Size = new System.Drawing.Size(20, 22);
            this.btnNavegarAdelante.TabIndex = 18;
            this.btnNavegarAdelante.Text = ">";
            this.btnNavegarAdelante.UseVisualStyleBackColor = true;
            this.btnNavegarAdelante.Click += new System.EventHandler(this.btnNavegarAdelante_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(245, 257);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(18, 19);
            this.btnVaciar.TabIndex = 26;
            this.btnVaciar.Text = "X";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(502, 360);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.gbxNavegadorImg);
            this.Controls.Add(this.lblImgAgregadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCamposObligatoriosfrmAlta);
            this.Controls.Add(this.lblObligatorioPrecioAlta);
            this.Controls.Add(this.lblObligatorioNombreAlta);
            this.Controls.Add(this.lblObligatorioCodigoAlta);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.lblAltaArticulo);
            this.Controls.Add(this.picbImagenArticulo);
            this.Controls.Add(this.txtboxUrlImagenArticulo);
            this.Controls.Add(this.lblImagenArticulo);
            this.Controls.Add(this.btnCancelarNuevoArticulo);
            this.Controls.Add(this.btnAceptarNuevoArticulo);
            this.Controls.Add(this.txtboxPrecioArticulo);
            this.Controls.Add(this.cmbCategoriaArticulo);
            this.Controls.Add(this.cmbMarcaArticulo);
            this.Controls.Add(this.txtboxDescripcionArticulo);
            this.Controls.Add(this.txtboxNombreArticulo);
            this.Controls.Add(this.txtboxCodigoArticulo);
            this.Controls.Add(this.lblPrecioArticulo);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.lblMarcaArticulo);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbImagenArticulo)).EndInit();
            this.gbxNavegadorImg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.TextBox txtboxCodigoArticulo;
        private System.Windows.Forms.TextBox txtboxNombreArticulo;
        private System.Windows.Forms.TextBox txtboxDescripcionArticulo;
        private System.Windows.Forms.ComboBox cmbMarcaArticulo;
        private System.Windows.Forms.ComboBox cmbCategoriaArticulo;
        private System.Windows.Forms.TextBox txtboxPrecioArticulo;
        private System.Windows.Forms.Button btnAceptarNuevoArticulo;
        private System.Windows.Forms.Button btnCancelarNuevoArticulo;
        private System.Windows.Forms.Label lblImagenArticulo;
        private System.Windows.Forms.TextBox txtboxUrlImagenArticulo;
        private System.Windows.Forms.PictureBox picbImagenArticulo;
        private System.Windows.Forms.Label lblAltaArticulo;
        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.Label lblObligatorioCodigoAlta;
        private System.Windows.Forms.Label lblObligatorioNombreAlta;
        private System.Windows.Forms.Label lblObligatorioPrecioAlta;
        private System.Windows.Forms.Label lblCamposObligatoriosfrmAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImgAgregadas;
        private System.Windows.Forms.GroupBox gbxNavegadorImg;
        private System.Windows.Forms.Button btnNavegarAtras;
        private System.Windows.Forms.Button btnNavegarAdelante;
        private System.Windows.Forms.Button btnVaciar;
    }
}