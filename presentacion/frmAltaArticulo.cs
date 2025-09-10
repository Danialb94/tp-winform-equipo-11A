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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevoArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarNuevoArticulo_Click(object sender, EventArgs e)
        {   

            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
          
            try
            {
                articulo.Codigo =txtboxCodigoArticulo.Text;
                articulo.Nombre = txtboxNombreArticulo.Text;
                articulo.Descripcion = txtboxDescripcionArticulo.Text;
                articulo.Marca = (Marca)cmbMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtboxPrecioArticulo.Text);
                articulo.Imagen = txtboxUrlImagenArticulo.Text;
                negocio.agregar(articulo);
                MessageBox.Show("Articulo agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNeg = new CategoriaNegocio();


            try
            {
                cmbMarcaArticulo.DataSource = marcaNegocio.listar();
                cmbCategoriaArticulo.DataSource = categoriaNeg.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void txtboxUrlImagenArticulo_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtboxUrlImagenArticulo.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picbImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                picbImagenArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxdAOY_-vITFVI-ej84s2U_ErxhOly-z3y_Q&s");
            }
        }

        
    }
}
