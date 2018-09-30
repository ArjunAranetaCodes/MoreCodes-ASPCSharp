/*
Problem 15: Write a program to print the number pattern using loop.
11111
2222
333
44
5
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            int row = 5;
            int num = 1;
            for (int y = row; y > 0; y--)
            {
                for (int x = 0; x < y; x++)
                {
                    Label1.Text = Label1.Text + num.ToString();
                }
                num = num + 1;
                Label1.Text = Label1.Text + "<br/>";
            }
        }
    }
}