using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Final_Web
{
    public partial class GetambwegaWardNewEntries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void AddEntry_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection
            //{
            //    ConnectionString = "Data Source=WAMBIAKALE\\NASTYCDBENGINE;Initial Catalog=ZmalariaSysLogin;Integrated Security=True"
            //};
            //con.Open();
            //string userid = TextBox2.Text;
            //_ = TextBox3.Text;
            //SqlCommand cmd = new SqlCommand("select username , password from SystemLogin where username ='" + TextBox2.Text + "'and password = '" + TextBox3.Text + "'", con);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            //SqlDataAdapter da = sqlDataAdapter;
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    Session["username"] = userid;
            //    Response.Redirect("selectionMap.aspx");
            //}
            //else
            //{
            //    Response.Redirect("Error_404.aspx");
            //}
            //con.Close();
        }
    }
    }