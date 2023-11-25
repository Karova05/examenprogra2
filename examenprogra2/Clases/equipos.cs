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
    public class equipos
    {

        public int equipoID { get; set; }

        public string tipoequipo { get; set; }

        public string modelo { get; set; }

        public int usuarioID { get; set; }

        public equipos(string tipoequipo, string modelo)
        {

            this.tipoequipo = tipoequipo;
            this.modelo = modelo;

        }

       


        public equipos() { }

        public static int agregar(string modelo)
        {
            int retorno = 0;

            using (SqlConnection Conn = DBConn.ObtenerConexion ())
            {
                try
            {
                
                    SqlCommand cmd = new SqlCommand("agregarequipo", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));


                    retorno = cmd.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                retorno = -1;
            
            }

            }

            return retorno;

        }


        public static int borrar(string modelo)
        {
            int retorno = 0;

            using (SqlConnection Conn = DBConn.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("borrarequipos", Conn)
                {
                      CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@modelo", modelo));


                    retorno = cmd.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                retorno = -1;
            
                   
            }
            }

            return retorno;

        }


        public static int consultatipofiltro(int equipoid)
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
                    cmd.Parameters.Add(new SqlParameter("@equipoID", equipoid));


                    retorno = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    retorno = -1;


                }
            }

            return retorno;

        }

        public static int modificar(int equipoid)
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
                    cmd.Parameters.Add(new SqlParameter("@equipoID", equipoid));


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