using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = @"\w{5,10}\b";
            TextBox1.Text = Regex.IsMatch("Hello World", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("Hi", pattern).ToString();
        }
    }
}