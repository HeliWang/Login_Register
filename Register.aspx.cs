using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
public partial class _Default : System.Web.UI.Page
{
    protected Boolean CheckValid()
    {
        //if (IsPostBack)
        //{
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string checkUser = "select count(*) from [Table] where username='"+ username.Text + "'";
            SqlCommand com = new SqlCommand(checkUser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp != 0)
            {
                Response.Write("UserAlreadyExist");
                return false;
            }
            conn.Close();
        return true;
       // }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (!CheckValid()) return;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            string InserQuery = "insert into [Table] (username, email, password, country) values (@Uname, @email, @password, @country)";
            SqlCommand com = new SqlCommand(InserQuery, conn);
            com.Parameters.AddWithValue("@Uname", username.Text);
            com.Parameters.AddWithValue("@email", email.Text);
            com.Parameters.AddWithValue("@password", password.Text);
            com.Parameters.AddWithValue("@country", country.SelectedItem.ToString());
            com.ExecuteNonQuery();
            Response.Redirect("Manager.aspx");
            conn.Close();

            Response.Write("Good Job!");
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.ToString());
        }
        
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        username.Text = "";
        password.Text = "";
        retypepassword.Text = "";
        email.Text = "";
        country.SelectedIndex = 0;
    }
}