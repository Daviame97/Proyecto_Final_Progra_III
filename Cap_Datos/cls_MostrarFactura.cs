using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Datos
{
    public class cls_MostrarFactura
    {
        SqlConnection ObjConex = new SqlConnection();
        SqlDataAdapter ObjAdaptador;
        DataTable ObjTB_Factura;

        public DataTable m_Consultar_Factura(int v_COD_FACTURA)
        {
            try
            {
                ObjConex.ConnectionString = ("Data Source=LAPTOP-UTFDK6V4\\SQLEXPRESS;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True");
                ObjAdaptador = new SqlDataAdapter("SELECT * FROM [SCH_CLUB].[TB_FACTURA] ='" + v_COD_FACTURA + "' ", ObjConex);
                ObjTB_Factura = new DataTable();
                ObjConex.Open();
                ObjAdaptador.Fill(ObjTB_Factura); // Carga la informacion en el "GritView"
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjConex.Close();
            }
            return ObjTB_Factura;
        }
    }
}
