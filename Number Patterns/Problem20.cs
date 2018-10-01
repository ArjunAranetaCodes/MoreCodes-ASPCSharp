/*
Problem 20: Write a program to print the number pattern using loop.
  1
 222
33333
 444
  5
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem20
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            int y = 0;
            int x = 0;
            int rows = 3;
            int stars = 1;
            int blank = rows - 1;

            for (y = 1; y < rows * 2; y++)
            {
                for (x = 1; x <= blank; x++)
                {
                    Label1.Text = Label1.Text + "&nbsp;&nbsp;";
                }

                for (x = 1; x < stars * 2; x++)
                {
                    Label1.Text = Label1.Text + "*";
                }

                Label1.Text = Label1.Text + "<br/>";

                if (y < rows)
                {
                    blank--;
                    stars++;
                }
                else
                {
                    blank++;
                    stars--;
                }
            }
        }
    }
}