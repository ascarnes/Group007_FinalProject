using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group007_FinalProject
{
    public partial class LeetCodeMedium : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Group007_FinalProject.LeetCodeMedium leetCodeMedium = new Group007_FinalProject.LeetCodeMedium();
            int result = leetCodeMedium.Divide(10, 3);
            Label1.Text = "Result: " + result.ToString();
        }
    }
}
