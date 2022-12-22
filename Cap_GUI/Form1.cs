using Cap_Negocios;
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
            m_consulta_TipoHabitacion();
            m_consulta_Servicio();
        }

        public void m_consulta_clientes()
        {
            int id = 0;
            conexion.ConnectionString = "Data Source=LUISBLANCO-PC\\SQL2019_DEV;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True";
            string query = "SELECT *FROM [SCH_PERSONA].[TB_CLIENTES]";
            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Clientes.Items.Add(dr[0]);
            }
            conexion.Close();

        }
        public void m_consulta_TipoHabitacion()
        {
            int id = 0;
            conexion.ConnectionString = "Data Source=LUISBLANCO-PC\\SQL2019_DEV;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True";
            string query = "SELECT *FROM [SCH_CLUB].[TB_TIPO_HABITACIONES]";
            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_TipoHabitacion.Items.Add(dr[0]);
            }
            conexion.Close();
        }
        public void m_consulta_Servicio()
        {
            int id = 0;
            conexion.ConnectionString = "Data Source=LUISBLANCO-PC\\SQL2019_DEV;Initial Catalog=DB_CLUB_CAMPESTRE_UAM;Integrated Security=True";
            string query = "SELECT *FROM [SCH_CLUB].[TB_SERVICIOS]";
            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_Servicio.Items.Add(dr[0]);
            }
            conexion.Close();
        }
        cls_Entidad_Insertar_Cliente ObjInsertar_Cliente = new cls_Entidad_Insertar_Cliente();
        public void m_insertar_Cliente()
        {
            ObjInsertar_Cliente.CED1 = (txt_ced.Text);
            ObjInsertar_Cliente.NOMBRE1 = (txt_nombre.Text);
            ObjInsertar_Cliente.APELLIDO1 = (txt_apellido.Text);
            ObjInsertar_Cliente.EDAD1 = int.Parse(txt_edad.Text.Trim());
            ObjInsertar_Cliente.TEL1 = int.Parse(txt_Telefono.Text.Trim());

            ObjInsertar_Cliente.ingresar_Cliente();
            MessageBox.Show("Hecho");
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            m_insertar_Cliente();
        }

        private void cb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_AgregarReserva_Click(object sender, EventArgs e)
        {

        }
    }
}
