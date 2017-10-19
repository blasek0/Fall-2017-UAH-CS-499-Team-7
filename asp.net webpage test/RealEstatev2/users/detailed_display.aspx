<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detailed_display.aspx.cs" Inherits="users_detailed_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
     <ul>
        <li><a class="active" href="#" > Home</a></li>
        
    </ul>
        
        
        
        <div>

        <asp:Repeater ID="d1" runat="server"> 
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate> 
            
            <div style="height:300px; width:600px; border-style:solid; border-width:1px;">

            <div style="height:300px; width:200px; float:left; border-style:solid; border-width:1px;">
                <a href="product_desc.aspx?id=<%#Eval("listing_id") %>"><img src='data:image/jpg;base64,<%#Eval("pic1") != System.DBNull.Value ? Convert.ToBase64String((byte[])Eval("pic1")) : string.Empty %>' alt="pic1" height="300" width="300" /></a>
              
            </div>


            <div style="height:300px; width:395px; float:left; border-style:solid; border-width:1px;;">
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
