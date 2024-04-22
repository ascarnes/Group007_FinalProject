/*
 # Name: Benjamin Ujvagi
# email: ujvagibw@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This is the C# code that takes two arrays of integers and finds the median of the two
# Citations: Microsoft Coplilot
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
    public partial class LeetCodeHard : System.Web.UI.Page
    {
        protected void btnSolve_Click(object sender, EventArgs e)
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };

            double median = FindMedianSortedArrays(nums1, nums2);

            // Update the label with the median value
            lblResult.Text = "Median is " + median.ToString("F5"); // Format to 5 decimal places
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double res = 0; // Initialize the result (will be accumulated in case)
            int i = 0; // Iteration number index (we won't merge arrays, because they're sorted; it'll iterate each of the arrays with the smaller value and increment i)
            int i1 = 0; // nums1 index (just to store the last index it iterated)
            int i2 = 0; // nums2 index (just to store the last index it iterated)

            int lenSum = nums1.Length + nums2.Length;
            int iM = (int)Math.Ceiling(lenSum / 2f) - 1; // Rounded Median Index (finding the median index by dividing the sum of lengths by 2 and subtracting 1 as we need the index, and indexes start from 0)
            int iMA = (lenSum % 2 == 0) ? 1 : 0; // Median Addition for the index in case it is even (so we should run one more iteration)

            while (i <= iM + iMA) // Running until our iterations count reaches Median Rounded Index + Median Rounded Index Addition
            {
                // Set up values if they exist; if not, write MaxValue, so it can go into the right if...else body
                int val1 = (i1 < nums1.Length) ? nums1[i1] : int.MaxValue;
                int val2 = (i2 < nums2.Length) ? nums2[i2] : int.MaxValue;

                if (val1 < val2)
                {
                    if (i >= iM)
                    {
                        res += val1;
                    }

                    i1++;
                }
                else
                {
                    if (i >= iM)
                    {
                        res += val2;
                    }

                    i2++;
                }

                i++;
            }

            if (iMA == 1) // If we added 1 more iteration, it means res has the sum of 2 values, so we need to divide it by 2
            {
                res /= 2;
            }

            return res;
        }


    }
}