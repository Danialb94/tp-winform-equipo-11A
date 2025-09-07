using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public int IdMarca { get; } // Porque en DB el valor del IdMarca tiene la propiedad 'IDENTITY'

        public string Descripcion { get; set; }
        
    }
    
}
