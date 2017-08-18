
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem16{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] arrNumbers = { 1, 2, 3, 4 };
   int n = 2;
   int indexOfNum = Array.IndexOf(arrNumbers, n);

   for (int x = 0; x < arrNumbers.Length; x++){
    if ((x >= indexOfNum) && (x < arrNumbers.Length - 1)){
     arrNumbers[x] = arrNumbers[x + 1];
    }
   }
   Array.Resize(ref arrNumbers, arrNumbers.Length - 1);

   foreach (int num in arrNumbers){
    Label1.Text = Label1.Text + num.ToString() + "<br/>";
   }
  }
 }
}

