using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace WebForms_TP3_Equipo27
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Obtener el ID del objeto Articulo de la URL
                int articuloId = 0;
                if (Request.QueryString["id"] != null)
                {
                    articuloId = int.Parse(Request.QueryString["id"].ToString());
                    List<Articulo> temporal = (List<Articulo>)Session["listaArticulos"];//traigo esta lista para obtener el articulo q yo quiero
                    Articulo seleccionado = temporal.Find(x => x.ID == articuloId);//busco con LAMDA expresion el articuloq quiero dandole el Id, eso me devuelve el objeto en 

                    txtId.Text = seleccionado.ID.ToString();
                    txtId.ReadOnly = true;// para q no se pueda modificar el id

                    txtNombre.Text = seleccionado.Nombre;
                    txtNombre.ReadOnly = true;

                    txtDescripcion.Text = seleccionado.Descripcion;
                    txtDescripcion.ReadOnly = true;

                    txtCodigo.Text = seleccionado.Codigo.ToString();
                    txtCodigo.ReadOnly = true;

                    txtMarca.Text = seleccionado.Marca.Descripcion;
                    txtMarca.ReadOnly = true;

                    txtCategoria.Text = seleccionado.Categoria.Descripcion;
                    txtCategoria.ReadOnly = true;

                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtPrecio.ReadOnly = true;

                    if (seleccionado.ImagenUrl != null)
                    {
                        imgArticulo.ImageUrl = seleccionado.ImagenUrl;
                    }
                    else
                    {
                        //imagen por defecto
                        imgArticulo.ImageUrl = "https://static.vecteezy.com/system/resources/previews/009/007/134/non_2x/failed-to-load-page-concept-illustration-flat-design-eps10-modern-graphic-element-for-landing-page-empty-state-ui-infographic-icon-vector.jpg";
                    }

                }

                // Asignar el ID al DropDownList
                //ddlArticulo.SelectedValue = articuloId.ToString();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}