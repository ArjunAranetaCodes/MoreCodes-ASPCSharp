
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Web;
 using System.Web.UI;
 using System.Web.UI.WebControls;

 namespace Problem11{
  public partial class WebForm1 : System.Web.UI.Page{
   protected void Page_Load(object sender, EventArgs e){
    String word1 = "More";
    String word2 = "Codes";
    String newWord = word1 + word2;

    Label1.Text = newWord;

   }
  }
 }

