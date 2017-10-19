<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert_listing.aspx.cs" Inherits="agents_insert_listing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agent Main Page</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    </head>
<body>
    <form id="f1" runat="server">

    <ul>
        <li><a href="agentMain.aspx" > Home</a></li>
        <li><a class="active" href="#"> Add a listing</a></li>
        <li><a href="update_listing.aspx"> Update A listing</a></li>
        <li><a href="delete_listing.aspx"> Delete a listing</a></li>
        <li><a href="#"><asp:Button ID="logoutButton" runat="server" OnClick="Button1_Click" Text="Logout" /></a></li>
    </ul>

    <h1>Insert Listing</h1>

    <table>
        <tr>
            <td>Picture</td>
            <td><asp:FileUpload ID="pic1" runat="server" /> </td>
            
        </tr>

         <tr>
            <td>Picture2</td>
            <td><asp:FileUpload ID="pic2" runat="server" /> </td>
        </tr>

         <tr>
            <td>Picture3</td>
            <td><asp:FileUpload ID="pic3" runat="server" /> </td>
        </tr>

         <tr>
            <td>Picture4</td>
            <td><asp:FileUpload ID="pic4" runat="server" /> </td>
        </tr>

        <tr>
            <td>Picture5</td>
            <td><asp:FileUpload ID="pic5" runat="server" /> </td>
        </tr>

        <tr>
            <td>Picture6</td>
            <td><asp:FileUpload ID="pic6" runat="server" /> </td>
        </tr>
     
         <tr>
            <td>Listing Price</td>
            <td><asp:TextBox ID="listing_price" runat="server"></asp:TextBox></td>
             <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="listing_price" runat="server" ErrorMessage="only numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator></td>
         </tr> 

        <tr>
            <td>Listing Street</td>
            <td><asp:TextBox ID="listing_street" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Listing State</td>
            <td><asp:TextBox ID="listing_state" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Listing City</td>
            <td><asp:TextBox ID="listing_city" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Listing Zip</td>
            <td><asp:TextBox ID="listing_zip" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Listing Square Feet</td>
            <td><asp:TextBox ID="listing_sqFT" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Listing Description</td>
            <td><asp:TextBox ID="listing_description" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Room Description</td>
            <td><asp:TextBox ID="listing_roomDescription" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Short Description</td>
            <td><asp:TextBox ID="listing_shortDescription" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Subdivision</td>
            <td><asp:TextBox ID="listing_nameSubDivision" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Alarm Info</td>
            <td><asp:TextBox ID="listing_alarmInfo" runat="server"></asp:TextBox></td>
         </tr> 
        <tr>
            <td>Listing Occupied</td>
            <td><asp:TextBox ID="listing_occupied" runat="server"></asp:TextBox></td>
         </tr> 
        

        <tr>
            <td colspan="2" align="center">
            <asp:Button ID="b1" runat="server" Text="upload" OnClick="b1_Click" />
            </td>
        </tr>
    </table>
    

</form>
</body>
</html>
