<!--
 # Name: Benjamin Ujvagi
# email: ujvagibw@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This creates the web interface that allows the user to see the LeetCode problem and then click the button to find the solution to it. 
# Citations: Microsoft Coplilot
# Anything else that's relevant:
 -->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeHard.aspx.cs" Inherits="Group007_FinalProject.LeetCodeHard" %>

<!DOCTYPE html>

<html>
<head>
    <title>Median Solver</title>
</head>
<body>
    <h1>Problem Description</h1>
    <p>Given two sorted arrays <code>nums1</code> and <code>nums2</code> of size <code>m</code> and <code>n</code> respectively, return the median of the two sorted arrays.</p>
    <p>The overall run time complexity should be <code>O(log (m+n))</code>.</p>
    <h2>Example 1:</h2>
    <p>Input: <code>nums1 = [1,3]</code>, <code>nums2 = [2,4]</code></p>

    <form runat="server">
        <asp:Button ID="btnSolve" runat="server" Text="Solve Example Problem" OnClick="btnSolve_Click" />
         <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
