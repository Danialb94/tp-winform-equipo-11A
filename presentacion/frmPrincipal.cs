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
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        private int imagenAux;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarArticulos();

            cboCampoArticulo.Items.Add("Código");
            cboCampoArticulo.Items.Add("Nombre");
            cboCampoArticulo.Items.Add("Descripción");
            cboCampoArticulo.Items.Add("Marca");
            cboCampoArticulo.Items.Add("Categoria");
            cboCampoArticulo.Items.Add("Precio");
            cboCampoArticulo.SelectedIndex = 0;


            cboCriterioArticulos.SelectedIndex = 0;
            btnNavegarAtras.Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo artSeleccionado = null;
            imagenAux = 0;

            if (dgvArticulos.CurrentRow != null && dgvArticulos.CurrentRow.DataBoundItem != null)
            {
                artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            }

            if (artSeleccionado != null && artSeleccionado.Imagenes != null && artSeleccionado.Imagenes.Count > 0)
            {
                cargarImagen(artSeleccionado.Imagenes[0].urlImagen);
                if (artSeleccionado.Imagenes.Count > 1)
                {
                    gbxNavegadorImg.Visible = true;
                    btnNavegarAtras.Visible = false;
                    btnNavegarAdelante.Visible = true;
                }
                else
                {
                    gbxNavegadorImg.Visible = false;
                }
            }
            else
            {
                cargarImagen(null);
            }


        }
        private void cargarArticulos()
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
            listaArticulo = Negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            ocultarColumnasArticulos();
            cargarImagen(listaArticulo[0].Imagenes[0].urlImagen);
        }
        private void ocultarColumnasArticulos()
        {
            dgvArticulos.Columns["IdArticulo"].Visible = false;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxdAOY_-vITFVI-ej84s2U_ErxhOly-z3y_Q&s");
            }
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarArticulos();
        }

        private void modificarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado;
            if (dgvArticulos.CurrentRow != null)
            {
                articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(articuloSeleccionado);
                modificar.ShowDialog();
                cargarArticulos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo primero.");
            }

        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de que quiere eliminar?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminarArticulo(seleccionado.IdArticulo);
                        cargarArticulos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un artículo primero.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void listadoDeMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }

        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca();
            alta.ShowDialog();
        }

        private void listadoDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();

        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();

        }

        private void txtboxFiltroArticulos_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada, listaFinal;
            string filtro = txtboxFiltroArticulos.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
            
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnasArticulos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCampoArticulo.SelectedItem != null)
            {
                string opcion = cboCampoArticulo.SelectedItem.ToString();

                if (opcion == "Código" || opcion == "Nombre" || opcion == "Descripción" || opcion == "Marca" || opcion == "Categoria")
                {
                    cboCriterioArticulos.Items.Clear();
                    cboCriterioArticulos.Items.Add("Comienza con");
                    cboCriterioArticulos.Items.Add("Termina con");
                    cboCriterioArticulos.Items.Add("Contiene");
                }
                else if (opcion == "Precio")
                {
                    cboCriterioArticulos.Items.Clear();
                    cboCriterioArticulos.Items.Add("Mayor a");
                    cboCriterioArticulos.Items.Add("Menor a");
                    cboCriterioArticulos.Items.Add("Igual a");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                {
                    return;
                }


                string campo = cboCampoArticulo.SelectedItem.ToString();
                string criterio = cboCriterioArticulos.SelectedItem.ToString();
                string filtro = txtboxFiltroAvanzadoArticulos.Text;

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void verDetalleArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmDetalleArticulo detalle = new frmDetalleArticulo(seleccionado);
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo primero.");
            }
        }

        private bool validarFiltro()
        {
            if (cboCampoArticulo.SelectedItem.ToString() == "Precio")
                if (string.IsNullOrEmpty(txtboxFiltroAvanzadoArticulos.Text))
                {
                    return true;
                }
            if (!(soloNumeros(txtboxFiltroAvanzadoArticulos.Text)))
            {
                MessageBox.Show("Solo se aceptan números");
                return true;
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void modificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria modificar = new frmCategoria(true, false);
            modificar.ShowDialog();
        }

        private void eliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria eliminar = new frmCategoria(false, true);
            eliminar.ShowDialog();
        }



        //IMAGENES
        private void btnNavegarAdelante_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un artículo para continuar");
                    return;
                }
                Articulo artActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                imagenAux++;
                cargarImagen(artActual.Imagenes[imagenAux].urlImagen);
                btnNavegarAtras.Visible = true;
                if (artActual.Imagenes.Count - 1 == imagenAux) btnNavegarAdelante.Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNavegarAtras_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un artículo para continuar");
                    return;
                }
                Articulo artActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                imagenAux--;
                cargarImagen(artActual.Imagenes[imagenAux].urlImagen);
                btnNavegarAdelante.Visible = true;
                if (0 == imagenAux) btnNavegarAtras.Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un artículo para continuar");
                    return;
                }
                Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAltaImagenes agregar = new frmAltaImagenes(artSeleccionado, -1);
                agregar.ShowDialog();
                cargarArticulos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnModificarImg_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un artículo para continuar");
                    return;
                }
                Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAltaImagenes agregar = new frmAltaImagenes(artSeleccionado, imagenAux);
                agregar.ShowDialog();
                cargarArticulos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un artículo para continuar");
                    return;
                }
                Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show(
                        "¿ Está seguro de eliminar la imagen esta imagen del artículo: " + artSeleccionado.Codigo + "/" + artSeleccionado.Nombre + " ? ",
                        "Eliminar Imagen",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        ImagenNegocio negocio = new ImagenNegocio();
                        negocio.eliminar(artSeleccionado.Imagenes[imagenAux].idImagen);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al Eliminar: " + ex.Message);
                    }
                }
                cargarArticulos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

