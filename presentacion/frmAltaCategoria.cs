using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionCategoria.Text))
            {
                MessageBox.Show("¡¡ Debe ingresar una Descripcion !!");
                return;
            }

            Categoria nueva = new Categoria();
            nueva.Descripcion = txtDescripcionCategoria.Text;

            CategoriaNegocio negocio = new CategoriaNegocio();
            
            try
            {
                negocio.agregar(nueva);
                MessageBox.Show("Categoria agregada Correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }

        }
    }
}
