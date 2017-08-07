
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem17{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num1 = 1;
   int num2 = 1;

   Label1.Text = Label1.Text + num1.ToString() + "&lt;br/>";
   while (num2 < 100){
    Label1.Text = Label1.Text + num2.ToString() + "&lt;br/>";
    num2 = num2 + num1;
    num1 = num2 - num1;
   }
  }
 }
}

