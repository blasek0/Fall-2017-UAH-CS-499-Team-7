<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update_listing.aspx.cs" Inherits="agents_update_listing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agent Main Page</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>


    <ul>
        <li><a href="agentMain.aspx" > Home</a></li>
        <li><a href="insert_listing.aspx"> Add a listing</a></li>
        <li><a class="active" href="#"> Update A listing</a></li>
        <li><a href="delete_listing.aspx"> Delete a listing</a></li>
        <li><a href="#"> <form id="form2" runat="server"><asp:Button ID="logoutButton" runat="server" OnClick="Button1_Click" Text="Logout" /></form></a></li>
    </ul>

    <h1>Update Listing</h1>
</body>
</html>
