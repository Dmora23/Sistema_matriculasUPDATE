using SisMat_BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_ADO
{
    public class UsuarioADO
    {

        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            UsuarioBE objUsuarioBE = new UsuarioBE();

            sqlConnection.ConnectionString = ADOconnection.GetCnx();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_ConsultarUsuario";
            command.Parameters.Clear();
            try
            {
                
                command.Parameters.AddWithValue("@Username", strLogin);

                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    objUsuarioBE.Username = dr["Username"].ToString();
                    objUsuarioBE.password = dr["password"].ToString();
                    objUsuarioBE.Est_usuario = Convert.ToInt16(dr["Est_usuario"]);

                }
                dr.Close();
                return objUsuarioBE;
            } 
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            } 
        }
    }
}
