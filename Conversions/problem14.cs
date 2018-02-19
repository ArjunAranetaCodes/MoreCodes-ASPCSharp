//Problem 14: Write a program that converts lower case to upper case characters.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem14
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "abc";
            str = str.ToUpper();

            Label1.Text = str;
        }
    }
}