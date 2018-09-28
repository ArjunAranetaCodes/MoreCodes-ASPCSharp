/*
Problem 4: Write a program to print the number pattern of ones and zeros using loop.
10001
10001
10001
10001
10001
*/
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
            Label1.Text = "";
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if ((x == 0) || (x == 4))
                    {
                        Label1.Text = Label1.Text + "1";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "0";
                    }
                }
                Label1.Text = Label1.Text + "<br/>";
            }
        }
    }
}