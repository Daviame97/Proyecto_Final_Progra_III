using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Cap_Datos;

namespace Cap_Negocios
{
    public class cls_Entidad_Mostrar_Reserva
    {
        int RESERVA_ID;

        public int RESERVA_ID1 { get => RESERVA_ID; set => RESERVA_ID = value; }

        public DataTable m_Consultar_Reserva()
        {
            cls_Mostrar_Reserva insAD = new cls_Mostrar_Reserva();
            return insAD.m_Consultar_Factura(RESERVA_ID);
        }
    }
}
