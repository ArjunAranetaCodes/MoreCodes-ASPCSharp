
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem7{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
  int sum = 0;
  for (int x = 0; x <= 20; x++){
   sum = sum + x;
  }
  Label1.Text = "The sum of 1 to 20 is " + sum.ToString();
  }
 }
}

