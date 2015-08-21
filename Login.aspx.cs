using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        conn.Open();
        string checkUser = "select count(*) from [Table] where username='" + lusername.Text + "'";
        SqlCommand com = new SqlCommand(checkUser, conn);
        int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp != 0)
        {
            conn.Open();
            string checkPassword = "select password from [Table] where username='" + lusername.Text + "'";
            SqlCommand passComm = new SqlCommand(checkPassword, conn);
            string password = passComm.ExecuteScalar().ToString().Replace(" ","");
            if (password != lpassword.Text)
            {
                Response.Write("Password Not Correct!");
            }
            else
            {
                Session["new"] = lusername.Text;
                Response.Write("Password Correct!");
                Response.Redirect("Users.aspx");
            }
        } else {
            Response.Write("No such a username!");
        }
    }
}