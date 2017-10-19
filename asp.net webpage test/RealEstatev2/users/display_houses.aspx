<%@ Page Language="C#" AutoEventWireup="true" CodeFile="display_houses.aspx.cs" Inherits="users_display_houses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="display_listing.css" type="text/css" media="all" />
  
</head>
<body>
 <form id="f1" runat="server">
    <!-- This is the unordered list that will allow users to login if they wish to. Css is in the display_listing.css file -->
     <ul>
         <ul>
             <asp:TextBox ID="listing_price" runat="server"></asp:TextBox>
         </ul>
        <li><a href="../agents/login.aspx">Agent? Log In</a></li>   
    </ul>
    <!-- This is the end of the unordered list (the bar at the top -->

    <!-- This is the beginning of where the products are displayed. It is called products and linked to a styling element in display_listing.css -->
    <div class="products">

    <!-- Repeater is a container that allows you to create custom lists out of any data that is available on the page  --> 
    <!-- This is what will allow us to post all houses in the database without wasting space-->
    
    <!-- Right now the repeater is only pulling from listing table. It also needs to display from the 
         agent, and agency table as well. To do this I will need to implement some type of join in the cs portion of this code
       
    -->
    
    <asp:Repeater ID="d1" runat="server"> 
        
        

        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        
        <ItemTemplate>
            <li class="last">
                <a href="detailed_display.aspx?id=<%#Eval("listing_id") %>"><img src='data:image/jpg;base64,<%#Eval("pic1") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("pic1")) : string.Empty %>' alt="pic1" height="300" width="300" /></a>
                <div class="product-info">
                    <h3>$<%#Eval("listing_price") %></h3>
                    <div class="product-desc">
                        <h4><%#Eval("listing_street") %></h4>
                       
                        <p><%#Eval("listing_city") %> , <%#Eval("listing_state") %>, <%#Eval("listing_zip") %></p>
                        <p><%#Eval("agency_name") %></p>
                        <p><%#Eval("listing_zip") %></p>"
                        </div>
                    </div>
                </li>


        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
    <!-- Repeater ends here-->
    </div>
    <!-- Product div ends here -->

     </form>
</body>
</html>
