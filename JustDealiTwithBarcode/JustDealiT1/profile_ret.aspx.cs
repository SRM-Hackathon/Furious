using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class profile_ret : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        string uu = Request.QueryString["id"];
        SqlCommand cmd = new SqlCommand("Select * from Users where Email= '" + uu + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            TextBox1.Text = dr["first_Name"].ToString();

            TextBox2.Text = dr["Last_Name"].ToString();
            TextBox3.Text = dr["Email"].ToString();
            TextBox4.Text = dr["Password"].ToString();
            TextBox5.Text = dr["Shop_Name"].ToString();
            TextBox6.Text = dr["Address1"].ToString();
            TextBox7.Text = dr["Address2"].ToString();
            TextBox8.Text = dr["City"].ToString();
            TextBox9.Text = dr["State"].ToString();
            TextBox10.Text = dr["Pincode"].ToString();
            TextBox11.Text = dr["Mob_no"].ToString();
        }

        con.Close();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
       String uid = "rashi@gmail.com";
        SqlCommand cmd = new SqlCommand("update Retailer SET  First_Name= '" + TextBox1.Text + "',Last_Name='" + TextBox2.Text + "',Password='" + TextBox4.Text + "',Address1='" + TextBox6.Text + "',Address2='" + TextBox7.Text + "',City='" + TextBox8.Text + "', Pincode='" + TextBox10.Text + "',State='" + TextBox9.Text + "',Mob_no='" + TextBox11.Text + "',Email='" + TextBox3.Text + "',Shop_Name='"+TextBox5.Text+"' where Email='" + uid + "'", con);
        // cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
    }


protected void Button4_Click(object sender, EventArgs e)
    {
        //TextBox1.Enabled = true;
        //TextBox2.Enabled = true;
        //TextBox3.Enabled = true;
        //TextBox4.Enabled = true;
        ////TextBox5.Enabled = true;
        //TextBox6.Enabled = true;
        //TextBox7.Enabled = true;
        //TextBox8.Enabled = true;
        //TextBox9.Enabled = true;
        //TextBox10.Enabled = true;
        //TextBox11.Enabled = true;
    }

}