//Variables and Input

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicInput{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Button1_Click(object sender, EventArgs e){
   String name = "";
   Char sex = '-';
   int age = 0;

   name = TextBox1.Text;
   sex = Convert.ToChar(TextBox2.Text);
   age = Convert.ToInt32(TextBox3.Text);

   Label1.Text = name;
   Label2.Text = sex.ToString();
   Label3.Text = age.ToString();
  }
 }
}
