using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap_GUI
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection();
        SqlDataAdapter adaptador;
        DataTable tblClientes;
        public Form1()
        {
            InitializeComponent();
            m_consulta_clientes();
        }
        public void m_consulta_clientes()
        {

            conexion.ConnectionString = "Data Source=LUISBLANCO-PC\\SQL2019_DEV;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True";
            string query = "SELECT *FROM [SCH_PERSONA].[TB_CLIENTES]";
            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Clientes.Items.Add(dr[1]);
            }
        }

        private void btn_AgregarReserva_Click(object sender, EventArgs e)
        {

        }
    }
}
