
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem8{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int sum = 0;
   for (int x = 0; x <= 20; x++){
    if (x % 5 == 0){
     sum = sum + x;
    }
   }
   Label1.Text = "The sum of numbers divisible by 5 from 1 to 30 is " +
   sum.ToString();
  }
 }
}

