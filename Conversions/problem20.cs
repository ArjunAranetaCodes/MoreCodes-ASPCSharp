//Problem 20: Write a program that converts a number to its 
//corresponding month (e.g. 1 = January).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int index = 1;
            string[] month = {"January", "February", "March", "April",
    "May", "June", "July", "August",
    "September", "October", "November", "December"};

            Label1.Text = month[index - 1];
        }
    }
}