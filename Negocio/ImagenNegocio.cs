using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listarImagenes()
        {

            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("Select I.Id, i.IdArticulo, i.ImagenUrl From IMAGENES I");
                acceso.ejecutarLectura();

                List<Imagen> lista = new List<Imagen>();
                while (acceso.Lector.Read())
                {
                    Imagen aux = new Imagen();

                    aux.ID = (int)acceso.Lector["Id"];
                    aux.idArticulo = (int)acceso.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)acceso.Lector["ImagenUrl"];
                    
                    lista.Add(aux);
                }

                acceso.cerrarConexion();
                return lista;
            }

            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                acceso.cerrarConexion();
            }
        }




    }
}
