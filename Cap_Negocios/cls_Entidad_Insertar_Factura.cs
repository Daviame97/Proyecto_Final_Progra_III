using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap_Datos;

namespace Cap_Negocios
{
    public class cls_Entidad_Insertar_Factura
    {
        cls_Insertar_Factura ObjInsertar_Factura  = new cls_Insertar_Factura();

        int COD_FACTURA;
        DateTime FECHA;
        float TOTAL;
        string CED_CLIENTE;
        string HABITACION_FACTURADA;
        string SERVICIO_FACTURADO;

        public int COD_FACTURA1 { get => COD_FACTURA; set => COD_FACTURA = value; }
        public DateTime FECHA1 { get => FECHA; set => FECHA = value; }
        public float TOTAL1 { get => TOTAL; set => TOTAL = value; }
        public string CED_CLIENTE1 { get => CED_CLIENTE; set => CED_CLIENTE = value; }
        public string HABITACION_FACTURADA1 { get => HABITACION_FACTURADA; set => HABITACION_FACTURADA = value; }
        public string SERVICIO_FACTURADO1 { get => SERVICIO_FACTURADO; set => SERVICIO_FACTURADO = value; }
        
        public bool ingresar_Factura()
        {
            bool estado = true;
            if (estado == true)
            {
                ObjInsertar_Factura.m_Insertar_Factura(COD_FACTURA1, FECHA1, TOTAL1, CED_CLIENTE1, HABITACION_FACTURADA1, SERVICIO_FACTURADO1);

            }
            else
            {
                estado = false;
            }
            return estado;
        }
    }
}
