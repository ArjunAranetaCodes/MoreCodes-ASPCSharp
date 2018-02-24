//Problem 18: Write a program that converts liter to milliliter.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem18
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int liter = 1;
            int milliliter = liter * 1000;

            Label1.Text = milliliter.ToString();

        }
    }
}