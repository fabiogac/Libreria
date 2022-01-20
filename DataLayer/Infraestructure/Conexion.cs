using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataLayer.Infraestructure
{
    public class Conexion
    {
        public SqlConnection conexion;
        public SqlCommand comando;
        public SqlDataAdapter adap;
        public DataSet ds;

        public Conexion()
        {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Biblioteca").(ConnectionString);
        }



     
    }
}
