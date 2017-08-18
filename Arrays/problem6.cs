
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem6{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] arrNumbers = { 1, 2, 3 };

   if (arrNumbers.Contains(2)){
    Label1.Text = "Contains 2";
   }else{
    Label1.Text = "Does not contain 2";
   }
  }
 }
}

