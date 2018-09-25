using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem19
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string word = "Hello World123";
            string pattern = @"[^0-9]";
            int count = Regex.Replace(word, pattern, "").Count();
            TextBox1.Text = count.ToString();
        }
    }
}