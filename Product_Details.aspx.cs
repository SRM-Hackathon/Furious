using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Web;
using System.Web.UI;
//using System.Windows.Controls;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

using System.Windows.Forms;
//using System.Windows.Forms;
/*public class Products
{
    public string ShopName { get; set; }
    public string Rating { get; set; }
    public string Price { get; set; }
    public string ExpectDel { get; set; }
    public string Disc{ get; set; }

}*/
public partial class Product_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

   
    protected void Page_Load(object sender, EventArgs e)
    {

        con.Open();


        //con.Close();

















        String pid = "P101";
        SqlCommand cmd = new SqlCommand("select Picture from Products where Product_Id='" + pid + "'", con);

        String r = cmd.ExecuteScalar().ToString();

        Image1.Visible = true;
        Image1.ImageUrl = "~\\Images\\" + r;
        // SqlCommand cmd1 = new SqlCommand("Select * from Product_Details where Product_Id='"+ pid +"'", con);
        //SqlDataReader dr = cmd.ExecuteReader();

        /*  while (dr.Read())
          {

              Prod_Name.Text = dr["Product_Name"].ToString();
              Brand.Text = dr["Brand"].ToString();
              Model.Text = dr["Model"].ToString();
              Content.Text = dr["Description"].ToString();



          }*/
        SqlCommand cmd2 = new SqlCommand("select min(unit_price) from Products where Product_Id ='" + pid + "'", con);
        //Double price = Convert.ToDouble(cmd2.ExecuteScalar());
        Price.Text = cmd2.ExecuteScalar().ToString();

        SqlCommand cmd3 = new SqlCommand("Select brand from Product_Details where Product_Id='" + pid + "'", con);
        Brand.Text = cmd3.ExecuteScalar().ToString();



        SqlCommand cmd4 = new SqlCommand("Select model from Product_Details where Product_Id='" + pid + "'", con);
        Model.Text = (String)cmd4.ExecuteScalar();

        SqlCommand cmd5 = new SqlCommand("Select description from Product_Details where Product_Id='" + pid + "'", con);
        Content.Text = (String)cmd5.ExecuteScalar();
        SqlCommand cmd6 = new SqlCommand("Select Product_Name from Product_Details where Product_Id='" + pid + "'", con);
  
        Prod_Name.Text = (String)cmd6.ExecuteScalar();
        DataTable dt = new DataTable();
        if (!IsPostBack)
        {
            //SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            //conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Retail_Id,Unit_Price,Discount,ExpectedDelivery from products where Product_Id= 'P101' order by Unit_Price", con);


            //    string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

            using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
            {
                cmd1.CommandType = CommandType.Text;
                sda.Fill(dt);
            }
        }

        string htmlTable = "<table border='1' cellpadding='0' cellspacing='0'><tr>";


        foreach (DataColumn column in dt.Columns)
        {
            htmlTable += "<th>" + column.ColumnName + "</th>";
        }
        htmlTable += "</tr>";
        foreach (DataRow dr in dt.Rows)
        {
            string rid = dr["Retail_Id"].ToString();
            Double Unit_Price = Convert.ToDouble(dr["Unit_Price"]);

            string Discount = dr["Discount"].ToString();
            string ExpectedDelivery = dr["ExpectedDelivery"].ToString();

            htmlTable += "<tr><td>" + rid + "</td><td>" + Unit_Price + "</td><td>" + Discount + "</td><td>" + ExpectedDelivery + "</td></tr>";
        }
        htmlTable += "</table>";
        lblTable.Text = htmlTable;
       con.Close();
    }
}