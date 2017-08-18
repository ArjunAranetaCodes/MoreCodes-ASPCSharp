
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem17{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] arrNumbers = { 1, 2, 3 };

   foreach (int num in arrNumbers){
    Label1.Text = Label1.Text + num.ToString() + "<br/>";
   }

   Array.Resize(ref arrNumbers, arrNumbers.Length + 1);
   arrNumbers[3] = 5;

   Label1.Text = Label1.Text + "<br/>New Array<br/>";

   foreach (int num in arrNumbers){
    Label1.Text = Label1.Text + num.ToString() + "<br/>";
   }
  }
 }
}

