//Basics of Functions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Functions{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   function1();
   function2(5);
   Label3.Text = function3().ToString();
   Label4.Text = function4("More", "Codes");
  }

  //function that has no return value and
  //no passing argument/parameter
  void function1(){
   Label1.Text = "Hello there!";
  }

  //function that has no return value but
  //has passing argument/parameter
  void function2(int num){
   Label2.Text = "That number is " + num;
  }

  //function that has return value but has
  //no passing argument/parameter
  int function3(){
   int sum = 1 + 1;
   return sum;
  }

  //function that has return value and has
  //passing argument/parameter
  string function4(string firstName, string lastName){
   string fullName = firstName + " " + lastName;
   return fullName;
  }
 }
}
