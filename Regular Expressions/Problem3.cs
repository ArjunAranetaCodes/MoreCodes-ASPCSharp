using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = "([0-9]{4})-([0-9]{2})-([0-9]{2})";
            TextBox1.Text = Regex.IsMatch("2018-01-02", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("01-01-02", pattern).ToString();
        }
    }
}