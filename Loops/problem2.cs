
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem2{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   Random rand = new Random();
   for (int x = 0; x < 5; x++){
    Label1.Text = Label1.Text +
     rand.Next(1, 9).ToString() + "<br/>";
   }
  }
 }
}

