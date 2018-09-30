/*
Problem 14: Write a program to print the number pattern using loop.
1
22
333
4444
55555
*/
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
            Label1.Text = "";
            int row = 5;
            for (int y = 0; y <= row; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Label1.Text = Label1.Text + y.ToString();
                }
                Label1.Text = Label1.Text + "<br/>";
            }
        }
    }
}