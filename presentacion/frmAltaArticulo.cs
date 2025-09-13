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
        private Articulo articulo = null;
        private List<Imagen> imagenes;
        public frmAltaArticulo()
        {
            InitializeComponent();
            
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            lblAltaArticulo.Text = "Modificar Articulo";
        }

        private void btnCancelarNuevoArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarNuevoArticulo_Click(object sender, EventArgs e)
        {   
            ArticuloNegocio negocio = new ArticuloNegocio();
            btnAceptarNuevoArticulo.Enabled = false;

            try
            {
                if (articulo == null)
                   articulo = new Articulo();
                
                articulo.Codigo =txtboxCodigoArticulo.Text;
                articulo.Nombre = txtboxNombreArticulo.Text;
                articulo.Descripcion = txtboxDescripcionArticulo.Text;
                articulo.Marca = (Marca)cmbMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtboxPrecioArticulo.Text);
                string urlImg = txtboxUrlImagenArticulo.Text;

                if (articulo.IdArticulo != 0)
                {
                    cmbMarcaArticulo.SelectedValue = articulo.Marca.IdMarca;
                    cmbCategoriaArticulo.SelectedValue = articulo.Categoria.IDCategoria;
                    negocio.modificarArticulo(articulo, urlImg);

                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    
                    negocio.agregar(articulo, urlImg);
                    MessageBox.Show("Articulo agregado exitosamente");
                }

            

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
                cmbMarcaArticulo.ValueMember = "IdMarca";
                cmbMarcaArticulo.DisplayMember = "Descripcion";
                cmbCategoriaArticulo.DataSource = categoriaNeg.Listar();
                cmbCategoriaArticulo.ValueMember = "IdCategoria";
                cmbCategoriaArticulo.DisplayMember= "Descripcion";

                if (articulo != null)
                {
                    btnAgregarImg.Visible = false;
                    txtboxCodigoArticulo.Text = articulo.Codigo;
                    txtboxNombreArticulo.Text = articulo.Nombre;
                    txtboxDescripcionArticulo.Text = articulo.Descripcion;
                    txtboxPrecioArticulo.Text = articulo.Precio.ToString();
                    if (articulo.Imagenes != null)
                        cargarImagen(articulo.Imagenes[0].urlImagen);
                    else cargarImagen(null);
                    cmbMarcaArticulo.SelectedValue = articulo.Marca.IdMarca;
                    cmbCategoriaArticulo.SelectedValue = articulo.Categoria.IDCategoria;

                }
                validarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void validarCampos()
        {
            bool codigoOk = !string.IsNullOrWhiteSpace(txtboxCodigoArticulo.Text);
            bool nombreOk = !string.IsNullOrWhiteSpace(txtboxNombreArticulo.Text);
            bool precioOk = false;

            try
            {
                decimal precio = Convert.ToDecimal(txtboxPrecioArticulo.Text);
                if (precio > 0)
                    precioOk = true;
            }
            catch
            {
                precioOk = false;
            }

            btnAceptarNuevoArticulo.Enabled = codigoOk && nombreOk && precioOk;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
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
