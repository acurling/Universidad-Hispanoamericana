using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tareafiguras
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataUsuarios.Insert();
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            SqlDataUsuarios.Delete();
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            SqlDataUsuarios.Update();
        }

        protected void SqlDataUsuarios_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void tnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}