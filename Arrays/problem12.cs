
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem12{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] array1 = { 1, 2, 3 };
   int[] array2 = { 1, 2, 3 };

   if (array1.SequenceEqual(array2)){
    Label1.Text = "Equal Arrays";
   }else{
    Label1.Text = "Not Equal";
   }
  }
 }
}

