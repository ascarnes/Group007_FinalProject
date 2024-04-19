using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group007_FinalProject
{
    public partial class LeetCodeEasy : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // You can add any initialization logic here if needed
        }

        protected void btnRunSolution_Click(object sender, EventArgs e)
        {
            // Example input: nums = [2, 7, 11, 15], target = 9
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Call your TwoSum method
            int[] result = TwoSum(nums, target);

            // Display the result (you can customize this part as needed)
            if (result.Length == 2)
            {
                lblResult.Text = $"Output: [{result[0]}, {result[1]}]";
            }
            else
            {
                lblResult.Text = "No valid answer found.";
            }
        }

        // Your provided TwoSum method
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numToIndex.ContainsKey(complement))
                {
                    return new int[] { numToIndex[complement], i };
                }

                numToIndex[nums[i]] = i;
            }

            return new int[0];
        }
    }
}