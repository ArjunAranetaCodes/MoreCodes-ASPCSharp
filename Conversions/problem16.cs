//Problem 16: Write a program that converts feet to inch.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int feet = 1;
            int inch = feet * 12;

            Label1.Text = inch.ToString();
        }
    }
}