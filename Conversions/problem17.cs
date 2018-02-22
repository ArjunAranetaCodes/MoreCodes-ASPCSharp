//Problem 17: Write a program that converts kilometer to meter.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem17
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int kilometer = 1;
            int meter = kilometer * 1000;

            Label1.Text = meter.ToString();
        }
    }
}