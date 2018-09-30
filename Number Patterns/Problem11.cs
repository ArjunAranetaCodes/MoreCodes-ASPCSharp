/*
Problem 11: Write a program to print the pattern of asterisks using loop.
*
**
***
****
*****
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem11
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
                    Label1.Text = Label1.Text + "*";
                }
                Label1.Text = Label1.Text + "<br/>";
            }
        }
    }
}