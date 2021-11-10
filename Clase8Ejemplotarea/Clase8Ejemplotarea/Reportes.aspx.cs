using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Clase8Ejemplotarea
{
    public partial class Reportes : System.Web.UI.Page
    {
        int NumeroEncuesta;
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();

        }

        protected void LlenarGrid()
        {
            string s = ConfigurationManager.ConnectionStrings["ENCUESTAConnectionString"].ConnectionString;
            string query = " SELECT PERSONA.IDPERSONA, PERSONA.NOMBRE, PERSONA.EDAD, PERSONA.GENERO," +
                           " RESPUESTA.RESPUESTA1,RESPUESTA.RESPUESTA2" +
                           " FROM PERSONA INNER JOIN RESPUESTA ON PERSONA.IDPERSONA = RESPUESTA.IDPERSONA ";
            using (SqlConnection conexion = new SqlConnection(s))
            {
                using (SqlCommand comando = new SqlCommand(query)) 
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter())
                    {
                        comando.Connection = conexion;
                        adaptador.SelectCommand = comando;
                        using (DataSet ds = new DataSet())
                        {
                            adaptador.Fill(ds);
                            GridView1.DataSource = ds.Tables[0];
                            GridView1.DataBind();
                        }
                        conexion.Close();
                    }
                   
                }

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ENCUESTAConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();  // Abrir conexion
            SqlCommand comando = new SqlCommand("INSERT INTO Persona(nombre, edad, genero) VALUES('" + Formulario.Nombre + "', " +
                                                Formulario.Edad + ", '" + Formulario.genero + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close(); // Cerrar Conexion
            ConsultaUltimaEncuesta();
            GuardarRespuesta();
            LlenarGrid();

        }

        protected void GuardarRespuesta()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ENCUESTAConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO RESPUESTA VALUES(" + NumeroEncuesta + " , '" + Formulario.Respuesta1+ "', '" + Formulario.Respuesta2 + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();


        }

        protected void ConsultaUltimaEncuesta()
        {
            NumeroEncuesta = 0;
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ENCUESTAConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT max(IDPERSONA) as ID FROM PERSONA", conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                NumeroEncuesta = Convert.ToInt32(registro.GetValue(0));
            }
            conexion.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["ENCUESTAConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("DELETE RESPUESTA WHERE IDPERSONA = '" + TID.Text+  "'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }
    }
}