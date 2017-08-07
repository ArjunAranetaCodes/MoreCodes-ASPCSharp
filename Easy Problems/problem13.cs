
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Web;
 using System.Web.UI;
 using System.Web.UI.WebControls;

 namespace Problem13{
  public partial class WebForm1 : System.Web.UI.Page{
   protected void Page_Load(object sender, EventArgs e){
    String word = "MoreCodes";
    int strLength = word.Length;
    Label1.Text = "String Length: " + strLength.ToString();
   }
  }
 }

