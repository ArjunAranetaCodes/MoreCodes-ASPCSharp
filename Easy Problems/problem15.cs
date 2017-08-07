
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Web;
 using System.Web.UI;
 using System.Web.UI.WebControls;

 namespace Problem15{
  public partial class WebForm1 : System.Web.UI.Page{
   protected void Page_Load(object sender, EventArgs e){
    String word = "programming";
    String strSearch = "program";
    if (word.Contains(strSearch)){
     Label1.Text = strSearch + " found";
    }
    else{
     Label1.Text = strSearch + " not found";
    }
   }
  }
 }

