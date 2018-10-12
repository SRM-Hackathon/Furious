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
public partial class Login_Ret : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        string s1 = "";
        string uid = txtEmail.Text;
        //string email = "";
        //string pwd = "";
        string s = "Select *  from Retailer where Email='" + txtEmail.Text + "' AND Password='" + txtPwd.Text + "'";
        SqlCommand cmd = new SqlCommand(s, con);

        SqlDataReader rs = cmd.ExecuteReader();
        if (rs.Read())
        {
            Session["s1"] = rs[0];
            Response.Redirect("Profile.aspx?id=" + uid);
        }
        else
        {
            Label1.Text = "wrong username or password";
        }
        txtEmail.Text = " ";
        txtPwd.Text= " ";
        con.Close();

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string s2 = "", s3 = "";
        con.Open();
        string uid = txtEmail.Text;
        //string s = "select RE fom Retailer where Email= '" + txtEmail.Text + "'";
        //SqlCommand cmd = new SqlCommand(s, con);
       // SqlDataReader dr = cmd.ExecuteReader();
        //while (dr.Read())
        //{
        //    s2 = dr[0].ToString();

        //}
        MailMessage mailMessage = new MailMessage(new MailAddress("JustDealiT@gmail.com"), new MailAddress(txtEmail.Text));
        mailMessage.Subject = "Password Recovery";
        mailMessage.IsBodyHtml = true;
        string s1 = "select password from Retailer where Email='" + txtEmail.Text + "'";
        con.Close();
        con.Open();
        SqlCommand cmd1 = new SqlCommand(s1, con);
        SqlDataReader dr1 = cmd1.ExecuteReader();
        while (dr1.Read())
        {
            s3 = dr1[0].ToString();

        }
        mailMessage.Body = "Username :'" + txtEmail.Text + "' Password = '" + s3 + "'";
        System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential("JustDealiT@gmail.com", "12345678");
        SmtpClient smtpClient = new SmtpClient();
        // smtpClient.EnableSsl = true;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = networkCredential;
        smtpClient.Host = "smtp.gmail.com";
        smtpClient.Port = 587;
        smtpClient.Send(mailMessage);
        //  Response.Write("Mail Successfully Sent.");
        Label1.Text = "Password Successfully Sent on your mail";
        con.Close();


    }

   
}
