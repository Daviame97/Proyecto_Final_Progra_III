using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Datos
{
    public class cls_Mostrar_Cliente
    {
        SqlConnection ObjConex = new SqlConnection();
        SqlDataAdapter ObjAdaptador;
        DataTable ObjTB_Cliente;

        public DataTable m_Consultar_Cliente(string v_CED)
        {
            try
            {
                ObjConex.ConnectionString = ("Data Source=LAPTOP-UTFDK6V4\\SQLEXPRESS;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True");
                ObjAdaptador = new SqlDataAdapter("SELECT * FROM [SCH_PERSONA].[TB_CLIENTES] = '" + v_CED + "' ", ObjConex);
                ObjTB_Cliente = new DataTable();
                ObjConex.Open();
                ObjAdaptador.Fill(ObjTB_Cliente); // Carga la informacion en el "GritView"
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjConex.Close();
            }
            return ObjTB_Cliente;
        }
    }
}
