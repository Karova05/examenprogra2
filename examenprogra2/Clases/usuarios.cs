using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examenprogra2.Clases
{
    public class usuarios
    {


        public int usuarioID { get; set; }

        public string nombre { get; set; }

        public string correoelectronico { get; set; }

        public int telefono { get; set; }

        public usuarios(string nombre, string correoelectronico, int telefono)
        {

            this.nombre = nombre;
            this.correoelectronico = correoelectronico;
            this.telefono = telefono;
        }

        public usuarios()
        {
        }


        public void agregar() { }

        public void borrar() { }

        public void consultarconfiltro() { }

        public void modificar() { }




    }
}