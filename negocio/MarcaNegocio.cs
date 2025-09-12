using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()

        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT mar.Id, mar.Descripcion FROM MARCAS mar");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = (int)datos.Lector["Id"];
                    marca.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(marca);
                }


                return lista;
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
        
        public void agregar (Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES ('"+nuevo.Descripcion+"')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        public void modificar (Marca modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE MARCAS SET Descripcion = @descripcion WHERE Id = @id");
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@id", modificar.IdMarca);
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
        
        public void eliminar (int id)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE MARCAS WHERE Id = @id;");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();

            }
            catch(Exception ex)
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
