//Problem 6: Write a program that converts a binary number to decimal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dec = 0;
            string binary = "110";

            char[] temp = binary.ToCharArray();
            Array.Reverse(temp);
            binary = new string(temp);

            for (int x = 0; x < binary.Length; x++)
            {
                if (binary[x] == '1')
                {
                    dec = dec + Convert.ToInt32(Math.Pow(2, x));
                }
            }

            Label1.Text = dec.ToString();

        }
    }
}