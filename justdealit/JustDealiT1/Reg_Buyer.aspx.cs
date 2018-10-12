using System;
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

public partial class Reg_Buyer : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
     String bid = "U";
    static int x = 111;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public int getid_no()
    {
        string query = "Select count(*) from Users";
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
        bid = "U" + z.ToString();
                SqlCommand cmd = new SqlCommand("insert into Users Values('"+bid+"','" + FName.Text + "','" + inputLnam.Text + "','" + inputPassword2.Text + "','" + address.Text + "','" + address2.Text + "','" + city.Text + "','" + postcode.Text + "','" + state.SelectedItem.Text + "', '" + mobile.Text + "','" + input_email.Text + "')", con);
            cmd.ExecuteNonQuery();
            // Label1.Text = "Hi";
            Response.Redirect("Login_buy.aspx");
        
        //catch (Exception ex)
        //{
        //    Label1.Text = "Some Error occured";
        //}
    }
}