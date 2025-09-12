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
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }
        
        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
            btnAgregar.Text = "Aceptar";
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
            
                if (string.IsNullOrWhiteSpace(txtDescripcionCategoria.Text))
                {
                    MessageBox.Show("¡¡ Debe ingresar una Descripcion !!");
                    return;
                }

                if (categoria == null)
                {
                    categoria = new Categoria();
                    categoria.Descripcion = txtDescripcionCategoria.Text;
                    negocio.agregar(categoria);
                    MessageBox.Show("Categoria agregada Correctamente");
                }
                else
                {
                    categoria.Descripcion = txtDescripcionCategoria.Text;
                    negocio.modificar(categoria);
                    MessageBox.Show("Categoria Modificada Correctamente");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
