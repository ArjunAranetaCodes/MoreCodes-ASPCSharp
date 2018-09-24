//Problem 1: Write a program to test if the first character of the String is uppercase.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = "^[A-Z][a-z0-9_-]{3,19}$";
            TextBox1.Text = Regex.IsMatch("Hello", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("world", pattern).ToString();
        }
    }
}