using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace examenprogra2
{
    public partial class equipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Clases.equipos.agregar(tdescripcion.Text) > 0)
            {
                LlenarGrid();
                alertas("equipo borrado con exito");
            }

            else
            {
                alertas("Error al borrar equipo");

            }

        
    }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (Clases.equipos.borrar(int.Parse(tcodigo.Text)) > 0)
            {
                LlenarGrid();
                alertas("equipo  ha sido ingresado con exito");
            }

            else
            {
                alertas("Error al ingresar equipo");

            }

        }
    }
}