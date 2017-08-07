
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem16{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num = 5;
   int fact = 1;

   for (int x = num; x >= 1; x--){
    fact = fact * x;
   }
   Label1.Text = "Factorial of 5 is " + fact.ToString();
  }
 }
}

