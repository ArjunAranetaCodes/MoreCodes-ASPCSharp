﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string word = "Hello World";
            string pattern = "[^aeiouAEIOU]";
            int count = Regex.Replace(word, pattern, "").Count();
            TextBox1.Text = count.ToString();
        }
    }
}