using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
=======
using Negocio;
using Dominio;

>>>>>>> 6a26bd3 (Modificando)

namespace WebForms_TP3_Equipo27
{
    public partial class Default : System.Web.UI.Page
    {
<<<<<<< HEAD
        protected void Page_Load(object sender, EventArgs e)
        {
=======
        public List<Articulo> ListaArticulo { get; set; }//creo la propiedad tipo Lista
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulo = negocio.listar();

            if (!IsPostBack)
            {
                
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();
            }

            if (Session["listaArticulos"] == null)//antes de guardarla en SESSION, pregunto si no existe ya
            {
                //guardo la lista en SESSION, y ahi la puedo usar
                Session.Add("listaArticulos", negocio.listar());
            }
           
           




        }








        protected void btnArticulo_Click(object sender, EventArgs e)//esto lo cambie por el btnAgregar_Click
        {
            string valor = ((Button)sender).CommandArgument;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
>>>>>>> 6a26bd3 (Modificando)

        }
    }
}