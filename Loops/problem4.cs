
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem4{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   for (int y = 0; y <= 5; y++){
    for (int x = 0; x <= y; x++){
     Label1.Text = Label1.Text + "*";
    }
    Label1.Text = Label1.Text + "&lt;br/>";
   }
  }
 }
}

