using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    d_base db = new d_base();
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (c_r.Text.Trim() != "")
        {
            SqlDataReader sr = db.getdatar("select * from rezerv where code_r like'" + c_r.Text + "' ");
            if (sr.HasRows)
            {
                sr.Read();
               // global::System.Windows.Forms.MessageBox.Show("Test");
                if ((sr[11].ToString() != "True" && sr[12].ToString() != "True"))
                {
                    //lblmsg.Text = sr[11].ToString() + "   " + sr[12].ToString();
                    Session.Add("code_r", "");
                    Session["code_r"] = c_r.Text;
                    Response.Redirect("view_nobat2.aspx");
                }
                else
                    lblmsg.Text = "کد رهگیری اعتبار ندارد";

            }
            else
                lblmsg.Text = "کد رهگیری اشتباه است";

        }
        else
            lblmsg.Text = "کد رهگیری را وارد کنید";
    }
}