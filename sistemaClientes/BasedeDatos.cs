using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using SistemaSeguridad.Properties;
using System.Drawing;

namespace SistemaSeguridad
{
    class BasedeDatos
    {
        public static string obtener()
        {
            return Settings.Default.ATMICHConnectionString;
        }
        SqlConnection conexion = new SqlConnection(obtener());
        

        public void enviar(String consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            
            conexion.Close();
        }
        public DataSet recibir(String consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
            DataSet datos = new DataSet();
            SqlDataAdapter adaptador_de_datos = new SqlDataAdapter(comando);
            adaptador_de_datos.Fill(datos);
            return datos;
        }


        public static SqlConnection cnx = new SqlConnection(obtener());
        public static DataTable EjecutarQuery(string Q, Image img)
        {
            MemoryStream MS = new MemoryStream();
            try
            {
                img.Save(MS, img.RawFormat);
            }
            catch
            {


            }


            byte[] Imagenes = MS.GetBuffer();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Q, cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@Imagen", Imagenes);

            try
            {
                cnx.Open();
                da.Fill(dt);
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { cnx.Close(); }

            return dt;

        }
    }

}
