using Cap_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Negocios
{
    internal class cls_Entidad_Mostrar_Cliente
    {
        string CED;

        public string CED1 { get => CED; set => CED = value; }

        public DataTable m_Consultar_Cliente()
        {
            cls_MostrarCliente insAD = new cls_MostrarCliente();
            return insAD.m_Consultar_Cliente(CED);
        }
    }
}
