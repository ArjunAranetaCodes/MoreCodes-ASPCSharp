
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem15{
 public partial class WebForm1 : System.Web.UI.Page{

  protected void Button1_Click(object sender, EventArgs e){
   int num = Int32.Parse(TextBox1.Text);

   if (num < 0){
    Label1.Text = "Terminated";
   }

  }
 }
}

