/*
# Name: Thomas Dyer
# email:dyertm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This is the code behind the aspx which makes our buttons rediredct to the proper web forms upon click. 
# Citations: Microsoft co-pilot AI
# Anything else that's relevant:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group007_FinalProject
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LeetCodeEasy_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeEasy.aspx");
        }

        protected void LeetCodeMedium_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeMedium.aspx");
        }

        protected void btnLeetCodeHard_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeetCodeHard.aspx");
        }
    }
}