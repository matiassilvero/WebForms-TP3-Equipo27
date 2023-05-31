using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int ID { get; set; }
        //public Articulo Articulo { get; set; }

        public int idArticulo{ get; set; }

        public string ImagenUrl { get; set; }

        public override string ToString()
        {
            return ImagenUrl;
        }
    }
}
