/*
Problem 8: Write a program to print the number pattern of ones and zeros using loop.
11111
11111
11011
11111
11111
*/
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
            Label1.Text = "";
            int row = 5;
            int col = 5;
            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < col; x++)
                {
                    if (x == (row / 2) && y == (col / 2))
                    {
                        Label1.Text = Label1.Text + "0";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "1";
                    }
                }
                Label1.Text = Label1.Text + "<br/>";
            }
        }
    }
}