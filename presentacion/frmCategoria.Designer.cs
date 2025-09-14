
namespace presentacion
{
    partial class frmCategoria
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.txtFiltroCategoria = new System.Windows.Forms.TextBox();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.Location = new System.Drawing.Point(18, 105);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.RowTemplate.Height = 24;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(307, 339);
            this.dgvCategoria.TabIndex = 0;
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(12, 20);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(325, 36);
            this.lblTituloCategoria.TabIndex = 1;
            this.lblTituloCategoria.Text = "Listado de Categorias";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(181, 452);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 55);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoEllipsis = true;
            this.btnModificar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(18, 452);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 55);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.Location = new System.Drawing.Point(15, 75);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(0, 17);
            this.lblAdvertencia.TabIndex = 2;
            // 
            // txtFiltroCategoria
            // 
            this.txtFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCategoria.Location = new System.Drawing.Point(154, 75);
            this.txtFiltroCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltroCategoria.Name = "txtFiltroCategoria";
            this.txtFiltroCategoria.Size = new System.Drawing.Size(171, 22);
            this.txtFiltroCategoria.TabIndex = 3;
            this.txtFiltroCategoria.TextChanged += new System.EventHandler(this.txtFiltroCategoria_TextChanged);
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(21, 75);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(106, 17);
            this.lblFiltroCategoria.TabIndex = 4;
            this.lblFiltroCategoria.Text = "Filtro Rapido:";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(359, 531);
            this.Controls.Add(this.lblFiltroCategoria);
            this.Controls.Add(this.txtFiltroCategoria);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.TextBox txtFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroCategoria;
    }
}