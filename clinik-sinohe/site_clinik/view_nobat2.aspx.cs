using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    d_base db = new d_base();
    date_shamsii dsh = new date_shamsii();
    SqlDataReader dr,dr2;
    public string  id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if ( Session["code_r"] == null )
            Response.Redirect("cancel_nobat.aspx");
        else
        {
            dr = db.getdatar("select r.id,t.sharh,p.name,p.lname ,r.date_r,r.time_r,r.name,r.lname from takhassos t,rezerv r,pezeshk p where t.id=r.id_t  and p.id=r.id_p and r.code_r like'" + Session["code_r"].ToString()+"'");
            if (dr.Read())
            {
                id = dr[0].ToString();
                Label13.Text = dr[1].ToString();
                Label12.Text = dr[2].ToString() + " " + dr[3].ToString();
                Label9.Text = dr[4].ToString() + "  " + dr[5].ToString();
                Label14.Text = dr[6].ToString() + "  " + dr[7].ToString();
            }
            db.Dconect();

           

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("main.aspx");
        db.run("update rezerv set cancel=1 where id ="+id.ToString());
        lblmsg.Text = "نوبت شما لغو گردید";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
}