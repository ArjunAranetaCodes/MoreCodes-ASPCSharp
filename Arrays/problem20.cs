<pre><code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem20{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] arrNumbers = { 4, 2, 3, -1 };
   int closest = 0;
   int numDiff = arrNumbers.Max();

   foreach (int num in arrNumbers){
    int diff = 0 - num;
    diff = Math.Abs(diff);
    if (diff < numDiff){
     numDiff = diff;
     closest = num;
    }
   }

   Label1.Text = "Closest to zero is " +
    closest.ToString();
  }
 }
}
</code></pre>
