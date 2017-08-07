
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem14{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   int sum = 0;
   int ave = 0;

   sum = sum + Int32.Parse(TextBox1.Text);
   sum = sum + Int32.Parse(TextBox2.Text);
   sum = sum + Int32.Parse(TextBox3.Text);
   sum = sum + Int32.Parse(TextBox4.Text);
   sum = sum + Int32.Parse(TextBox5.Text);
   ave = sum / 5;
   Label1.Text = "Average is " + ave.ToString();

  }
 }
}

