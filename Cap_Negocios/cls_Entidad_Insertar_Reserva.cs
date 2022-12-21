using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap_Datos;

namespace Cap_Negocios
{
    public class cls_Entidad_Insertar_Reserva
    {
        cls_Insertar_Reserva ObjInsertar_Reserva = new cls_Insertar_Reserva();

        int RESERVA_ID;
        int CANT_PERSONAS;
        int FECHA;
        int NUM_HABITACION;
        string CED_CLIENTE;
        string HABITACION_RESERVADA;
        string SERVICIO_RESERVADO;

        public int RESERVA_ID1 { get => RESERVA_ID; set => RESERVA_ID = value; }
        public int CANT_PERSONAS1 { get => CANT_PERSONAS; set => CANT_PERSONAS = value; }
        public int FECHA1 { get => FECHA; set => FECHA = value; }
        public int NUM_HABITACION1 { get => NUM_HABITACION; set => NUM_HABITACION = value; }
        public string CED_CLIENTE1 { get => CED_CLIENTE; set => CED_CLIENTE = value; }
        public string HABITACION_RESERVADA1 { get => HABITACION_RESERVADA; set => HABITACION_RESERVADA = value; }
        public string SERVICIO_RESERVADO1 { get => SERVICIO_RESERVADO; set => SERVICIO_RESERVADO = value; }

        public bool ingresar_Reserva()
        {
            bool estado = true;
            if (estado == true)
            {
                ObjInsertar_Reserva.m_Insertar_Reserva(RESERVA_ID1, CANT_PERSONAS1, FECHA1, NUM_HABITACION1, CED_CLIENTE1, HABITACION_RESERVADA1, SERVICIO_RESERVADO1);

            }
            else
            {
                estado = false;
            }
            return estado;
        }
    }
}
