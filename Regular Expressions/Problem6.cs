using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string word = "Hello World";
            string pattern = "\\s";
            TextBox1.Text = Regex.Replace(word, pattern, "").ToString();
        }
    }
}