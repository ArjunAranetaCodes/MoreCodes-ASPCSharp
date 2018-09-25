using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string word = "HelloWorldHelloWorld";
            string pattern = @"Hello";
            int count = Regex.Matches(word, pattern).Count;
            TextBox1.Text = count.ToString();
        }
    }
}