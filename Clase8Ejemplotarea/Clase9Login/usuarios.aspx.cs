using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase9Login
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }


        protected void LlenarGrid()
        {
            string s = ConfigurationManager.ConnectionStrings["GIMNASIOConnectionString"].ConnectionString;
            string query = " SELECT * FROM USUARIO ";
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
    }
}