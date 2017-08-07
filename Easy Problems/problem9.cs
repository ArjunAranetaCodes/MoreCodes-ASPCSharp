
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem9{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   int sum = 0;
   int num = Int32.Parse(TextBox1.Text);

   for (int x = 0; x <= num; x++){
    ssum = sum + x;
   }

   Label1.Text = "The sum of 1 to " + num.ToString() +
   " is " + sum.ToString();
  }
 }
}

