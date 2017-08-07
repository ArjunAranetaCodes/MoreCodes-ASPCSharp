
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem3{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   int length = Convert.ToInt32(TextBox1.Text);
   int width = Convert.ToInt32(TextBox2.Text);
   int area = length * width;

   Label1.Text = "Area of Rectangle is " + area.ToString();
  }
 }
}

