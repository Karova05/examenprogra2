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

        public tecnicos() { }

        public static int agregar(string nombre)
        {
            int retorno = 0;

            using (SqlConnection Conn = DBConn.ObtenerConexion())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("agregartecnico", Conn)
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
                    SqlCommand cmd = new SqlCommand("borrartecnicos", Conn)
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


        public static int consultatipofiltro(int tecnicoid)
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
                    cmd.Parameters.Add(new SqlParameter("@tecnicoID", tecnicoid));


                    retorno = cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    retorno = -1;


                }
            }

            return retorno;

        }

        public static int modificar(int tecnicoid)
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
                    cmd.Parameters.Add(new SqlParameter("@tecnicoID", tecnicoid));


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