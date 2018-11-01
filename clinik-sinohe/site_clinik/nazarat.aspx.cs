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
    date_shamsii dsh = new date_shamsii();
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (c_r.Text.Trim() != "")
        {
            lblmsg.Text=db.run("insert into nazarat (matn, date) values('"+c_r.Text+"','"+dsh.DateShamsi()+"') ");
            Button1.Enabled = false;

        }
        else
            lblmsg.Text = "متن خود را وارد کنید";
    }
}