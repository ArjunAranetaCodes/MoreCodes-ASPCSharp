using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = @"(([A-Z].*[0-9])|([0-9].*[A-Z]))";
            TextBox1.Text = Regex.IsMatch("HelloWorld", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("HelloWorld123", pattern).ToString();
        }
    }
}