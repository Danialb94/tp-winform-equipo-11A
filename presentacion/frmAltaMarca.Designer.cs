namespace presentacion
{
    partial class frmAltaMarca
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
            this.lblTituloAgregarMarca = new System.Windows.Forms.Label();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloAgregarMarca
            // 
            this.lblTituloAgregarMarca.AutoSize = true;
            this.lblTituloAgregarMarca.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregarMarca.Location = new System.Drawing.Point(25, 32);
            this.lblTituloAgregarMarca.Name = "lblTituloAgregarMarca";
            this.lblTituloAgregarMarca.Size = new System.Drawing.Size(275, 32);
            this.lblTituloAgregarMarca.TabIndex = 3;
            this.lblTituloAgregarMarca.Text = "Datos de la Marca";
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(32, 96);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionMarca.TabIndex = 4;
            this.lblDescripcionMarca.Text = "Descripcion:";
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(120, 93);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(180, 22);
            this.txtDescripcionMarca.TabIndex = 0;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(31, 146);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(119, 29);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(181, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 226);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Controls.Add(this.lblTituloAgregarMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 273);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 273);
            this.Name = "frmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Marca";
            this.Load += new System.EventHandler(this.frmAltaMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgregarMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnCancelar;
    }
}