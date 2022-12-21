using Cap_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_Negocios
{
    public class cls_Entidad_Mostrar_Factura
    {
        int COD_FACTURA;

        public int COD_FACTURA1 { get => COD_FACTURA; set => COD_FACTURA = value; }

        public DataTable m_Consultar_Factura()
        {
            cls_MostrarFactura insAD = new cls_MostrarFactura();
            return insAD.m_Consultar_Factura(COD_FACTURA);
        }
    }
}
