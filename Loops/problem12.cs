
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem12{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num1 = 3;
   int num2 = 5;
   int prod = 0;

   for (int x = 1; x <= num2; x++){
    prod = prod + num1;
   }
   Label1.Text = "3 * 5 = " + prod.ToString();
  }
 }
}

