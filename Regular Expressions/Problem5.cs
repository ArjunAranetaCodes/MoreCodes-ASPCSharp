using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = "^(0?[1-9]|1[012])(:[0-5]\\d) [APap][mM]$";
            TextBox1.Text = Regex.IsMatch("25:00 am", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("08:01 am", pattern).ToString();
        }
    }
}