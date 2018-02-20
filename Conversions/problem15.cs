//Problem 15: Write a program that converts letters to ASCII.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Problem15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string letter = "x"; //120
            byte[] ascii = Encoding.ASCII.GetBytes(letter);

            Label1.Text = ascii[0].ToString();

        }
    }
}