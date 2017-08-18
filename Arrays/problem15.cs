
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem15{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] array1 = { 1, 2, 3 };
   int[] array2;

   array2 = array1;

   foreach (int num in array2){
    Label1.Text = Label1.Text +
     num.ToString() + "<br/>";
   }
  }
 }
}

