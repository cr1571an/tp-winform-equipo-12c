using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Datos
{
    public class ValidadorBD
    {
        public bool registroExiste(string tabla, string campo, string valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM " + tabla + " WHERE UPPER(" + campo + ") = UPPER(@valor)");
                datos.setearParametro("@valor", valor);
                datos.ejecutarLectura();

                int cantidad = 0;
                if (datos.Lector.Read())
                {
                    cantidad = (int)datos.Lector[0];
                }
                return cantidad > 0;
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
