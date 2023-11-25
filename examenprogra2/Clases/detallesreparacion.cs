using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examenprogra2.Clases
{
    public class detallesreparacion
    {

        public int detalleID { get; set; }

        public int reparacionID { get; set; }

        public string descripcion { get; set; }

        public DateTime fechainicio { get; set; }

        public DateTime fechafin { get; set; }

        public detallesreparacion(string descripcion, DateTime fechainicio, DateTime fechafin)
        {


            this.descripcion = descripcion;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
        }

        public detallesreparacion()
        {
        }

    }
}