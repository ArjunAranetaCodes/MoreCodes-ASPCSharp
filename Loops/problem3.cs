
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem3{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   string word = "MoreCodes";
   int count = 0;

   foreach (char element in word){
    count = count + 1;
   }

   Label1.Text = "String Length: " + count.ToString();
  }
 }
}

