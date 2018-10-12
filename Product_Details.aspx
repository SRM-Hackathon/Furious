<%@ Page Title="" Language="C#" MasterPageFile="~/Buy.master" AutoEventWireup="true" CodeFile="Product_Details.aspx.cs" Inherits="Product_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">

    <ul class="breadcrumb">
    <li><a href="index.html">Home</a> <span class="divider">/</span></li>
    <li><a href="products.html">Products</a> <span class="divider">/</span></li>
    <li class="active">product Details</li>
    </ul>	
                      <asp:Image ID="Image1" runat="server" Height="263px" Width="528px" />
                     
                    				
			 <asp:Label ID="Prod_Name" runat="server" Height="50px" Text="l" Width="333px" Font-Bold="true" Font-Italic="true" Font-Size ="Large"></asp:Label>
			
			    <asp:Label ID="Price" runat="server" Height="50px" Text="p" Width="155px" Font-Bold="true" Font-Italic="true" Font-Size ="Large"></asp:Label>
			    
			          <asp:Label ID="Content" runat="server" Text="" Height="100px" Width="500px"></asp:Label>
			
			    <table style="width: 54%; height: 144px;" id="Table1" hidden: true>
                    <tr>
                        <td style="height: 43px; width: 250px;">
                            <asp:Label ID="Label2" runat="server" Text="BRAND"></asp:Label>
                        </td>
                        <td style="height: 43px">
                            <asp:TextBox ID="Brand" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 250px; height: 66px;">
                            <asp:Label ID="Label3" runat="server" Text="MODEL"></asp:Label>
                        </td>
                        <td style="height: 66px">
                            <asp:TextBox ID="Model" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </table>
			
			
		
			
            
          
    &nbsp;<br />
        <br />
        <br />
        <h3>
                    &nbsp;</h3>
        <p>
                    &nbsp;</p>
        <p>
                    <asp:Label ID="lblTable" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="font-size: 14px; vertical-align: middle">
                    </p>
        <p>
                    &nbsp;</p>
				
			
			
				
			
            
          
    </form>

</asp:Content>

