using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string word = "Hello12 World12";
            string pattern = @"\D";
            TextBox1.Text = Regex.Replace(word, pattern, "").Count().ToString();
        }
    }
}