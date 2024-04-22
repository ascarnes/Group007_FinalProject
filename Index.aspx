<!--
# Name: Thomas Dyer
# email:dyertm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 4/23/2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This is the home page for our project where you can select which leet code problem you would like to view. 
# Citations: Microsoft co-pilot AI
# Anything else that's relevant:    
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Group007_FinalProject.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Group07_FinalProject</title>
</head>
<body>
    <h1>Group 07 LeetCode Solutions</h1> <!-- Add the header here -->
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLeetCodeEasy" runat="server" Text="LeetCodeEasy" OnClick="LeetCodeEasy_Click" />
        </div>
        <div>
            <asp:Button ID="btnLeetCodeMedium" runat="server" Text="LeetCodeMedium" OnClick="LeetCodeMedium_Click" />
        </div>
        <div>
            <asp:Button ID="btnLeetCodeHard" runat="server" Text="LeetCodeHard" OnClick="btnLeetCodeHard_Click" />
        </div>
    </form>
</body>
</html>
