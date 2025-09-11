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

        public frmCategoria()
        {
            InitializeComponent();
        }


        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargarCategoria();
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

        
    }
}
