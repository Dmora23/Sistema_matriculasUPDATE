using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_ADO
{
    public class UbigeoADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();


        public DataTable Ubigeo_Departamentos()
        {
            try
            {
                DataSet dts = new DataSet();
                try
                {
                    sqlConnection.ConnectionString = ADOconnection.GetCnx();
                    command.Connection = sqlConnection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "usp_Ubigeo_Departamentos";
                    command.Parameters.Clear();
                    SqlDataAdapter ada;
                    ada = new SqlDataAdapter(command);
                    ada.Fill(dts, "Departamentos");
                    return dts.Tables["Departamentos"];
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }

            } catch (SqlException e)
            {
                throw new Exception(e.Message);
            }

        }
        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            DataSet dts = new DataSet();
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_Ubigeo_ProvinciasDepartamento";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(command);
                miada.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_Ubigeo_ProvinciasDepartamento";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                SqlDataAdapter ada;
                ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
