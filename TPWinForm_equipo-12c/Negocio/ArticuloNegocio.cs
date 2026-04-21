using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public ArticuloNegocio() { 
        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {                
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
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

        public Articulo verDetalleArticulo(string id)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT a.Codigo,a.Nombre,a.Precio, a.Descripcion, c.Descripcion as Categoria,m.Descripcion as Marca FROM [CATALOGO_P3_DB].[dbo].[ARTICULOS] a join CATEGORIAS c on c.Id = a.IdCategoria  join MARCAS m on m.Id = a.IdMarca  where a.id = @id;");
                datos.setearParametro("@id", id);
                datos.ejecutarLectura();
                SqlDataReader reader = datos.Lector;

                Articulo articulo = new Articulo();
               
                if (reader.Read())
                {

                }
                

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
