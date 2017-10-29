<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detailed_display.aspx.cs" Inherits="users_detailed_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="detailed_display.css" type="text/css" media="all" />
</head>
<body>
    <form id="form1" runat="server">
        

         
     <!-- This is the unordered list that will allow users to login if they wish to. Css is in the display_listing.css file -->
     <div class="navBar">
     <ul>
         
        <li><a id="login" href="../agents/login.aspx">Agent? Log In</a></li>  
        <li><a id="listings" href="display_houses.aspx">Back To Listings</a></li>
    </ul>
    </div>
    <!-- This is the end of the unordered list (the bar at the top -->
        
        
        <div>

        <asp:Repeater ID="d1" runat="server"> 
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate> 
            
            <div style="height:300px; width:100%">

            <div style="height:300px; width:200px; float:left; margin-top: 100px">
                <a href="product_desc.aspx?id=<%#Eval("listing_id") %>"><img src='data:image/jpg;base64,<%#Eval("pic1") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("pic1")) : string.Empty %>' alt="pic1" height="300" width="300" /></a>
              
            </div>


            <div style="height:300px; width:395px; float:right;  margin-top:100px">
                item name=<%#Eval("listing_price") %> <br />
                product_desc=<%#Eval("listing_description") %> <br />
                product price=<%#Eval("listing_street") %> <br />
                product quantity =<%#Eval("listing_zip") %> <br />
            </div>


            </div>

        </ItemTemplate>
        <FooterTemplate>            
        </FooterTemplate>
    </asp:Repeater>


        </div>
    </form>
</body>
</html>
