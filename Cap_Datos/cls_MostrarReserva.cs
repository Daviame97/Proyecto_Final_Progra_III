using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Datos
{
    public class cls_MostrarReserva
    {
        SqlConnection ObjConex = new SqlConnection();
        SqlDataAdapter ObjAdaptador;
        DataTable ObjTB_Reserva;

        public DataTable m_Consultar_Factura(int v_RESERVA_ID)
        {
            try
            {
                ObjConex.ConnectionString = ("Data Source=LUISBLANCO-PC\\SQL2019_DEV;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True");
                ObjAdaptador = new SqlDataAdapter("SELECT * FROM [SCH_CLUB].[TB_RESERVAS] ='" + v_RESERVA_ID + "' ", ObjConex);
                ObjTB_Reserva = new DataTable();
                ObjConex.Open();
                ObjAdaptador.Fill(ObjTB_Reserva); // Carga la informacion en el "GritView"
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjConex.Close();
            }
            return ObjTB_Reserva;
        }
    }
}
