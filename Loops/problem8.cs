
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem8{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   String word = "program";
   String letter = "aeiou";
   int letterCount = 0;

   for (int i = 0; i < word.Length - 1; i++){
    if (letter.Contains(word.Substring(i, 1))){
     letterCount += 1;
    }
   }
   Label1.Text = "Total Vowels: " + letterCount.ToString();
  }
 }
}

