using dominio;
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
    public partial class frmDetalleArticulo : Form
    {
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();

          txtboxDetalleCodigo.Text = articulo.Codigo;
          txtboxDetalleNombre.Text = articulo.Nombre;
          txtboxDetalleDescripcion.Text = articulo.Descripcion;
          txtboxDetalleMarca.Text = articulo.Marca.Descripcion;
          txtboxDetalleCategoria.Text = articulo.Categoria.Descripcion;
          txtboxDetallePrecio.Text = articulo.Precio.ToString();

           
        }

        
    }

}
