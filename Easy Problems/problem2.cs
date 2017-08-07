
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem2{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   int num1 = Convert.ToInt32(TextBox1.Text);
   int num2 = Convert.ToInt32(TextBox2.Text);
   int sum = num1 + num2;
   int diff = num1 - num2;
   int prod = num1 * num2;
   int quot = num1 / num2;

   Label1.Text = "Sum is " + sum.ToString();
   Label2.Text = "Difference is " + diff.ToString();
   Label3.Text = "Product is " + prod.ToString();
   Label4.Text = "Quotient is " + quot.ToString();
 }
 }
}

