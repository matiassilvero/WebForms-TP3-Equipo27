using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo       //las clases tienen que ser públicas para que los otros projectos pueden acceder mediante las referencias
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //public SqlMoney Precio { get; set; }  //me tira error al querer usar ese tipo de dato, tuve que pasarlo como decimal
        public decimal Precio { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        //public string ImgURL { get; set; }    //esta base no emplea la URL directa, aunque la anterior sí lo tenía directo como atributo.
        //En este caso, habrá que hacer una nueva consulta a la tabla IMAGENES
        public Imagen ImagenUrl { get; set; }

    }
}
