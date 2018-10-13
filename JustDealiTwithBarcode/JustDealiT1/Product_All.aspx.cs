using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;

public partial class Product_All : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    string query;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }


    protected void Lenovo_Click(object sender, EventArgs e)
    {
        query = "Select pid from Product_Details where Product_Name = 'Lenovo Ideapad v110'";
        cmd = new SqlCommand(query, con);


        SqlDataReader rs = cmd.ExecuteReader();
        if (rs.Read())
        {
            Session["s1"] = rs[0];
            Response.Redirect("Product_Details.aspx?id=" + rs[0]);
        }
    }
} 