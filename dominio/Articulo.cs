using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria DescripcionCat { get; set; }
        public decimal Precio { get; set; }

        public string Imagen;
        //public List<string> Imagenes;

        //Habría que encontrar la forma para que las imágenes funcionen como una lista
        // y arreglar el tamaño de las imagenes que quedan giganti-enormess
       



    }
}
