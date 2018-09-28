/*
Problem 10: Write a program to print the number pattern using loop.
12345
23456
34567
45678
56789
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            int row = 5;
            int col = 5;
            int min = 1;
            for (int y = 0; y < row; y++)
            {
                int num = min + y;
                for (int x = 0; x < col; x++)
                {
                    Label1.Text = Label1.Text + num.ToString();
                    num = num + 1;
                }
                Label1.Text = Label1.Text + "<br/>";
            }
        }
    }
}