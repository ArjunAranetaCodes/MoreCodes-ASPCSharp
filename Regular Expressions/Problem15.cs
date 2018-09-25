﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Problem15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string word = "<div>Hello World</div>";
            string pattern = @"<([^""]*""|'[^']*'|[^'"">])*>";
            TextBox1.Text = Regex.Replace(word, pattern, "").ToString();
        }
    }
}