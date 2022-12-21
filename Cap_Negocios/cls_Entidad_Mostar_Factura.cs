using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap_Datos;

namespace Cap_Negocios
{
    public class cls_Entidad_Mostar_Factura
    {
        int COD_FACTURA;

        public int COD_FACTURA1 { get => COD_FACTURA; set => COD_FACTURA = value; }

        public DataTable m_Consultar_Factura()
        {
            cls_Mostra_Facrtura insAD = new cls_Mostra_Facrtura();
            return insAD.m_Consultar_Factura(COD_FACTURA);
        }
    }
}
