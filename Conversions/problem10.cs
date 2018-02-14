//Problem 10: Write a program that converts a decimal number to octal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dec = 256;
            string oct = "";

            while (dec > 0)
            {
                oct = (dec % 8).ToString() + oct;
                dec = dec / 8;
            }
            Label1.Text = oct.ToString();
        }
    }
}