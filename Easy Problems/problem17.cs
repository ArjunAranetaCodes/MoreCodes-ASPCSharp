
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem17{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   String word = "program";
   String letter = "a";

   if (word.Contains(letter)){
    Label1.Text = "Contains a";
   }else{
    Label1.Text = "Does not contain a";
   }

  }
 }
}

