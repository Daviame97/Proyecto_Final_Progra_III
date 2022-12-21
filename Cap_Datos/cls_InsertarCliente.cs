using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Datos
{
    public class cls_InsertarCliente
    {
        SqlConnection ObjConex = new SqlConnection();
        SqlCommand Objcmd = new SqlCommand();
        public void m_Insertar_Cliente(string ced, string nombre, string apellido, int edad, int tel)
        {
            try
            {
                ObjConex.ConnectionString = ("Data Source=LAPTOP-UTFDK6V4\\SQLEXPRESS;Initial Catalog=Empleados;Integrated Security=True");

                SqlParameter p_Ced = new SqlParameter("@CED", SqlDbType.Char);
                p_Ced.Value = ced;

                SqlParameter p_Nombre = new SqlParameter("@NOMBRE", SqlDbType.NVarChar);
                p_Nombre.Value = nombre;

                SqlParameter p_Apellido = new SqlParameter("@APELLIDO", SqlDbType.NVarChar);
                p_Apellido.Value = apellido;

                SqlParameter p_Edad = new SqlParameter("@EDAD", SqlDbType.TinyInt);
                p_Edad.Value = edad;

                SqlParameter p_Tel = new SqlParameter("@TEL", SqlDbType.Int);
                p_Edad.Value = p_Tel;



                //Agregar parametros
                Objcmd.Parameters.Add(p_Ced);
                Objcmd.Parameters.Add(p_Nombre);
                Objcmd.Parameters.Add(p_Apellido);
                Objcmd.Parameters.Add(p_Edad);
                
                

                Objcmd.CommandType = CommandType.StoredProcedure; // Llamada al proceso de almacenado en DB Club
                Objcmd.CommandText = "SP_INSERTAR_CLIENTE";
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
