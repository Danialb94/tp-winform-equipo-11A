using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    internal class ImagenNegocio
    {
        public void agregar (Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (ImagenUrl, IdArticulo) VALUES (@imagen, @IdArticulo)");
                datos.setearParametro("@imagen", nuevo.urlImagen);
                datos.setearParametro("@IdArticulo", nuevo.idArticulo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
