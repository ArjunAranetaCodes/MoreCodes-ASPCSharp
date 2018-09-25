using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
            TextBox1.Text = Regex.IsMatch("#fff", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("#asdf", pattern).ToString();
        }
    }
}