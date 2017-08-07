
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem20{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   String word = "anna";
   char[] temp = word.ToCharArray();
   Array.Reverse(temp);
   String tempWord = new string(temp);

   if (word == tempWord){
    Label1.Text = "Palindrome";
   }else{
    Label1.Text = "Not Palindrome";
   }
  }
 }
}

