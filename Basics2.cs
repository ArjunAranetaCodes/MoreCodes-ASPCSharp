//Basic Variable Implementations

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Variables{
 public partial class WebForm1 : System.Web.UI.Page{
  protected void Page_Load(object sender, EventArgs e){
   String name = "Mark";
   Char sex = 'M';
   int age = 21;

   Label1.Text = name;
   Label2.Text = sex.ToString();
   Label3.Text = age.ToString();
  }
 }
}
