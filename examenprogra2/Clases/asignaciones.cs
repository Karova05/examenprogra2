using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examenprogra2.Clases
{
    public class asignaciones
    {

        public int asignacionID { get; set; }

        public int reparacionID2 { get; set; }

        public int tecnicoID { get; set; }

        public DateTime fechaasignacion { get; set; }

        public asignaciones(int reparacionID2, DateTime fechaasignacion)
        {

            this.reparacionID2 = reparacionID2;

            this.fechaasignacion = fechaasignacion;
        }

        public asignaciones()
        {
        }


    }
}

