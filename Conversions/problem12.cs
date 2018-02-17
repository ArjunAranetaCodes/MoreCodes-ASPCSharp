//Problem 12: Write a program that converts numbers of day to seconds.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int day = 1;
            int seconds = day * 24 * 60 * 60;

            Label1.Text = seconds.ToString();

        }
    }
}