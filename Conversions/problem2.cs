//Problem 2: Write a program that converts a string to integer.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string num = "10";
            Label1.Text = Int32.Parse(num).ToString();
        }
    }
}