namespace presentacion
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblFiltroArticulos = new System.Windows.Forms.Label();
            this.txtboxFiltroArticulos = new System.Windows.Forms.TextBox();
            this.lblCampoArticulo = new System.Windows.Forms.Label();
            this.cboCampoArticulo = new System.Windows.Forms.ComboBox();
            this.cboCriterioArticulos = new System.Windows.Forms.ComboBox();
            this.lblCriterioArticulos = new System.Windows.Forms.Label();
            this.lblFiltroAvanzadoArticulos = new System.Windows.Forms.Label();
            this.txtboxFiltroAvanzadoArticulos = new System.Windows.Forms.TextBox();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnNavegarAtras = new System.Windows.Forms.Button();
            this.btnNavegarAdelante = new System.Windows.Forms.Button();
            this.gbxNavegadorImg = new System.Windows.Forms.GroupBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.btnModificarImg = new System.Windows.Forms.Button();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbxNavegadorImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.marcaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1222, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticulosToolStripMenuItem});
            this.articuloToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.articuloToolStripMenuItem.Text = "Artículos";
            // 
            // agregarArticulosToolStripMenuItem
            // 
            this.agregarArticulosToolStripMenuItem.Name = "agregarArticulosToolStripMenuItem";
            this.agregarArticulosToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.agregarArticulosToolStripMenuItem.Text = "Agregar Artículos";
            this.agregarArticulosToolStripMenuItem.Click += new System.EventHandler(this.agregarArticulosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCategoriaToolStripMenuItem,
            this.agregarCategoriaToolStripMenuItem,
            this.modificarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem});
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.categoriaToolStripMenuItem.Text = "Categorías";
            // 
            // listadoDeCategoriaToolStripMenuItem
            // 
            this.listadoDeCategoriaToolStripMenuItem.Name = "listadoDeCategoriaToolStripMenuItem";
            this.listadoDeCategoriaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.listadoDeCategoriaToolStripMenuItem.Text = "Listado de Categoría";
            this.listadoDeCategoriaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCategoriaToolStripMenuItem_Click);
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoría";
            this.agregarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriaToolStripMenuItem_Click);
            // 
            // modificarCategoriaToolStripMenuItem
            // 
            this.modificarCategoriaToolStripMenuItem.Name = "modificarCategoriaToolStripMenuItem";
            this.modificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.modificarCategoriaToolStripMenuItem.Text = "Modificar Categoría";
            this.modificarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.modificarCategoriaToolStripMenuItem_Click);
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoría";
            this.eliminarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCategoriaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeMarcaToolStripMenuItem,
            this.agregarMarcaToolStripMenuItem});
            this.marcaToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F);
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.marcaToolStripMenuItem.Text = "Marcas";
            // 
            // listadoDeMarcaToolStripMenuItem
            // 
            this.listadoDeMarcaToolStripMenuItem.Name = "listadoDeMarcaToolStripMenuItem";
            this.listadoDeMarcaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.listadoDeMarcaToolStripMenuItem.Text = "Listado de Marcas";
            this.listadoDeMarcaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeMarcaToolStripMenuItem_Click);
            // 
            // agregarMarcaToolStripMenuItem
            // 
            this.agregarMarcaToolStripMenuItem.Name = "agregarMarcaToolStripMenuItem";
            this.agregarMarcaToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.agregarMarcaToolStripMenuItem.Text = "Agregar Marca";
            this.agregarMarcaToolStripMenuItem.Click += new System.EventHandler(this.agregarMarcaToolStripMenuItem_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(27, 116);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(881, 413);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Listado de Artículos";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(931, 116);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxArticulo.MaximumSize = new System.Drawing.Size(267, 314);
            this.pbxArticulo.MinimumSize = new System.Drawing.Size(267, 314);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(267, 314);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 3;
            this.pbxArticulo.TabStop = false;
            // 
            // lblFiltroArticulos
            // 
            this.lblFiltroArticulos.AutoSize = true;
            this.lblFiltroArticulos.Location = new System.Drawing.Point(29, 92);
            this.lblFiltroArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroArticulos.Name = "lblFiltroArticulos";
            this.lblFiltroArticulos.Size = new System.Drawing.Size(84, 16);
            this.lblFiltroArticulos.TabIndex = 4;
            this.lblFiltroArticulos.Text = "Filtro Rápido";
            // 
            // txtboxFiltroArticulos
            // 
            this.txtboxFiltroArticulos.Location = new System.Drawing.Point(140, 88);
            this.txtboxFiltroArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFiltroArticulos.Name = "txtboxFiltroArticulos";
            this.txtboxFiltroArticulos.Size = new System.Drawing.Size(277, 22);
            this.txtboxFiltroArticulos.TabIndex = 5;
            this.txtboxFiltroArticulos.TextChanged += new System.EventHandler(this.txtboxFiltroArticulos_TextChanged);
            // 
            // lblCampoArticulo
            // 
            this.lblCampoArticulo.AutoSize = true;
            this.lblCampoArticulo.Location = new System.Drawing.Point(25, 607);
            this.lblCampoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampoArticulo.Name = "lblCampoArticulo";
            this.lblCampoArticulo.Size = new System.Drawing.Size(54, 16);
            this.lblCampoArticulo.TabIndex = 6;
            this.lblCampoArticulo.Text = "Campo:";
            // 
            // cboCampoArticulo
            // 
            this.cboCampoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoArticulo.FormattingEnabled = true;
            this.cboCampoArticulo.Location = new System.Drawing.Point(104, 602);
            this.cboCampoArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCampoArticulo.Name = "cboCampoArticulo";
            this.cboCampoArticulo.Size = new System.Drawing.Size(160, 24);
            this.cboCampoArticulo.TabIndex = 7;
            this.cboCampoArticulo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboCriterioArticulos
            // 
            this.cboCriterioArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioArticulos.FormattingEnabled = true;
            this.cboCriterioArticulos.Location = new System.Drawing.Point(364, 602);
            this.cboCriterioArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.cboCriterioArticulos.Name = "cboCriterioArticulos";
            this.cboCriterioArticulos.Size = new System.Drawing.Size(160, 24);
            this.cboCriterioArticulos.TabIndex = 8;
            // 
            // lblCriterioArticulos
            // 
            this.lblCriterioArticulos.AutoSize = true;
            this.lblCriterioArticulos.Location = new System.Drawing.Point(287, 607);
            this.lblCriterioArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterioArticulos.Name = "lblCriterioArticulos";
            this.lblCriterioArticulos.Size = new System.Drawing.Size(52, 16);
            this.lblCriterioArticulos.TabIndex = 9;
            this.lblCriterioArticulos.Text = "Criterio:";
            // 
            // lblFiltroAvanzadoArticulos
            // 
            this.lblFiltroAvanzadoArticulos.AutoSize = true;
            this.lblFiltroAvanzadoArticulos.Location = new System.Drawing.Point(547, 607);
            this.lblFiltroAvanzadoArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzadoArticulos.Name = "lblFiltroAvanzadoArticulos";
            this.lblFiltroAvanzadoArticulos.Size = new System.Drawing.Size(103, 16);
            this.lblFiltroAvanzadoArticulos.TabIndex = 10;
            this.lblFiltroAvanzadoArticulos.Text = "Filtro Avanzado:";
            // 
            // txtboxFiltroAvanzadoArticulos
            // 
            this.txtboxFiltroAvanzadoArticulos.Location = new System.Drawing.Point(679, 602);
            this.txtboxFiltroAvanzadoArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFiltroAvanzadoArticulos.Name = "txtboxFiltroAvanzadoArticulos";
            this.txtboxFiltroAvanzadoArticulos.Size = new System.Drawing.Size(132, 22);
            this.txtboxFiltroAvanzadoArticulos.TabIndex = 11;
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(828, 598);
            this.btnFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(100, 28);
            this.btnFiltroAvanzado.TabIndex = 12;
            this.btnFiltroAvanzado.Text = "Buscar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(246, 533);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 37);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar un Artículo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.agregarArticulosToolStripMenuItem_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(580, 533);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(161, 37);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.modificarArticulosToolStripMenuItem_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(747, 533);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 37);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.eliminarArticuloToolStripMenuItem_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(412, 533);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(161, 37);
            this.btnDetalle.TabIndex = 16;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.verDetalleArticuloToolStripMenuItem_Click);
            // 
            // btnNavegarAtras
            // 
            this.btnNavegarAtras.Location = new System.Drawing.Point(0, 4);
            this.btnNavegarAtras.Name = "btnNavegarAtras";
            this.btnNavegarAtras.Size = new System.Drawing.Size(88, 37);
            this.btnNavegarAtras.TabIndex = 17;
            this.btnNavegarAtras.Text = "<";
            this.btnNavegarAtras.UseVisualStyleBackColor = true;
            this.btnNavegarAtras.Click += new System.EventHandler(this.btnNavegarAtras_Click);
            // 
            // btnNavegarAdelante
            // 
            this.btnNavegarAdelante.Location = new System.Drawing.Point(179, 4);
            this.btnNavegarAdelante.Name = "btnNavegarAdelante";
            this.btnNavegarAdelante.Size = new System.Drawing.Size(88, 37);
            this.btnNavegarAdelante.TabIndex = 18;
            this.btnNavegarAdelante.Text = ">";
            this.btnNavegarAdelante.UseVisualStyleBackColor = true;
            this.btnNavegarAdelante.Click += new System.EventHandler(this.btnNavegarAdelante_Click);
            // 
            // gbxNavegadorImg
            // 
            this.gbxNavegadorImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxNavegadorImg.Controls.Add(this.btnNavegarAtras);
            this.gbxNavegadorImg.Controls.Add(this.btnNavegarAdelante);
            this.gbxNavegadorImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxNavegadorImg.Location = new System.Drawing.Point(931, 436);
            this.gbxNavegadorImg.Name = "gbxNavegadorImg";
            this.gbxNavegadorImg.Size = new System.Drawing.Size(267, 41);
            this.gbxNavegadorImg.TabIndex = 19;
            this.gbxNavegadorImg.TabStop = false;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(931, 484);
            this.btnAgregarImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(88, 44);
            this.btnAgregarImg.TabIndex = 20;
            this.btnAgregarImg.Text = "Agregar Imagen";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // btnModificarImg
            // 
            this.btnModificarImg.Location = new System.Drawing.Point(1020, 484);
            this.btnModificarImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarImg.Name = "btnModificarImg";
            this.btnModificarImg.Size = new System.Drawing.Size(88, 45);
            this.btnModificarImg.TabIndex = 21;
            this.btnModificarImg.Text = "Modificar Imagen";
            this.btnModificarImg.UseVisualStyleBackColor = true;
            this.btnModificarImg.Click += new System.EventHandler(this.btnModificarImg_Click);
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Location = new System.Drawing.Point(1110, 484);
            this.btnEliminarImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(88, 44);
            this.btnEliminarImg.TabIndex = 22;
            this.btnEliminarImg.Text = "Eliminar Imagen";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 640);
            this.Controls.Add(this.btnEliminarImg);
            this.Controls.Add(this.btnModificarImg);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.gbxNavegadorImg);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFiltroAvanzado);
            this.Controls.Add(this.txtboxFiltroAvanzadoArticulos);
            this.Controls.Add(this.lblFiltroAvanzadoArticulos);
            this.Controls.Add(this.lblCriterioArticulos);
            this.Controls.Add(this.cboCriterioArticulos);
            this.Controls.Add(this.cboCampoArticulo);
            this.Controls.Add(this.lblCampoArticulo);
            this.Controls.Add(this.txtboxFiltroArticulos);
            this.Controls.Add(this.lblFiltroArticulos);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal Catálogo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbxNavegadorImg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMarcaToolStripMenuItem;
        private System.Windows.Forms.Label lblFiltroArticulos;
        private System.Windows.Forms.TextBox txtboxFiltroArticulos;
        private System.Windows.Forms.Label lblCampoArticulo;
        private System.Windows.Forms.ComboBox cboCampoArticulo;
        private System.Windows.Forms.ComboBox cboCriterioArticulos;
        private System.Windows.Forms.Label lblCriterioArticulos;
        private System.Windows.Forms.Label lblFiltroAvanzadoArticulos;
        private System.Windows.Forms.TextBox txtboxFiltroAvanzadoArticulos;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnNavegarAtras;
        private System.Windows.Forms.Button btnNavegarAdelante;
        private System.Windows.Forms.GroupBox gbxNavegadorImg;
        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.Button btnModificarImg;
        private System.Windows.Forms.Button btnEliminarImg;
    }
}

