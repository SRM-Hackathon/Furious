<%@ Page Title="" Language="C#" MasterPageFile="~/Display1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="JustDealiT1.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>
                <td>
    <h1> Register As </h1>
                    <p> &nbsp;</p>
                    <p> &nbsp;</p>
                    </td>
                <td></td><td></td><td class="auto-style2">&nbsp;&nbsp;</td><td class="auto-style3">
        <div>
            
            <input type="button" id ="btn" value=" BUYER" onclick="parent.open('register.html')"  data-toggle="modal" style="border-style: solid; padding-right:0; background-color: #00CC00; font-size: large; color: #FFFFFF; font-weight: bolder; font-style: normal; height: 73px;width:230px" >
    </div> </td>
           <td></td>
            <td class="auto-style1">

            </td>
            <td class="auto-style1">
                
            </td>    <br />
            <td>
        
            <input type="button" id ="btn1" value=" SELLER" onclick="parent.open('registerRET.html')"  data-toggle="modal" style="border-style: solid; padding-right:0; background-color: #00CC00; font-size: large; color: #FFFFFF; font-weight: bolder; font-style: normal; height: 73px;width:230px" >
</a>
           </td></tr>
             <td>
    <h1> Login As </h1>
                    </td>
                <td></td><td></td><td class="auto-style2">&nbsp;&nbsp;</td><td class="auto-style3">
        <div>   <input type="button" id ="btn2" value=" BUYER" onclick="parent.open('login.html')"  data-toggle="modal" style="border-style: solid; padding-right:0; background-color: #00CC00; font-size: large; color: #FFFFFF; font-weight: bolder; font-style: normal;height: 73px;width:230px" />
    </div> </td>
            <td></td>
            <td class="auto-style1">

            </td>
            <td class="auto-style1">
                
            </td>    <br />
            <td>
        
        <input type="button" id ="btn3" value=" SELLER" onclick="parent.open('login.html')"  data-toggle="modal" style="border-style: solid; padding-right:0; background-color: #00CC00; font-size: large; color: #FFFFFF; font-weight: bolder; font-style: normal;height: 73px;width:230px" >
          </td>
        </table>
        <div class="circle_inner"></div>
        <br />
        <br />
        <%--<h1>FEATURES-</h1>--%>
        <%--<div class="content_right"><h2>Compare Products</h2><div id="indicator_1" class="content_feature unscripted"><div class="content_indicator"><div class="circle_outer"><div class="circle_inner"></div></div></div><div class="copy"><h3>Scan Products In-Store</h3><p>Use our helpful scanner to scan any product in any store. Instantly read consumer reviews, see scores, and view awards from top websites.</p></div></div><div id="indicator_2" class="content_feature unscripted"><div class="content_indicator"><div class="circle_outer"><div class="circle_inner"></div></div></div><div class="copy"><h3>Compare Products Side-by-Side</h3><p>Compare two scanned products, or browse products from our extensive database and compare features, specs, and top reviews.</p></div></div><div id="indicator_3" class="content_feature unscripted"><div class="content_indicator"><div class="circle_outer"><div class="circle_inner"></div></div></div><div class="copy"><h3>See Online vs. Nearby Prices</h3><p>Find the best prices by comparing local and in-store prices with online retailers like Amazon, Best Buy, and others.</p></div></div></div>
</div>--%>

</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <style type="text/css">
        .auto-style1 {
            width: 53px;
        }
        .auto-style2 {
            width: 158px
        }
        .auto-style3 {
            width: 224px;
        }
    </style>
</asp:Content>



