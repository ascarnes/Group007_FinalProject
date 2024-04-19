<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeEasy.aspx.cs" Inherits="Group007_FinalProject.LeetCodeEasy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem Description</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Two Sum</h1>
            <p>
                Given an array of integers <strong>nums</strong> and an integer <strong>target</strong>, return indices of the two numbers such that they add up to <strong>target</strong>.
                You may assume that each input would have exactly one solution, and you may not use the same element twice.
                You can return the answer in any order.
            </p>
            <p>
                <strong>Example 1:</strong>
                <br />
                Input: nums = [2,7,11,15], target = 9
                <br />
                Output: [0,1]
                <br />
                Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            </p>
            <asp:Button ID="btnRunSolution" runat="server" Text="Run Solution" OnClick="btnRunSolution_Click" />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

