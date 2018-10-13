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
    // public object Category { get; private set;
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
        /*
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Name from Category", con);
        SqlDataReader dr=cmd.ExecuteReader(CommandBehavior.CloseConnection);
        Category.Items.Clear();
        while(dr.Read())
        {
            Category.Items.Add(new ListItem(dr[0].ToString()));
        }
        con.Close();
       // con.Open();*/


        /*    SqlCommand cmd1 = new SqlCommand("Select Product_Name from Product_Details where Category_Id = (Select Category_Id from Category where Name = '"+cat+"')", con);
            SqlDataReader dr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
            ProdName.Items.Clear();
            while (dr1.Read())
            {
                ProdName.Items.Add(new ListItem(dr1[0].ToString()));
            }*/
    }
    protected void Save_Button1_Click1(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        //System.Drawing.Image imag = System.Drawing.Image.FromStream(flImage.PostedFile.InputStream);
        //HttpPostedFile Post = File.PostedFile;
        string s = Path.GetFileName(FileUpload1.FileName);
        string ex = Path.GetExtension(s);
      
         //   Stream stream = Post.InputStream;

            FileUpload1.SaveAs(Server.MapPath("~\\Images\\") + s);
            FileUpload1.Visible = true;
            //byte[] bytes;
            //using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            //{
            //    bytes = br.ReadBytes(File.PostedFile.ContentLength);
            //}


            String cat = ProdName.SelectedItem.Text.ToString();
            SqlCommand cmd1 = new SqlCommand("Select * from Product_Details where Product_Name='" + cat.ToString() + "'", con);
            String pid = (String)cmd1.ExecuteScalar();
            SqlCommand cmd = new SqlCommand("insert into Products values( '" + pid + "','R100','" + UnitPrice.Text + "','" + UnitinStock.Text + "','" + Disc.Text + "','" + ExpectDelS.Text + "' , '" + ExpectDelNS.Text + "','"+s+"')", con);
        //    cmd.Parameters.AddWithValue("@Data", bytes);
          //  cmd.CommandType = CommandType.StoredProcedure;
        
        cmd.Connection = con;
        cmd.ExecuteNonQuery();
        con.Close();
       // Response.Redirect("Profile.aspx");
    }
    protected void Category_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*   con.Open();
          // String cat = "Laptops";
           String cat = ProdName.SelectedItem.Text.ToString();
           //Console.WriteLine(cat,"g");
           SqlCommand cmd1 = new SqlCommand("Select Product_Name from Product_Details where Category_Id = (Select Category_Id from Category where Name = '" + cat.ToString() + "')", con);
           SqlDataReader dr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
           ProdName.Items.Clear();
           while (dr1.Read())
           {
               ProdName.Items.Add(new ListItem(dr1[0].ToString()));
           }*/
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
}
//private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert,
//                                       System.Drawing.Imaging.ImageFormat formatOfImage)
//{
//    byte[] Ret;
//    try
//    {
//        using (MemoryStream ms = new MemoryStream())
//        {
//            imageToConvert.Save(ms, formatOfImage);
//            Ret = ms.ToArray();
//        }
//    }
//    catch (Exception) { throw; }
//    return Ret;
//}