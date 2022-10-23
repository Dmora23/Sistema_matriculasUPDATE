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
    public class ProfesorADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public Boolean InsertarProfesor(ProfesorBE objProfesorBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertarProfesor";
                command.Parameters.Clear();

                // command.Parameters.AddWithValue("parametro", objProfesorBE_campoX) PARAMETROS DE ENTRADA

                sqlConnection.Open();
                command.ExecuteNonQuery();
                return true;
            } catch(SqlException e)
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

        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ActualizarProfesor";
                command.Parameters.Clear();
                // command.Parameters.AddWithValue("parametro", objProfesorBE_campoX) PARAMETROS DE ENTRADA
                sqlConnection.Open();
                command.ExecuteNonQuery();
                return true;
            } catch (SqlException e)
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
        public Boolean EliminarProfesor(Int16 strIdProfesor)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_EliminarProfesor";
                // command.Parameters.AddWithValue("@Id_profe", strIdProfesor) PARAMETROS DE ENTRADA
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
        public ProfesorBE ConsultarProfesor(Int16 strCod)
        {
            try
            {
                ProfesorBE objProfesorBE = new ProfesorBE();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ConsultarProfesor";
                // command.Parameters.AddWithValue("@Id_profe", strIdProfesor) PARAMETROS DE ENTRADA
                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    objProfesorBE.Id_profe = Convert.ToInt16(dr["Id_profe"]);
                    objProfesorBE.Id_Ubigeo = dr["Id_Ubigeo"].ToString();
                    objProfesorBE.Id_esp = Convert.ToInt16(dr["Id_esp"]);
                    objProfesorBE.Foto_profe = (Byte[])(dr["Foto_Profe"]);
                    objProfesorBE.Dni_profe = dr["Dni_profe"].ToString();
                    objProfesorBE.Nom_profe = dr["Nom_profe"].ToString();
                    objProfesorBE.Ape_profe = dr["Ape_profe"].ToString();
                    objProfesorBE.Email_profe = dr["Email_profe"].ToString();
                    objProfesorBE.Est_profe = Convert.ToInt16(dr["Est_profe"]);
                    objProfesorBE.Usu_Registro = dr["Usu_Registro"].ToString();
                    objProfesorBE.Fec_Registro = Convert.ToDateTime(dr["Fec_reg"]);
                    objProfesorBE.Usu_Ult_Mod = dr["Usu_Ult_Mod"].ToString();
                    objProfesorBE.Fec_Ult_Mod = Convert.ToDateTime(dr["Fec_Ult_Mod"]);

                }
                dr.Close();
                return objProfesorBE;
            } catch (SqlException e)
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
        public DataTable ListarProfesor()
        {
            try
            {
                DataSet dts = new DataSet();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ñ";
                command.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(command);
                ada.Fill(dts, "Profesores");
                return dts.Tables["Profesores"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
