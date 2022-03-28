using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SoftAgroExporta
{
    public class clsTipoJabaDatos
    {
        public DataTable LlenarComboBoxTipoJaba()
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select idTipoJaba,NomTipoJaba,PesoJaba from TipoJaba", Conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            Conexion.Open();
            adaptador.Fill(dt);
            dr = cmd.ExecuteReader();
            return dt;
        }

        public bool LlenarCamposTipoJaba(clsTipoJaba objTipoJaba)
        {
            SqlConnection Conexion = new SqlConnection();
            Conexion.ConnectionString = clsConexionBd.CadenaConexion;
            SqlDataReader dr;
            Conexion.Open();
            SqlCommand cmd = new SqlCommand("select IdTipoJaba, "
                + " NomTipoJaba, "
                + " PesoJaba "
                + " from TipoJaba "
                + " where IdTipoJaba = " + objTipoJaba.IdTipoJaba, Conexion);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    objTipoJaba.IdTipoJaba = dr.GetInt32(0);
                    objTipoJaba.NomTipoJaba = dr.GetString(1);
                    objTipoJaba.PesoJaba = (float)dr.GetDouble(2);
                }
                return true;
            }
            else return false;
            //Conexion.Close();
        }
    }
}
