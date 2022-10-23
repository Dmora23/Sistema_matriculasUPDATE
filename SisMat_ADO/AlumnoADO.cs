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
    public class AlumnoADO
    {
        ConexionADO ADOconnection = new ConexionADO();
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dr;

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_InsertarAlumno";
                command.Parameters.Clear();
                // command.Parameters.AddWithValue("parametro", objAlumnoBE_campoX) PARAMETROS DE ENTRADA
                // command.Parameters.AddWithValue("parametro2", objAlumnoBE_campoX) PARAMETROS DE ENTRADA
                sqlConnection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            } finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ActualizarAlumno";
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
                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
       
        }
        public Boolean EliminarAlumno(Int16 strIdAlumno)
        {
            try
            {
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_EliminarAlumno";

                // command.Parameters.AddWithValue("@Id_Alumno", strIdAlumno) PARAMETROS DE ENTRADA
                sqlConnection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            } finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
        public AlumnoBE ConsultarAlumno(Int16 strCod)
        {
            try
            {
                AlumnoBE objAlumnoBE = new AlumnoBE();
                sqlConnection.ConnectionString = ADOconnection.GetCnx();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ñ";
                // command.Parameters.AddWithValue("@Id_profe", strIdProfesor) PARAMETROS DE ENTRADA
                sqlConnection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    objAlumnoBE.Id_alum = Convert.ToInt16(dr["Id_alum"]);
                    objAlumnoBE.Id_Ubigeo = dr["Id_Ubigeo"].ToString();
                    objAlumnoBE.Dni_alum = dr["Dni_alum"].ToString();
                    objAlumnoBE.Foto_alum = (Byte[])(dr["Foto_alum"]);
                    objAlumnoBE.Fec_nac = Convert.ToDateTime(dr["Fec_nac"]);
                    objAlumnoBE.Sexo = dr["Sexo"].ToString();
                    objAlumnoBE.Nom_alum = dr["Nombre_alum"].ToString();
                    objAlumnoBE.Ape_alum = dr["Ape_alum"].ToString();
                    objAlumnoBE.Dir_alum = dr["Dir_alum"].ToString();
                    objAlumnoBE.Tel_alum = dr["Tel_alum"].ToString();
                    objAlumnoBE.Email_alum = dr["Email_alum"].ToString();
                    objAlumnoBE.Usu_Registro = dr["Usu_registro"].ToString();
                    objAlumnoBE.Fec_Registro = Convert.ToDateTime(dr["Fec_reg"].ToString());
                    objAlumnoBE.Usu_Ult_Mod = dr["Usu_Ult_Mod"].ToString();
                    objAlumnoBE.Fec_Ult_Mod = Convert.ToDateTime(dr["Fec_Ult_Mod"]);
                    objAlumnoBE.Est_alum = Convert.ToInt16(dr["Est_alum"]);
                }
                dr.Close();
                return objAlumnoBE;
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
        public DataTable ListarAlumno()
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
                ada.Fill(dts, "Alumnos");
                return dts.Tables["Alumnos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
