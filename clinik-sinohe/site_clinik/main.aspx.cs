using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    d_base db = new d_base();
    protected void Page_Load(object sender, EventArgs e)
    {

        GridView1.DataSource = db.getdatar("select id as'شماره',title as'عنوان',matn as'متن',date_n as'تاریخ ارسال' from news order by id desc");
        GridView1.DataBind();
        db.Dconect();
        //GridView1.Columns[2].HeaderText.Insert(
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (TextBox1.Text.Trim() != "" && TextBox1.Text.Trim() != "")
        {
            SqlDataReader sr = db.getdatar("select * from [user] where username like'" + TextBox1.Text + "'  and password like'" + TextBox2.Text + "'");
            if (sr.HasRows)
            {
                //  Session("user") = TextBox1.Text;
                //  Session("pass") = TextBox2.Text;
                Response.Redirect("admin.aspx");
            }
            else
                lblmsg.Text = "نام کاربری یا کلمه عبور اشتباه است";
        }
        else
            lblmsg.Text = "نام کاربری و کلمه عبور را وارد کنید";


    }
}