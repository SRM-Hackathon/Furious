<%@ Page Title="" Language="C#" MasterPageFile="~/Display1.Master" AutoEventWireup="true" CodeFile="Db_Retailer.aspx.cs" Inherits="Db_Retailer" %>


<script runat="Server">

    
</script>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1> DataBase Access</h1>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <h4> Category</h4>
            </td>
            <td class="auto-style2">
               
            </td>
            <td class="auto-style2">
                 <asp:DropDownList ID="Category" runat="server" OnSelectedIndexChanged="Category_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>

            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;
               <h4>
                   Product Name
               </h4> 
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:DropDownList ID="ProdName" runat="server" AutoPostBack="True" ></asp:DropDownList>

            </td>
            <td>&nbsp;</td>
        </tr>
       
        <tr>
            <td class="auto-style4">

               <h4> Unit Price</h4>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;
                  <asp:TextBox ID="UnitPrice" runat="server" CausesValidation="True" ValidationGroup="1"></asp:TextBox>
                
                </td>
          
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;
                <h4>
                     Units in Stock
                </h4>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp; 
                <asp:TextBox ID="UnitinStock" runat="server"></asp:TextBox>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;  <h4>Discount</h4></td>
            <td>&nbsp;</td>
            <td>&nbsp;
                <asp:TextBox ID="Disc" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>  

            <td class="auto-style4">&nbsp;   <h4> Expected Delivery (in Stock)</h4></td>
            <td>&nbsp;</td>
            <td>&nbsp;  

                <asp:TextBox ID="ExpectDelS" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;

               <h4>Expected Delivery (Not in Stock)</h4> 
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;
                <asp:TextBox ID="ExpectDelNS" runat="server"></asp:TextBox>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>

            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" Text="Upload Product Image"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" Width="266px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>
   
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            height: 22px;
            width: 287px;
        }
        .auto-style4 {
            width: 287px;
        }
    </style>
</asp:Content>


