/*
# Name: Thomas Dyer
# email:dyertm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This is the code behind my web page which specifies what happens when the button is pressed. It calls the divide class and gives the answer to our example. 
# Citations: Microsoft co-pilot AI
# Anything else that's relevant:
 */
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
