<!--
# Name: Thomas Dyer
# email:dyertm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This is the webfrom that create the interface for the interaction with my Leet code medium difficulty problem.
    It displays the problem title, description, one example, and the button which when pressed runs the code behind and gives the same solution.
# Citations: Microsoft co-pilot AI
# Anything else that's relevant:    
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeMedium.aspx.cs" Inherits="Group007_FinalProject.LeetCodeMedium" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Divide Two Integers</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Divide Two Integers</h1>
        <p>Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.</p>
        <p>The integer division should truncate toward zero, which means losing its fractional part. For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.</p>
        <p>Return the quotient after dividing dividend by divisor.</p>
        <p>Example 1:</p>
        <p>Input: dividend = 10, divisor = 3</p>
        <p>Output: 3</p>
        <p>Explanation: 10/3 = 3.33333.. which is truncated to 3.</p>
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>

