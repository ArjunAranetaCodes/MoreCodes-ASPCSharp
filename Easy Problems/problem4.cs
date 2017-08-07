
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem4{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   int radius = Convert.ToInt32(TextBox1.Text);
   double PI = 3.14;
   double dia = 0.0;
   double area = 0.0;
   double cir = 0.0;

   dia = radius + radius;
   area = PI * dia;
   cir = 2 * PI * radius;

   Label1.Text = "Diameter of circle is " + dia.ToString();
   Label2.Text = "Area of circle is " + area.ToString();
   Label3.Text = "Circumference of circle is " + cir.ToString();
  }
 }
}

