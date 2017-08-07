
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Web;
 using System.Web.UI;
 using System.Web.UI.WebControls;

 namespace Problem14{
  public partial class WebForm1 : System.Web.UI.Page{
   protected void Page_Load(object sender, EventArgs e){
    String word = "program";
    String newWord = word.Replace("a", "e");
    Label1.Text = word;
   }
  }
 }

