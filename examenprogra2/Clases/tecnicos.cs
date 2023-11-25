using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examenprogra2.Clases
{
    public class tecnicos
    {

        public int tecnicoID { get; set; }

        public string nombre { get; set; }

        public string especialidad { get; set; }

        public tecnicos(string nombre, string especialidad)
        {

            this.nombre = nombre;
            this.especialidad = especialidad;
        }

        public tecnicos()
        {
        }

        public void agregar() { }

        public void borrar() { }

        public void consultarconfiltro() { }

        public void modificar() { }


    }
}