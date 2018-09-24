using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string pattern = @"^(https?:\/\/)?(www\.)?([\w]+\.)+[‌​\w]{2,63}\/?$";
            TextBox1.Text = Regex.IsMatch("http://www.example.com", pattern).ToString();
            TextBox2.Text = Regex.IsMatch("wwwexamplecom", pattern).ToString();
        }
    }
}