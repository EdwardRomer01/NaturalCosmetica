
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatosJabones
{
    public class Asistencia
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
    }

}
