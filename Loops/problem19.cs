
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem19{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   PrintEven(10);
  }

  int PrintEven(int num){
   if (num == 0){
    return num;
   }else{
    if (num % 2 == 0){
     Label1.Text = Label1.Text + num.ToString() + "<br/>";
    }
    return PrintEven(num - 1);
   }
  }
 }
}

