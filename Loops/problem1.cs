
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Problem1{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   for (int x = 1; x <= 50; x++){
    if ((x % 3 == 0) && (x % 5 == 0)){
     Label1.Text = Label1.Text + "FizzBuzz" + "&lt;br/>";
    }else if (x % 3 == 0){
     Label1.Text = Label1.Text + "Fizz" + "&lt;br/>";
    }else if (x % 5 == 0){
     Label1.Text = Label1.Text + "Buzz" + "&lt;br/>";
    }else{
     Label1.Text = Label1.Text + x.ToString() + "&lt;br/>";
    }
   }
  }
 }
}

