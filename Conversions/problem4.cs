//Problem 4: Write a program that converts a string to array/list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string numbers = "1,2,3";
            string[] arrNumbers = numbers.Split(',');
            foreach (string num in arrNumbers)
            {
                Label1.Text = Label1.Text + num;
            }
        }
    }
}