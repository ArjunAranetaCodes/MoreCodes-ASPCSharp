//Problem 8: Write a program that converts a decimal number to hexadecimal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dec = 256;
            string hex = "";

            while (dec > 0)
            {
                hex = (dec % 16).ToString() + hex;
                dec = dec / 16;
            }
            Label1.Text = hex;

        }
    }
}