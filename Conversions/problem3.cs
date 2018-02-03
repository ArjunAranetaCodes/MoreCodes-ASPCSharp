//Problem 3: Write a program that converts an integer to float.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int num = 10;
            Label1.Text = Convert.ToDouble(num).ToString();
        }
    }
}