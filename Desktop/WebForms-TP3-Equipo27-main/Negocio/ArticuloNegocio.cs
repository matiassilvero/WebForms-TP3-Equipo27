using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {

            AccesoDatos acceso = new AccesoDatos();
            try
            {
                //acceso.setearConsulta("Select A.ID, A.Codigo Codigo, A.Nombre, A.Descripcion, A.Precio, C.Descripcion Categoria, C.Id IdCategoria, M.Id IdMarca, M.Descripcion Marca, I.Id IdImagen, I.ImagenUrl ImagenUrl From ARTICULOS A join CATEGORIAS C on A.IdCategoria = C.Id join MARCAS M on A.IdMarca = M.Id join IMAGENES I on A.Id = I.IdArticulo");
                //acceso.setearConsulta("Select A.ID, A.Codigo Codigo, A.Nombre, A.Descripcion, A.Precio, C.Descripcion Categoria, C.Id IdCategoria, M.Id IdMarca, M.Descripcion Marca From ARTICULOS A join CATEGORIAS C on A.IdCategoria = C.Id join MARCAS M on A.IdMarca = M.Id");
                acceso.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdMarca, A.IdCategoria, " +
                    "I.Id, I.IdArticulo, I.ImagenUrl, M.Id, M.Descripcion, C.Id, C.Descripcion " +
                    "From ARTICULOS A inner join IMAGENES I on A.Id = I.IdArticulo " +
                    "inner join MARCAS M on A.IdMarca = M.Id " +
                    "left join CATEGORIAS C on A.IdCategoria = C.Id");//puse esta consulta para q muestre TODOS los articulos, probar
                acceso.ejecutarLectura();
                List<Articulo> lista = new List<Articulo>();
                while (acceso.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.ID = (int)acceso.Lector["Id"];
                    aux.Codigo = (string)acceso.Lector["Codigo"];
                    aux.Nombre = (string)acceso.Lector["Nombre"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    aux.Precio = (decimal)acceso.Lector["Precio"];
                    //aux.Precio = acceso.Lector.GetSqlMoney(5);

                    aux.Categoria = new Categoria();
                    aux.Categoria.ID = (int)acceso.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)acceso.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.ID = (int)acceso.Lector["IdMarca"]; 
                    aux.Marca.Descripcion = (string)acceso.Lector["Descripcion"];

                    //aux.ImagenUrl = new Imagen();
                    //aux.ImagenUrl.ImagenUrl = (string)acceso.Lector["ImagenUrl"];

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
        //fin del método listar(), el cual hace la consulta y devuelve la lista;


        //Métodos empleados por el Forma Agregar para los cboBox:
        public List<Categoria> listarCategorias()
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("SELECT * FROM CATEGORIAS");
                acceso.ejecutarLectura();
                List<Categoria> categoria = new List<Categoria>();

                while (acceso.Lector.Read())
                {
                    Categoria cat = new Categoria();
                    //aux.ID = (int)lector["Id"];
                    cat.Descripcion = (string)acceso.Lector["Descripcion"];
                    cat.ID = (int)acceso.Lector["Id"];

                    categoria.Add(cat);
                }
                acceso.cerrarConexion();
                return categoria;
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

        public List<Marca> listarMarca()
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("SELECT * FROM MARCAS");
                acceso.ejecutarLectura();
                List<Marca> marca = new List<Marca>();
                while (acceso.Lector.Read())
                {

                    Marca mar = new Marca();
                    mar.ID = (int)acceso.Lector["Id"];
                    mar.Descripcion = (string)acceso.Lector["Descripcion"];

                    marca.Add(mar);
                }
                acceso.cerrarConexion();
                return marca;
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

        //Métodos agregar y modificar, empleados en primera instancia por el Form Agregar
        public void agregar(Articulo nuevo)
        {
            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, Precio) Values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @IdMarca, @Precio)");
                acceso.Comando.Parameters.AddWithValue("@Codigo", nuevo.Codigo);
                acceso.Comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                acceso.Comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
                //comando.Parameters.AddWithValue("@ImagenUrl", nuevo.ImagenUrl.ImagenUrl);
                acceso.Comando.Parameters.AddWithValue("@IdCategoria", nuevo.Categoria.ID);
                acceso.Comando.Parameters.AddWithValue("@IdMarca", nuevo.Marca.ID);
                acceso.Comando.Parameters.AddWithValue("@Precio", nuevo.Precio);

                acceso.ejecutarLectura();

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

        public void modificar(Articulo existente)
        {
            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdCategoria = @IdCategoria, IdMarca = @IdMarca, Precio = @Precio where Id = @Id");
                acceso.Comando.Parameters.AddWithValue("@Id", existente.ID);
                acceso.Comando.Parameters.AddWithValue("@Codigo", existente.Codigo);
                acceso.Comando.Parameters.AddWithValue("@Nombre", existente.Nombre);
                acceso.Comando.Parameters.AddWithValue("@Descripcion", existente.Descripcion);
                //comando.Parameters.AddWithValue("@ImagenUrl", nuevo.ImagenUrl.ImagenUrl);
                acceso.Comando.Parameters.AddWithValue("@IdCategoria", existente.Categoria.ID);
                acceso.Comando.Parameters.AddWithValue("@IdMarca", existente.Marca.ID);
                acceso.Comando.Parameters.AddWithValue("@Precio", existente.Precio);

                acceso.ejecutarLectura();
                //acceso.Comando.ExecuteNonQuery();
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

        public void eliminar(int id)
        {
            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("Delete From ARTICULOS Where Id=@Id");
                acceso.Comando.Parameters.AddWithValue("@Id", id);
                acceso.ejecutarLectura();
            }
            catch (Exception ex)
            {

                throw;
            }

        }


    }
}
