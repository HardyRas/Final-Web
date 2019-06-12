using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Final_Web
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {         

        SqlConnection con = new SqlConnection
            {
                ConnectionString = "Data Source=WAMBIAKALE\\NASTYCDBENGINE;Initial Catalog=ZmalariaSysLogin;Integrated Security=True"
            };
            con.Open();
            string userid = TextBox2.Text;
            _ = TextBox3.Text;
            SqlCommand cmd = new SqlCommand("select username , password from SystemLogin where username ='" + TextBox2.Text + "'and password = '" + TextBox3.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Session["username"] = userid;
                Response.Redirect("selectionMap.aspx");
            }
            else
            {
                Response.Redirect("Error_404.aspx");
            }
            con.Close();
        }
    }
}