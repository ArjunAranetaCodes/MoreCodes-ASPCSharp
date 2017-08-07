//Loop Structures

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loops{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int x = 0;
   Label1.Text = "For Loop";
   for (x = 0; x <= 10; x++){
    Label2.Text = Label2.Text + x.ToString();
   }

   Label3.Text = "While Loop";
   x = 0;
   while (x <= 10){
    Label4.Text = Label4.Text + x.ToString();
    x++;
   }

   Label5.Text = "Do Loop";
   x = 0;
   do{
    Label6.Text = Label6.Text + x.ToString();
    x++;
   } while (x <= 10);
  }
 }
}
