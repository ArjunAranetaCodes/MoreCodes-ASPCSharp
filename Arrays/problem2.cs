
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem2{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int[] arrNumers = { 1, 2, 3 };

   Label1.Text = Array.IndexOf(arrNumers, 2).ToString();
  }
 }
}

