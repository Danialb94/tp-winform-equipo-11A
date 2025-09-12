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
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
            btnAgregarMarca.Text = "Aceptar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null)
                marca = new Marca();
                marca.Descripcion = txtDescripcionMarca.Text;

                if(marca.IdMarca != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado Exitosamente");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Close();
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtDescripcionMarca.Text = marca.Descripcion;
            }
        }
    }
}
