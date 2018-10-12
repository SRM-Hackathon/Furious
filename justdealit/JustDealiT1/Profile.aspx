<%@ Page Title="" Language="C#" MasterPageFile="~/Display1.Master" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        
                    </tr>

          

        <div class="content_right"><h2><table>
            <tr>
                <td>
    <h1> PROFILE  </h1>
                    <p> &nbsp;</p>
                    <p> 
                        <ul id ="progressbar" class="auto-style29">
                                   <li class ="active" style="left: 15px; top: 0px; width: 30%"> Registration </li>
                                   <li class="auto-style27"> Verification</li>
                                   <li class="auto-style28"> Confirmation</li>
                               </ul>
                        
                        
                        
                        &nbsp;</p>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style14">
                                <br />
                            </td>
                            <td class="auto-style18">
                              <%-- --%>
                                
                                 &nbsp;</td>
                            <td>&nbsp;</td>
                            <td></td>
                            <td class="auto-style24">&nbsp;</td>
                            <td class="auto-style24">&nbsp;</td>
                            <td class="auto-style21">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18">
                                <h4> First Name</h4>
                                </td>
                            
                            <td>
                                &nbsp;</td>
                            
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>

                               </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style4"> &nbsp;</td>
                            <td class="auto-style19">
                                <h4> Last Name </h4>
                            </td>
                            
                            <td class="auto-style6">
                                &nbsp;</td>
                            
                            <td class="auto-style6">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                            
                            <td class="auto-style25">
                                &nbsp;</td>
                            
                            <td class="auto-style25">&nbsp;<td class="auto-style7"> &nbsp;</td> 
                                <h3> STEP 1 </h3></td> 
                            
                            <td class="auto-style22">
                                </td>
                            
                        </tr>
                        <tr>
                               <td class="auto-style9"></td>
                            <td class="auto-style20">
                                <h4> Email</h4>
                            </td>
                           
                         <td>

                                &nbsp;</td>
                           
                         <td>

                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                            </td>
                           
                            <td class="auto-style26">

                                &nbsp;</td>
                           
                            <td class="auto-style26">

                                &nbsp;</td>
                           
                            <td class="auto-style23">

                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18">
                                <h4> Password</h4>
                                </td>
                            
                            <td class="auto-style2">
                                &nbsp;</td>
                            
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18">
                               <h4>Shop Name</h4> 
                            </td>
                            
                            <td class="auto-style2">
                                &nbsp;</td>
                            
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                            </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18">
                               <h4>Address</h4> 
                            </td>
                            
                            <td class="auto-style2">
                                &nbsp;</td>
                            
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>
                        </tr>
                        
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18">
                                <h4>Address (Line 2)</h4>
                            </td>
                            
                            <td class="auto-style2">
                                &nbsp;</td>
                            
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                            </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>

                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18"><h4>City</h4></td>
                           
                            <td class="auto-style2">
                                &nbsp;</td>
                           
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                            </td>
                           
                            <td class="auto-style24">
                                &nbsp;</td>
                           
                            <td class="auto-style24">
                                &nbsp;</td>
                           
                            <td class="auto-style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18"><h4>State</h4></td>
                            
                            <td class="auto-style2">
                                &nbsp;</td>
                            
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                            </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14"></td>
                            <td class="auto-style18"><h4>Zip/Postal Code</h4></td>
                           
                            <td class="auto-style2">
                                &nbsp;</td>
                            
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                            </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style14"> </td>
                            <td class="auto-style15">
                                <h4>Mobile No.</h4></td>
                            
                            <td class="auto-style2">
                                &nbsp;</td>
                            
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                            </td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style24">
                                &nbsp;</td>
                            
                            <td class="auto-style21">
                                &nbsp;</td>
                           
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style18">&nbsp;</td>
                            <td class="auto-style15">&nbsp;</td>
                            <td class="auto-style15">&nbsp;</td>
                            <td class="auto-style24">&nbsp;</td>
                            <td class="auto-style24">&nbsp;</td>
                            <td class="auto-style21">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style18">&nbsp;</td>
                            <td class="auto-style15">&nbsp;</td>
                            <td class="auto-style15">&nbsp;</td>
                            <td class="auto-style24">&nbsp;</td>
                            <td class="auto-style24">&nbsp;</td>
                            <td class="auto-style21">&nbsp;</td>
                        </tr>
                    </table></div>-

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-right: 406px;
        }
        .auto-style2 {
            width: 185px;
        }
        .auto-style4 {
            height: 23px;
            width: 78px;
        }
        .auto-style6 {
            width: 185px;
            height: 23px;
        }
        .auto-style7 {
            height: 22px;
            width: 78px;
        }
        .auto-style9 {
            width: 185px;
            height: 22px;
        }
        .auto-style14 {
            width: 78px
        }
        .auto-style15 {
            width: 64px
        }
        .auto-style18 {
            width: 143px;
        }
        .auto-style19 {
            width: 143px;
            height: 23px;
        }
        .auto-style20 {
            width: 143px;
            height: 22px;
        }
        .auto-style21 {
            width: 487px;
        }
        .auto-style22 {
            width: 487px;
            height: 23px;
        }
        .auto-style23 {
            width: 487px;
            height: 22px;
        }
        .auto-style24 {
            width: 295px;
        }
        .auto-style25 {
            width: 295px;
            height: 23px;
        }
        .auto-style26 {
            width: 295px;
            height: 22px;
        }
        #progressbar {
            overflow: hidden;
            counter-reset: step;


        }
        #progressbar li{
            list-style-type : none;
            color :lawngreen;
            text-transform:uppercase;
            font-size:29px;
            width:33.33%;
            float: left;
            position:relative;

        }
        #progressbar li:before {
            content : counter(step);
            counter-increment:step;
            width : 30px;
            line-height:30px;
            display: block;
            font-size:35px;
            color:#FFF;
            background: red;
            border-radius:3px;
            margin:0 auto 12px auto;


        }
            #progressbar li:after {
                content:'';
                width: 100%;
                height: 8px;
                background: green;
                position: absolute;
                left: -50%;
                top: 9px;
                z-index: -1;
            


        }
            #progressbar li:first-child:after{
                content:none;

            }
            #progressbar li.active:before{
                background:#27AE60;
                color:white;
            }
        .auto-style27 {
            left: 38px;
            top: -2px;
        }
        .auto-style28 {
            left: 27px;
            top: 0px;
            width: 29%;
        }
        .auto-style29 {
            width: 938px;
            margin-right: 63;
        }
        </style>
    </asp:Content>



