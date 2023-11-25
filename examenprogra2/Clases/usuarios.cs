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

        public usuarios() { }

        public static int agregar(string nombre)
        {
            int retorno = 0;

            using (SqlConnection Conn = DBConn.ObtenerConexion())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("agregarusuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));


                    retorno = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    retorno = -1;

                }

            }

            return retorno;

        }


        public static int borrar(string nombre)
        {
            int retorno = 0;

            using (SqlConnection Conn = DBConn.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("borrarusuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));


                    retorno = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    retorno = -1;


                }
            }

            return retorno;

        }


        public static int consultatipofiltro(int usuarioid)
        {
            int retorno = 0;

            using (SqlConnection Conn = DBConn.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("consultatipofiltro", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@usuarioID", usuarioid));


                    retorno = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    retorno = -1;


                }
            }

            return retorno;

        }

        public static int modificar(int usuarioid)
        {
            int retorno = 0;

            using (SqlConnection Conn = DBConn.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("modificar", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@usuarioID", usuarioid));


                    retorno = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    retorno = -1;


                }
            }

            return retorno;

        }




    }
}