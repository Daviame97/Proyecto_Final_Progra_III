using Cap_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Metodo_Insertar_Cliente
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
        #endregion

        #region Mostrar_Cliente
        public void m_Mostar_Cliente()
        {
            cls_Entidad_Mostrar_Cliente ObjMostrar_Cliente = new cls_Entidad_Mostrar_Cliente();

            ObjMostrar_Cliente.CED1 = (cb_Clientes.Text);
            dgv_Mostrar_Informacion.DataSource = ObjMostrar_Cliente.m_Consultar_Cliente();

        }
        #endregion

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            m_insertar_Cliente();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
