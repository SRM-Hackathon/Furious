﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;
//using System.Windows.Forms.,loo
public partial class Register_Ret : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
    String bid = "R";
    static int x = 111;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public int getid_no()
    {
        string query = "Select count(*) from Retailer";
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        da.Fill(ds);

        int y = (int)ds.Tables[0].Rows[0][0];
        return y;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        //int pin = int.Parse(postcode.Text);
        //int mob = int.Parse(mobile.Text);ss'
        int z = getid_no();
        z++;
        z += 100;
        bid = "R" + z.ToString();
        SqlCommand cmd = new SqlCommand("insert into Retailer Values('" + bid + "','" + inputFname1.Text + "','" + Shop_name.Text + "','" + Address.Text + "','" + address2.Text + "','" + city.Text + "','" + postcode.Text + "','1','" + inputLnam.Text + "', '" + mobile.Text + "','1','"+inputPassword1.Text+"','"+input_email.Text + "','" + state.SelectedItem.Text + "')", con);
        cmd.ExecuteNonQuery();
        // Label1.Text = "Hi";
        Response.Redirect("Login_Ret.aspx");

    }
}