//Problem 5: Write a program that converts an array/list to string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem5
{
 public partial class WebForm1 : System.Web.UI.Page
 {
  protected void Page_Load(object sender, EventArgs e)
  { 
   string[] arrNumbers = { "1", "2", "3" }; 
   string numbers = string.Join("", arrNumbers);

   Label1.Text = numbers;
  }
 }
}