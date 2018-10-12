<%@ Page Title="" Language="C#" MasterPageFile="~/Display1.Master" AutoEventWireup="true" CodeFile="Login_Ret.aspx.cs" Inherits="Login_Ret" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <ul class="breadcrumb">
		<li><a href="index.html">Home</a> <span class="divider">/</span></li>
		<li class="active">Login</li>
    </ul>
	<h3> Login</h3>	
	<hr class="soft"/>
	
	<div class="row">
		
		<div class="span1"> &nbsp;</div>
		<div class="span4">
			<div class="well">
			<h5>ALREADY REGISTERED ?</h5>
		
			  <div class="control-group">
				<label class="control-label" for="inputEmail1">Email</label>
				<div class="controls">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
				  <%--<input class="span3"  type="text" id="inputEmail1" placeholder="Email">--%>
				</div>
			  </div>
			  <div class="control-group">
				<label class="control-label" for="inputPassword1">Password</label>
				<div class="controls">
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
				  <%--<input type="password" class="span3"  id="inputPassword1" placeholder="Password">--%>
				</div>
			  </div>
			  <div class="control-group">
				<div class="controls">
				 
                      <asp:Button ID="Button1" runat="server" Text="Sign In" class="btn" OnClick="Button1_Click"/>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
				  <a href="forgetpass.html">Forget password?</a>
				    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
				      <br />
                      <asp:Label ID="Label1" runat="server"></asp:Label>
				</div>
			  </div>
			<form></form>
		</div>
		</div>
	</div>	
	
</asp:Content>

