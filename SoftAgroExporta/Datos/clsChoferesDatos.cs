using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SoftAgroExporta
{
    public class clsChoferesDatos
    {
        //<!-- REALIZA LA CONSULTA PARA LLENAR UN COMBOBOX DE CHOFERES -->
        public DataTable LlenarComboBoxChoferes()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select idChofer, NomChofer from Choferes order by NomChofer", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            return dt;
        }
        //<!----------- -------- ------FIN -- ----- -- ------ ----------->
    }
}
