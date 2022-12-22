using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Libreria de recursos SQL
using System.Data.SqlClient; //Libreria de recursos SQL

namespace Cap_Datos
{
    public class clc_Insertar_Cliente
    {
        SqlConnection ObjConex = new SqlConnection();
        SqlCommand Objcmd = new SqlCommand();

        public void m_Insertar_Cliente(string v_CED,string v_NOMBRE, string v_APELLIDO, int v_EDAD, int v_TEL)
        {
            try
            {
                ObjConex.ConnectionString = ("Data Source=LUISBLANCO-PC\\SQL2019_DEV;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True");

                SqlParameter p_CED = new SqlParameter("@CED",SqlDbType.Char);
                p_CED.Value = v_CED;

                SqlParameter p_NOMBRE = new SqlParameter("@NOMBRE", SqlDbType.NVarChar);
                p_NOMBRE.Value = v_NOMBRE;

                SqlParameter p_APELLIDO = new SqlParameter("@APELLIDO", SqlDbType.NVarChar);
                p_APELLIDO.Value = v_APELLIDO;

                SqlParameter p_EDAD = new SqlParameter("@EDAD", SqlDbType.TinyInt);
                p_EDAD.Value = v_EDAD;

                SqlParameter p_TEL = new SqlParameter("@TEL", SqlDbType.Int);
                p_TEL.Value = v_TEL;

                //Agregar parametros
                Objcmd.Parameters.Add(p_CED);
                Objcmd.Parameters.Add(p_NOMBRE);
                Objcmd.Parameters.Add(p_APELLIDO);
                Objcmd.Parameters.Add(p_EDAD);
                Objcmd.Parameters.Add(p_TEL);

                Objcmd.CommandType = CommandType.StoredProcedure; // Llamada al proceso de almacenado en DB Empleados
                Objcmd.CommandText = "SP_INSERTAR_CLIENTES";
                ObjConex.Open();
                Objcmd.Connection = ObjConex;
                Objcmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjConex.Close();
            }
        }
    }
}
