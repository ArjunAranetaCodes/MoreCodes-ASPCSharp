
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem6{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   for (int x = 0; x <= 20; x++){
    if (x % 2 == 1){
     Label1.Text = Label1.Text + x.ToString() + "&lt;br/>";
    }
   }
  }
 }
}

