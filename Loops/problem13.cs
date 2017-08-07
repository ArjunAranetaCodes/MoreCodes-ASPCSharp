
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem13{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
  string word = "MoreCodes";
  string newWord = "";

  for (int x = word.Length - 1; x >= 0; x--){
   newWord = newWord + word.Substring(x, 1);
  }
  Label1.Text  = newWord;
  }
 }
}

