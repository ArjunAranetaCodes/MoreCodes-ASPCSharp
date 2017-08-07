
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem20{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   Label1.Text = "Sum is " + GetSum(10, 0);
  }

  int GetSum(int num, int sum){
   if (num == 0){
    return sum;
   }else{
    return GetSum((num - 1), (sum + num));
   }
  }
 }
}

