using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;
using System.Drawing;
using examenprogra2.Clases;

namespace examenprogra2
{
    public partial class equipo1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (! IsPostBack)
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM equipo"))  // variable para los comandos
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


    
    }
}


