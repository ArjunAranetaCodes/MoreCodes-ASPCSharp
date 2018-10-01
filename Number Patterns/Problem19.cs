/*
Problem 19: Write a program to print the number pattern using loop.
11 11
11 11
   
11 11
11 11
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem19
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
                    if (col / 2 == x || row / 2 == y)
                    {
                        Label1.Text = Label1.Text + "&nbsp;&nbsp;";
                    }
                    else if ((col % 2 == 0 && (col / 2) == x) || (row % 2 == 0 && (row / 2) == y))
                    {
                        Label1.Text = Label1.Text + "&nbsp;&nbsp;";
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