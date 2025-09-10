using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Net;

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
                    if (!(datos.Lector["Codigo"] is DBNull))
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["Precio"] is DBNull))
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
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

        public void agregar(Articulo nuevo)
        {   
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio,IdMarca, IdCategoria, UrlImagen)values('"+nuevo.Codigo+"','"+nuevo.Nombre+"','"+nuevo.Descripcion+"',"+nuevo.Precio+",@IdMarca, @IdCategoria,@urlImagen)");
                datos.setearParametro("@IdMarca", nuevo.Marca.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.IDCategoria);
                datos.setearParametro("@urlImagen", nuevo.Imagen);
                datos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }

}
