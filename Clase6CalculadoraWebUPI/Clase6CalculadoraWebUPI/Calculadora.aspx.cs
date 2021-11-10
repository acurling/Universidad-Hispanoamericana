using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase6CalculadoraWebUPI
{
    public partial class Calculadora : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Lusuario.Text = "Bienvenido " + ClsUsuario.GetNombre() + " Hoy es: " + DateTime.Now;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Contactenos.aspx");
        }

        protected void bcalcular_Click(object sender, EventArgs e)
        {
            if (R1.Checked)
            {
                Radiobutton();
            }
            else if (R2.Checked)
            {
                checkbox();
            }
            else
            {
                Dropdownlist();
            }
            
           
            
        }

        protected void checkbox()
        {
            ClsCalculadora operacion = new ClsCalculadora(float.Parse(tvalor1.Text), float.Parse(tvalor2.Text));

            string res = "";
            if (csuma.Checked)
            {
               res = res + " La suma es: "  + operacion.Sumar();
            }

            if (cresta.Checked)
            {
                res = res + " La resta es: "  + operacion.restar();
            }

            lresultado.Text = res;
        }

        protected void Dropdownlist() 
        {
            ClsCalculadora operacion = new ClsCalculadora(float.Parse(tvalor1.Text), float.Parse(tvalor2.Text));

            if (Doperaciones.SelectedIndex == 0)
            {
                operacion.Sumar();
            }
            else if (Doperaciones.SelectedIndex == 1)
            {
                operacion.restar();
            }
            else if (Doperaciones.SelectedIndex == 2)
            {
                // operacion.multiplicar
            }
            lresultado.Text = Convert.ToString(operacion.respuesta());
        }
        protected void Radiobutton() 
        {
            ClsCalculadora operacion = new ClsCalculadora(float.Parse(tvalor1.Text), float.Parse(tvalor2.Text));

          if (rsuma.Checked)
            {
                operacion.Sumar();
            }
            else if (rresta.Checked)
            {
                operacion.restar();
            }
            lresultado.Text = Convert.ToString(operacion.respuesta());
        
        }

        protected void R1_CheckedChanged(object sender, EventArgs e)
        {
            csuma.Visible = false;
            cresta.Visible = false;
            Doperaciones.Visible = false;
            rsuma.Visible = true;
            rresta.Visible = true;
        }

        protected void R2_CheckedChanged(object sender, EventArgs e)
        {
            csuma.Visible = true;
            cresta.Visible = true;
            Doperaciones.Visible = false;
            rsuma.Visible = false;
            rresta.Visible = false;
        }

        protected void R3_CheckedChanged(object sender, EventArgs e)
        {
            csuma.Visible = false;
            cresta.Visible = false;
            Doperaciones.Visible = true;
            rsuma.Visible = false;
            rresta.Visible = false;
        }
    }
}