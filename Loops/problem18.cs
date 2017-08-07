
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem18{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){

   for (int x = 0; x <= 11; x++){
    Label1.Text = Label1.Text +
    Fibonacci(x).ToString() + "&lt;br/>";
   }
  }

  static int Fibonacci(int num){
   if ((num == 1) || (num == 0)){
    return num;
   }else{
    return Fibonacci(num - 1) + Fibonacci(num - 2);
   }
  }
 }
}

