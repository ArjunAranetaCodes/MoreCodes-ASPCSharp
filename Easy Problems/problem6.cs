
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem6{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click1(object sender, EventArgs e){
   int num = Convert.ToInt32(TextBox1.Text);

   if (num % 2 == 0){
    Label1.Text = "Number is even";
   }
   else{
    Label1.Text = "Number is odd";
   }

  }
 }
}

