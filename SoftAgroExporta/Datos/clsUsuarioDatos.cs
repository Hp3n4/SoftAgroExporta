using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SoftAgroExporta
{
    public class clsUsuarioDatos
    {
        public bool Login(clsLogin objLogin)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlDataReader dr;
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("select IdUsuario, Nombre, Clave from Usuarios "
                + " where Nombre = '" + objLogin.Nombre + "' and "
                + " clave = '" + objLogin.Clave + "'", Conexion);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    objLogin.IdUsuario = dr.GetInt32(0);
                }
                return true;
            }
            else return false;

        }
    }
}
