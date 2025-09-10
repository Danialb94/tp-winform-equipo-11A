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
                //articulo.DescripcionCat = (Categoria)cmbCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtboxPrecioArticulo.Text);
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
            //CategoriaNegocio categoriaNeg = new CategoriaNegocio();

            try
            {
                cmbMarcaArticulo.DataSource = marcaNegocio.listar();
                //cmbCategoriaArticulo.DataSource = categoriaNeg.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
