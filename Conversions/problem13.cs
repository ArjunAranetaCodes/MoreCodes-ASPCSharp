//Problem 13: Write a program that converts celsius to farenheit.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double celsius = 10.0;
            double farenheit = 0.0;
            farenheit = (9.0 / 5.0) * celsius + 32;
            Label1.Text = celsius.ToString() + "C equals to " +
             farenheit.ToString() + "F";
        }
    }
}