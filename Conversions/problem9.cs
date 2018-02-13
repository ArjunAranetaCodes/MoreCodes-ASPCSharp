//Problem 9: Write a program that converys a hexadecimal number to decimal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dec = 0;
            string hex = "100";

            char[] temp = hex.ToCharArray();
            Array.Reverse(temp);
            hex = new string(temp);

            for (int x = 0; x < hex.Length; x++)
            {
                dec = dec + (Convert.ToInt32(hex[x].ToString()) *
                Convert.ToInt32(Math.Pow(16, x)));
            }

            Label1.Text = dec.ToString();
        }
    }
}