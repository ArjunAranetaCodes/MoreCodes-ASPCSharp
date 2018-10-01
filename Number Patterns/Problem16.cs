/*
Problem 16: Write a program to print the number pattern using loop.
12345
1234
123
12
1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            int row = 5;
            for (int y = row; y > 0; y--)
            {
                for (int x = 0; x < y; x++)
                {
                    Label1.Text = Label1.Text + (x + 1).ToString();
                }
                Label1.Text = Label1.Text + "<br/>";
            }
        }
    }
}