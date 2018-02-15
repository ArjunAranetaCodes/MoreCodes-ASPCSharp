//Problem 11: Write a program that converts numbers of day to minutes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int day = 1;
            int minutes = day * 24 * 60;

            Label1.Text= minutes.ToString();
        }
    }
}