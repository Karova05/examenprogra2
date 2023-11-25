using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using examenprogra2.Clases;
using System.Drawing;

namespace examenprogra2
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                LlenarGrid();
            }

        }



        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }


        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString; // para establecer la conexion, variable ruta

            using (SqlConnection con = new SqlConnection(constr)) // para establecer la conexion variable conexiones
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM usuarios"))  // variable para los comandos
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter()) // variable para el adaptar 
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable()) // tabla virtual 
                        {
                            sda.Fill(dt);
                            datagrid.DataSource = dt; // se carga la tabla
                            datagrid.DataBind();  // actualizar el grid view
                        }
                    }
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            int resultado = Clases.usuarios.agregar(tnombre.Text);

            if (resultado > 0)
            {
                LlenarGrid();
                alertas("usuario agregado con exito");
            }

            else
            {
                alertas("Error al agregar usuario");

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int resultado = Clases.usuarios.borrar(int.Parse(id.Text));

            if (resultado > 0)
            {
                LlenarGrid();
                alertas("usuario ha sido borrado con exito");
            }

            else
            {
                alertas("Error al borrar usuario");

            }

        }

        protected void Bconsulta_Click(object sender, EventArgs e)
        {
            int resultado = Clases.usuarios.consultatipofiltro(int.Parse(id.Text));

            if (resultado > 0)
            {
                LlenarGrid();
                alertas("se ha consultado con exito");
            }

            else
            {
                alertas("Error al consultar usuario");

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int resultado = Clases.usuarios.modificar(int.Parse(id.Text));

            if (resultado > 0)
            {
                LlenarGrid();
                alertas("se ha realizado la modificacion con exito");
            }

            else
            {
                alertas("Error al tratar de modificar usuario");

            }

        }
    }
}