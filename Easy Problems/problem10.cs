
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem10{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   int num1 = Int32.Parse(TextBox1.Text);
   int num2 = Int32.Parse(TextBox2.Text);
   int num3 = Int32.Parse(TextBox3.Text);
   int ave = (num1 + num2 + num3) / 3;
   Label1.Text = "Average is " + ave.ToString();
  }
 }
}

