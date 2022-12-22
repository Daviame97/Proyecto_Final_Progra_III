using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Datos
{
    public class cls_Insertar_Factura
    {
        SqlConnection ObjConex = new SqlConnection();
        SqlCommand Objcmd = new SqlCommand();

        public void m_Insertar_Factura(int v_COD_FACTURA, DateTime v_FECHA, float v_TOTAL, string v_CED_CLIENTE, string v_HABITACION_FACTURADA, string v_SERVICIO_FACTURADO)
        {
            try
            {
                ObjConex.ConnectionString = ("Data Source=LUISBLANCO-PC\\SQL2019_DEV;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True");

                SqlParameter p_COD_FACTURA = new SqlParameter("@COD_FACTURA", SqlDbType.Int);
                p_COD_FACTURA.Value = v_COD_FACTURA;

                SqlParameter p_FECHA = new SqlParameter("@FECHA", SqlDbType.DateTime);
                p_FECHA.Value = v_FECHA;

                SqlParameter p_TOTAL = new SqlParameter("@TOTAL", SqlDbType.Int);
                p_TOTAL.Value = v_TOTAL;

                SqlParameter p_CED_CLIENTE = new SqlParameter("@CED_CLIENTE", SqlDbType.Char);
                p_CED_CLIENTE.Value = v_CED_CLIENTE;

                SqlParameter p_HABITACION_FACTURADA = new SqlParameter("@HABITACION_FACTURADA", SqlDbType.VarChar);
                p_HABITACION_FACTURADA.Value = v_HABITACION_FACTURADA;

                SqlParameter p_SERVICIO_FACTURADO = new SqlParameter("@SERVICIO_FACTURADO", SqlDbType.NVarChar);
                p_SERVICIO_FACTURADO.Value = v_SERVICIO_FACTURADO;

                //Agregar parametros
                Objcmd.Parameters.Add(p_COD_FACTURA);
                Objcmd.Parameters.Add(p_FECHA);
                Objcmd.Parameters.Add(p_TOTAL);
                Objcmd.Parameters.Add(p_CED_CLIENTE);
                Objcmd.Parameters.Add(p_HABITACION_FACTURADA);
                Objcmd.Parameters.Add(p_SERVICIO_FACTURADO);

                Objcmd.CommandType = CommandType.StoredProcedure; // Llamada al proceso de almacenado en DB Empleados
                Objcmd.CommandText = "SP_INSERTAR_FACTURA";
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
