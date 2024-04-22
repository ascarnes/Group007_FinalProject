/*
# Name: Thomas Dyer
# email:dyertm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This is the class which I utilized to create the divide operation which is further utilized in the code
behind my Leet Code Medium class.
# Citations: Microsoft co-pilot AI
# Anything else that's relevant:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group007_FinalProject
{
    public partial class LeetCodeMedium
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            long dvd = Math.Abs((long)dividend);
            long dvs = Math.Abs((long)divisor);
            int result = 0;

            for (int bit = 31; bit >= 0; bit--)
            {
                if (dvd >= (dvs << bit))
                {
                    result += 1 << bit;
                    dvd -= dvs << bit;
                }
            }

            return (dividend > 0) == (divisor > 0) ? result : -result;
        }
    }
}