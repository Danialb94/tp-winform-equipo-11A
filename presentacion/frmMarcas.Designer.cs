namespace presentacion
{
    partial class frmMarcas
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
            this.lblTituloMarcas = new System.Windows.Forms.Label();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.txtFiltroMarca = new System.Windows.Forms.TextBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloMarcas
            // 
            this.lblTituloMarcas.AutoSize = true;
            this.lblTituloMarcas.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarcas.Location = new System.Drawing.Point(18, 24);
            this.lblTituloMarcas.Name = "lblTituloMarcas";
            this.lblTituloMarcas.Size = new System.Drawing.Size(279, 32);
            this.lblTituloMarcas.TabIndex = 3;
            this.lblTituloMarcas.Text = "Listado de Marcas";
            // 
            // dgvMarca
            // 
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarca.Location = new System.Drawing.Point(160, 148);
            this.dgvMarca.MultiSelect = false;
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.RowHeadersWidth = 51;
            this.dgvMarca.RowTemplate.Height = 24;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(273, 299);
            this.dgvMarca.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 257);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroMarca.Location = new System.Drawing.Point(21, 101);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(106, 17);
            this.lblFiltroMarca.TabIndex = 5;
            this.lblFiltroMarca.Text = "Filtro Rapido:";
            // 
            // txtFiltroMarca
            // 
            this.txtFiltroMarca.Location = new System.Drawing.Point(160, 101);
            this.txtFiltroMarca.Name = "txtFiltroMarca";
            this.txtFiltroMarca.Size = new System.Drawing.Size(273, 22);
            this.txtFiltroMarca.TabIndex = 6;
            this.txtFiltroMarca.TextChanged += new System.EventHandler(this.txtFiltroMarca_TextChanged);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.ForeColor = System.Drawing.Color.DimGray;
            this.lblAdvertencia.Location = new System.Drawing.Point(21, 69);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(424, 17);
            this.lblAdvertencia.TabIndex = 7;
            this.lblAdvertencia.Text = "Recuerde: seleccione la categoría que desea modificar o eliminar.";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 467);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.txtFiltroMarca);
            this.Controls.Add(this.lblFiltroMarca);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.lblTituloMarcas);
            this.MaximizeBox = false;
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMarcas;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.TextBox txtFiltroMarca;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}