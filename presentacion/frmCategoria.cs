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
    public partial class frmCategoria : Form
    {
        private List<Categoria> listaCategoria;
        private bool mostrarModificar;
        private bool mostrarEliminar;
        


        public frmCategoria()
        {
            InitializeComponent();
            mostrarModificar = false;
            mostrarEliminar = false;
            lblTituloCategoria.Text = "Listado de Categoría";

            

        }
        public frmCategoria(bool mostrarModificar, bool mostrarEliminar)
        {
            InitializeComponent();
            this.mostrarModificar = mostrarModificar;
            this.mostrarEliminar = mostrarEliminar;

            if (mostrarModificar && !mostrarEliminar)
            {
                lblTituloCategoria.Text = "Modificar Categoria";
            }
            else if (!mostrarModificar && mostrarEliminar)
            {
                lblTituloCategoria.Text = "Eliminar Categoria";
            }
            else
            {
                lblTituloCategoria.Text = "Listado de Categorías";

            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargarCategoria();
            btnModificar.Visible = mostrarModificar;
            btnEliminar.Visible = mostrarEliminar;
        }

        private void cargarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                listaCategoria = negocio.Listar();
                dgvCategoria.DataSource = null;
                dgvCategoria.DataSource = listaCategoria;
                dgvCategoria.Columns["IDCategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Categoria: " + ex.Message);
            }
        
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                frmAltaCategoria modificar = new frmAltaCategoria(seleccionado);
                modificar.ShowDialog();
                cargarCategoria();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                CategoriaNegocio negocio = new CategoriaNegocio();

                if (negocio.tieneArticulosAsociados(seleccionado.IDCategoria))
                {
                    MessageBox.Show("No se puede eliminar la categoría porque tiene artículos asociados.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar la categoría: " + seleccionado.Descripcion + "?",
                    "Eliminar Categoría",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        negocio.eliminar(seleccionado.IDCategoria);
                        cargarCategoria();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una categoría primero.");
            }
        }

    }
}

