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
//using System.Windows.Forms;





public partial class Db_Retailer : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    string query;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            query = "select * from Category";
            da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 0)
            {

                Category.DataSource = ds;
                Category.DataTextField = "Name";
                Category.DataValueField = "Category_Id";
                Category.DataBind();
                Category.Items.Insert(0, new ListItem ("Chooose Category","0"));
                
            }

            ProdName.Items.Insert(0, "No Product Available");
        }
       
        



    }
    protected void Save_Button1_Click1(object sender, EventArgs e)
    {

    }




    protected void Button2_Click(object sender, EventArgs e)
    {
            con.Open();
            String cat = ProdName.SelectedItem.Text.ToString();
            SqlCommand cmd1 = new SqlCommand("Select * from Product_Details where Product_Name='"+cat.ToString()+"'",con);
            String pid=(String)cmd1.ExecuteScalar();
            SqlCommand cmd=new SqlCommand("update Products SET  Unit_Price='"+UnitPrice.Text+"', Unit_In_Stock='"+UnitinStock.Text+"',Discount='"+Disc.Text+"',ExpectedDelivery='"+ExpectDelS.Text+ "',ExpectedDeliveryNS='"+ ExpectDelNS.Text+"'where Product_Id='"+pid+"'",con);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            // Response.Redirect("Profile.aspx");
    }




    protected void Category_SelectedIndexChanged(object sender, EventArgs e)
    {
          con.Open();
        ds.Clear();
        string get_name, name;
        name = Category.SelectedItem.Text;
        get_name = Category.SelectedValue.ToString();
        if (get_name != "0")
        {
            query = "select Product_Name,Product_Id from Product_Details where Category_Id='" + get_name.ToString() + "' ";
            da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 0)
            {
                ProdName.DataSource = ds;
                ProdName.DataTextField = "Product_Name";
                ProdName.DataValueField = "Product_Id";
                ProdName.DataBind();
                ProdName.Items.Insert(0, new ListItem("Choose " + name.ToString() + " Product ", "0"));
                ProdName.SelectedIndex = 0;
            }
        }
        else
        {
            ProdName.Items.Insert(0, "No Product Available");
            ProdName.DataBind();
        }
       


    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Disc.Enabled = true;
        UnitinStock.Enabled = true;
        UnitPrice.Enabled = true;
        ExpectDelNS.Enabled = true;
        ExpectDelS.Enabled = true;



    }



    protected void ProdName_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();
        String cat = ProdName.SelectedItem.Text.ToString();
        SqlCommand cmd1 = new SqlCommand("Select Product_Id from Product_Details where Product_Name='" + cat.ToString() + "'", con);
        String pid = (String)cmd1.ExecuteScalar();
        SqlCommand cmd = new SqlCommand("Select * from Products where Product_Id='" + pid + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            UnitPrice.Text += dr[2].ToString();
            UnitinStock.Text += dr[3].ToString();
            Disc.Text += dr[4].ToString();
            ExpectDelS.Text += dr[5].ToString();
            ExpectDelS.Text += dr[6].ToString();


        }
    }
}