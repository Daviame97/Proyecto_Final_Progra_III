using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap_Datos;

namespace Cap_Negocios
{
    public class cls_Entidad_Mostrar_Cliente
    {

        string CED;

        public string CED1 { get => CED; set => CED = value; }

        public DataTable m_Consultar_Cliente()
        {
            cls_Mostrar_Cliente insAD = new cls_Mostrar_Cliente();
            return insAD.m_Consultar_Cliente(CED);
        }
    }
}
