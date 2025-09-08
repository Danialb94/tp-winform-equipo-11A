using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()

        {
            List<Articulo>lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT art.Id, art.Codigo, art.Nombre, art.Descripcion, ISNULL(mar.Descripcion, 'Desconocida') as Marca, ISNULL(cat.Descripcion, 'Desconocida') as Categoria, Precio, img.ImagenUrl FROM ARTICULOS art LEFT JOIN CATEGORIAS cat ON art.IdCategoria = cat.Id LEFT JOIN MARCAS mar ON art.IdMarca = mar.Id LEFT JOIN IMAGENES img ON art.Id = img.IdArticulo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.IdArticulo = (int)datos.Lector["Id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.DescripcionCat = new Categoria();
                    articulo.DescripcionCat.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                    articulo.Imagen = (string)datos.Lector["ImagenUrl"];
                    

                    lista.Add(articulo);
                }


                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                datos.cerrarConexion();

            }

        }
    }
}
