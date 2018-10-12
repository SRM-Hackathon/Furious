using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.IO;
using System.Net;

public partial class Login_buy : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        //Button2.Enabled = true;
        //txtEmail.Enabled = true;
        //txtPwd.Enabled = true;
    }

  
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        //string s1 = "";
        string uid = txtEmail.Text;
        //string email = "";
        //string pwd = "";
        string s = "Select User_Id from Users where Email='" + txtEmail.Text + "' AND Password='" + txtPwd.Text + "'";
        SqlCommand cmd = new SqlCommand(s, con);

        SqlDataReader rs = cmd.ExecuteReader();
        if (rs.Read())
        {
            Session["s1"] = rs[0];
           
            Response.Redirect("Profile_Buyer.aspx?id=" + uid);
        }
        else
        {
            Label1.Text = "Wrong  email or password";
        }
        txtEmail.Text = " ";
        txtPwd.Text = " ";
        con.Close();

    }
}

