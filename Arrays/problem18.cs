
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem18{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] arrNumbers = { 1, 3, 2, 4 };
   Array.Sort(arrNumbers);
   Array.Reverse(arrNumbers);

   foreach (int num in arrNumbers){
    Label1.Text = Label1.Text + num.ToString() + "<br/>";
   }
  }
 }
}

