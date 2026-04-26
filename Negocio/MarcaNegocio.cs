using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio.Datos;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
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
        public void agregar(Marca marca)
        {
            if (string.IsNullOrWhiteSpace(marca.Descripcion))
                throw new Exception("No escribiste ninguna marca.");
            AccesoDatos datos = new AccesoDatos();
            ValidadorBD validador = new ValidadorBD();
            try
            {
                if (validador.registroExiste("MARCAS", "Descripcion", marca.Descripcion))
                    throw new Exception("Ya existe.");

                datos.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES (@descripcion);");
                datos.setearParametro("@descripcion", marca.Descripcion);

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

        public void modificar(Marca marca)
        {
            if (string.IsNullOrWhiteSpace(marca.Descripcion))
                throw new Exception("No escribiste ninguna marca.");
            AccesoDatos datos = new AccesoDatos();
            ValidadorBD validador = new ValidadorBD(); 
            try
            {
                if (validador.registroExiste("MARCAS", "Descripcion", marca.Descripcion))
                    throw new Exception("Ya existe.");

                datos.setearConsulta("UPDATE MARCAS SET Descripcion = @descripcion WHERE Id = @id;");
                datos.setearParametro("@id", marca.Id);
                datos.setearParametro("@descripcion", marca.Descripcion);

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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM MARCAS WHERE Id = @id;");
                datos.setearParametro("@id", id);

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