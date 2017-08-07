
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem10{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num = 371;
   int sum = 0;
   int temp = 0;
   int rmdr = 0;

   temp = num;

   while (temp != 0){
    rmdr = temp % 10;
    sum = sum + (rmdr * rmdr * rmdr);
    temp = temp / 10;
   }

   if (num == sum){
    Label1.Text  = "Armstrong number";
   }else{
    Label1.Text = "Not an Armstrong number";
   }
  }
 }
}

