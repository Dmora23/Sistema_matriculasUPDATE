using SisMat_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisMat_ADO
{
    public class CuotaADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;


        public Boolean InsertarCuota(CuotaBE objCuotaBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertarCuota";
                command.Parameters.Clear();
                // command.Parameters.AddWithValue("parametro", objCuotaBE_campoX) PARAMETROS DE
                //   // command.Parameters.AddWithValue("parametro", objCuotaBE_campoX) PARAMETROS DE ENTRADA
                sqlConnection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean ActualizarCuota(CuotaBE objCuotaBE)
        {
            sqlConnection.ConnectionString = ADOconnection.GetCnx();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_ActualizarCuota";
            command.Parameters.Clear();
            // command.Parameters.AddWithValue("parametro", objProfesorBE_campoX) PARAMETROS DE ENTRADA
            sqlConnection.Open();
            command.ExecuteNonQuery();
            return true;
        }
        public CuotaBE ConsultarCuota(Int16 idCuota)
        {
            try
            {
                CuotaBE objCuotaBE = new CuotaBE();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ConsultarCuota";
                // command.Parameters.AddWithValue("parametroName", idCuota) PARAMETROS DE ENTRADA
                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    objCuotaBE.Id_cuota = Convert.ToInt16(dr["Id_cuota"]);
                    objCuotaBE.Id_alum = Convert.ToInt16(dr["Id_alum"]);
                    objCuotaBE.Ndoc_cuota = dr["Ndoc_cuota"].ToString();
                    objCuotaBE.Fec_pago = Convert.ToDateTime(dr["Fecha_pago"]);
                    objCuotaBE.Est_cuota = Convert.ToInt16(dr["Est_cuota"]);
                    objCuotaBE.Tip_cuota = Convert.ToInt16(dr["Tip_cuota"]);
                    objCuotaBE.Vencimiento = Convert.ToDateTime(dr["Vencimiento"]);
                    objCuotaBE.Precio_cuota = Convert.ToSingle(dr["Precio_cuota"]);
                }
                dr.Close();
                return objCuotaBE;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        public DataTable ListarCuota()
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListarCuota";
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Cuotas");
                return dts.Tables["Cuotas"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean EliminarCuota(Int16 idCuota)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_EliminarCuota";

                // command.Parameters.AddWithValue("parametro", idCuota) ELIMINAR = CAMBIAR ESTADO A PAGADO
                sqlConnection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

    }
}
