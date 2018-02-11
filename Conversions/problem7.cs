//Problem 7: Write a program that converts a decimal number to binary number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   int dec = 10;
   string binary = "";

   while (dec > 0){
    binary = (dec % 2).ToString() + binary;
    dec = dec / 2;
   }
   Label1.Text = binary;

  }
 }
}