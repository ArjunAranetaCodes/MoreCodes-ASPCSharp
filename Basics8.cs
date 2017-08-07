//Switch Statement

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Switch{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num1 = 10;

   switch (num1){
    case 1:
     Label1.Text = "Seems it is number 1";
     break;
    case 5:
    case 10:
     Label1.Text = "Feels like it is five or 10";
     break;
   }
  }
 }
}
