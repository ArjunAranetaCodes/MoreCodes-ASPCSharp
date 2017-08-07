
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem7{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int n = 10;
   int sum = 0;
   for (int x = 0; x <= n; x++){
    sum = sum + x;
   }
   Label1.Text = "Sum is " + sum.ToString();
  }
 }
}

