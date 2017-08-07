
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem9{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num = 2;
   for (int x = 0; x <= 10; x++){
    Label1.Text = Label1.Text + num.ToString() + " x " +
     x.ToString() + " = " + (num * x).ToString() + "<br/>";
   }
  }
 }
}

