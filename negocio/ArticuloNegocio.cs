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
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio from ARTICULOS A, CATEGORIAS C, MARCAS M Where A.IdMarca = M.Id and A.IdCategoria = C.Id");

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
