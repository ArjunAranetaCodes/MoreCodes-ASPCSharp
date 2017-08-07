//Basic Operations

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arithmetic{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   Label1.Text = "1 + 1 = " + (1 + 1);
   Label2.Text = "1 - 1 = " + (1 - 1);
   Label3.Text = "1 * 1 = " + (1 * 1);
   Label4.Text = "1 / 1 = " + (1 / 1);
   Label5.Text = "4 % 2 = " + (4 % 2) + " - no remainder";
   Label6.Text = "5 % 2 = " + (5 % 2) + " - remainder 1";
  }
 }
}
