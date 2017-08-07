//Array Basics

 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Web;
 using System.Web.UI;
 using System.Web.UI.WebControls;

 namespace Arrays{
  public partial class WebForm1 : System.Web.UI.Page{
   protected void Page_Load(object sender, EventArgs e){
    int[] array = new int[] { 1, 2, 3 };
    Label1.Text = array[0].ToString();
    Label2.Text = array[1].ToString();
    Label3.Text = array[2].ToString();
   }
  }
 }
