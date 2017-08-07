
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem5{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   double celsius = Convert.ToInt32(TextBox1.Text);
   double farenheit = 0.0;

   farenheit = (9.0 / 5.0) * celsius + 32;
   Label1.Text = celsius.ToString() + "C equals to " +
    farenheit.ToString() + "F";
  }
 }
}

