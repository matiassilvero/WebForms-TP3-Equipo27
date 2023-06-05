using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlCommand Comando
        { get { return comando; } 
        }
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            //conexion = new SqlConnection("data source=.\\sqlexpress; initial catalog=CATALOGO_P3_DB; integrated security=sspi");
            //conexion = new SqlConnection("server = localhost; database=CATALOGO_P3_DB; integrated security=true"); //puse para q funcione
            conexion = new SqlConnection("data source=localhost; initial catalog= CATALOGO_P3_DB ; integrated security=sspi"); /*original de naza*/
            //conexion = new SqlConnection("data source= .\\sqlexpress;Initial Catalog=CATALOGO_P3_DB;Persist Security Info=True;User ID=usuario;Password=password\"");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Close();
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}

