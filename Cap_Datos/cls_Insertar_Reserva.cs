using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Datos
{
    public class cls_Insertar_Reserva
    {
            SqlConnection ObjConex = new SqlConnection();
            SqlCommand Objcmd = new SqlCommand();

            public void m_Insertar_Reserva(int v_RESERVA_ID, int v_CANT_PERSONAS, int v_FECHA, int v_NUM_HABITACION, string v_CED_CLIENTE, string v_HABITACION_RESERVADA)
            {
                try
                {
                    ObjConex.ConnectionString = ("Data Source=LAPTOP-UTFDK6V4\\SQLEXPRESS;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True");

                    SqlParameter p_RESERVA_ID = new SqlParameter("@RESERVA_ID", SqlDbType.Int);
                    p_RESERVA_ID.Value = v_RESERVA_ID;

                    SqlParameter p_CANT_PERSONAS = new SqlParameter("@CANT_PERSONAS", SqlDbType.TinyInt);
                    p_CANT_PERSONAS.Value = v_CANT_PERSONAS;

                    SqlParameter p_FECHA = new SqlParameter("@FECHA", SqlDbType.DateTime);
                    p_FECHA.Value = v_FECHA;

                    SqlParameter p_NUM_HABITACION = new SqlParameter("@NUM_HABITACION", SqlDbType.Int);
                    p_NUM_HABITACION.Value = v_NUM_HABITACION;

                    SqlParameter p_TEL = new SqlParameter("@CED_CLIENTE", SqlDbType.Char);
                    p_TEL.Value = v_CED_CLIENTE;

                    SqlParameter p_HABITACION_RESERVADA = new SqlParameter("@HABITACION_RESERVADA", SqlDbType.VarChar);
                    p_HABITACION_RESERVADA.Value = v_HABITACION_RESERVADA;

                    //Agregar parametros
                    Objcmd.Parameters.Add(p_RESERVA_ID);
                    Objcmd.Parameters.Add(p_CANT_PERSONAS);
                    Objcmd.Parameters.Add(p_FECHA);
                    Objcmd.Parameters.Add(p_NUM_HABITACION);
                    Objcmd.Parameters.Add(p_TEL);
                    Objcmd.Parameters.Add(p_HABITACION_RESERVADA);

                    Objcmd.CommandType = CommandType.StoredProcedure; // Llamada al proceso de almacenado en DB Empleados
                    Objcmd.CommandText = "SP_INSERTAR_RESERVAS";
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
