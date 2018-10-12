<%@ Page Title="" Language="C#" MasterPageFile="~/Display1.Master" AutoEventWireup="true" CodeFile="Login_buy.aspx.cs" Inherits="Login_buy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 300px;
            height: 296px;
        }
        .auto-style2 {
            width: 299px;
            height: 337px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
   
  	
    <ul class="breadcrumb">
		<li><a href="index.html">Home</a> <span class="divider">/</span></li>
		<li class="active">Login</li>
    </ul>
	<h3> Login</h3>	
	<hr class="soft"/>
	
	<div class="row">
		
		<div class="auto-style2"> &nbsp;<div class="auto-style1">
			<div class="well">
			<h5>ALREADY REGISTERED ?</h5>
		
			  <div class="control-group">
				<label class="control-label" for="inputEmail1">Email</label>
				<div class="controls">
				 <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
				</div>
			  </div>
			  <div class="control-group">
				<label class="control-label" for="inputPassword1">Password</label>
				<div class="controls">
				  <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
				</div>
			  </div>
			  <div class="control-group">
				<div class="controls">
				   <asp:Button ID="Button2" runat="server" Text="Sign In" class="btn" OnClick="Button2_Click" />
				 <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
			  </div>
    <form></form>
			
		    </div>
		</div>
	    </div>
	</div>
	

</asp:Content>

