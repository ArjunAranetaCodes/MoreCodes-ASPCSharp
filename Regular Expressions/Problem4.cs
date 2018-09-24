using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = "(((0[1-9])|(1[0-2])):([0-5])([0-9])\\s(a|p)m)";
            TextBox1.Text = Regex.IsMatch("08:00 am", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("18:00 pm", pattern).ToString();
        }
    }
}