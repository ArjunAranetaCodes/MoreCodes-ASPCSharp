
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem3{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] arrNumbers = { 1, 1, 2, 3 };
   int count = 0;

   foreach (int num in arrNumbers){
    if (num == 1){
     count = count + 1;
    }
   }

   Label1.Text = "Occurence: " + count.ToString();
  }
 }
}

