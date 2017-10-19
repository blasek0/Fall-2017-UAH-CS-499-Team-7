<%@ Page Language="C#" AutoEventWireup="true" CodeFile="agentMain.aspx.cs" Inherits="agentMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agent Main Page</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>


    <ul>
        <li><a class="active" href="#" > Home</a></li>
        <li><a href="insert_listing.aspx"> Add a listing</a></li>
        <li><a href="update_listing.aspx"> Update A listing</a></li>
        <li><a href="delete_listing.aspx"> Delete a listing</a></li>
        <li><a href="#"> <form id="form2" runat="server"><asp:Button ID="logoutButton" runat="server" OnClick="Button1_Click" Text="Logout" /></form></a></li>
    </ul>

    <h1> Welcome Agent</h1>
    <h2><a href="../users/display_houses.aspx"> View Listings </a></h2>



</body>
</html>
