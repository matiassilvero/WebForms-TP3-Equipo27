using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_1
{
    public partial class Agregar : Form
    {
        private Articulo articulo = null;
        private List<Articulo> listaOriginal;

        public Agregar()
        {
            InitializeComponent();
        }

        public Agregar(Articulo artic)
        {
            InitializeComponent();
            articulo = artic;
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            cboMarca.DataSource = articuloNegocio.listarMarca();
            cboMarca.ValueMember = "ID";
            cboMarca.DisplayMember = "Descripcion";


            //CategoriaNegocio negocio = new CategoriaNegocio();
            cboCategoria.DataSource = articuloNegocio.listarCategorias();
            cboCategoria.ValueMember = "ID";
            cboCategoria.DisplayMember = "Descripcion";



            if (articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cboMarca.SelectedValue = articulo.Marca.ID;
                cboCategoria.SelectedValue = articulo.Categoria.ID;
                Text = "Modificar artículo";
                txtPrecio.Text = Convert.ToString(articulo.Precio);
                //txtImagenUrl.Text = articulo.ImagenUrl.ImagenUrl;
            }
        }

        private void btnCancelarAgregar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Articulo nuevo = new Articulo();
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articulo = new Articulo();
                //if (articulo == null)

                //    articulo = new Articulo();  //  si está vacio (porque no existe) lo crea. Sino, lo "recarga"

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                //articulo.ImagenUrl = (Imagen)txtImagenUrl.Text;

                              
                listaOriginal = negocio.listar();
                foreach (Articulo var in listaOriginal)
                {
                    if (articulo.Codigo == var.Codigo)
                    {
                        MessageBox.Show("Código de artículo repetido. Revise el código o utilice la función 'Modificar'", "Artículo repetido");
                        Close();
                        return;                       
                    }
                }
                negocio.agregar(articulo);
                MessageBox.Show("Operación realizada exitosamente", "Éxito");
                Close();
            }
        

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
