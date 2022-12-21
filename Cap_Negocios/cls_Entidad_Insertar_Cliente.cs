using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap_Datos;

namespace Cap_Negocios
{
    public class cls_Entidad_Insertar_Cliente
    {
        clc_Insertar_Cliente ObjInsertar_Cliente = new clc_Insertar_Cliente();

        string CED;
        string NOMBRE;
        string APELLIDO;
        int EDAD;
        int TEL;

        public string CED1 { get => CED; set => CED = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string APELLIDO1 { get => APELLIDO; set => APELLIDO = value; }
        public int EDAD1 { get => EDAD; set => EDAD = value; }
        public int TEL1 { get => TEL; set => TEL = value; }

        public bool ingresar_Cliente ()
        {
            bool estado = true;
            if (estado == true)
            {
                ObjInsertar_Cliente.m_Insertar_Cliente(CED1, NOMBRE1, APELLIDO1, EDAD1, TEL1);

            }
            else
            {
                estado = false;
            }
            return estado;
        }
    }
}
