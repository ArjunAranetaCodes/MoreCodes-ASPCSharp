//If, ElseIf, and Else Structure

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IfElse{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int num1 = 1, num2 = 2;

   //if statement
   if (num1 > num2){
    Label1.Text = "First number is higher!";
   }

   //if-else statement
   if (num1 == num2){
    Label2.Text = "They are equal!";
   }else{
    Label2.Text = "They are not equal!";
   }

   //if-else if statement
   if (num1 > num2){
   Label3.Text = "First number is greater!";
   }else if (num1 < num2){
    Label3.Text = "Second number is greater!";
   }
  }
 }
}
