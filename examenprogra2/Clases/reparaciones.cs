using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examenprogra2.Clases
{
    public class reparaciones
    {


        public int reparacionID { get; set; }

        public int equipoID { get; set; }

        public DateTime fechasolicitud { get; set; }

        public string estado { get; set; }

        public reparaciones(DateTime fechasolicitud, string estado)
        {

            this.fechasolicitud = fechasolicitud;
            this.estado = estado;
        }

        public reparaciones()
        {
        }


    }
}