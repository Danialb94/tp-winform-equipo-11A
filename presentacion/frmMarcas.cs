using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarca;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            MarcaNegocio Negocio = new MarcaNegocio();
            listaMarca = Negocio.listar();
            dgvMarca.DataSource = listaMarca;
            dgvMarca.Columns["IdMarca"].Visible = false;
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca();
            alta.ShowDialog();
            cargarMarcas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            frmAltaMarca modificar = new frmAltaMarca(seleccionado);
            modificar.ShowDialog();
            cargarMarcas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                DialogResult Respuesta = MessageBox.Show("Está seguro de eliminar la marca: " + seleccionado.Descripcion, "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(Respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.IdMarca);
                    cargarMarcas();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
