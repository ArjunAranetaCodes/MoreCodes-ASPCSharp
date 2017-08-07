
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem11{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num = 3333;
   int sum = 0;
   int temp = 0;
   int rmdr = 0;

   temp = num;

   while (temp != 0){
    rmdr = temp % 10;
    sum = sum * 10 + rmdr;
    temp = temp / 10;
   }

   if (num == sum){
    Label1.Text = "Palindrome number";
   }else{
    Label1.Text = "Not a Palindrome number";
   }
  }
 }
}

