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
    SqlDataReader dr, dr2;
    protected void Page_Load(object sender, EventArgs e)
    {
      //name.Text =  Session["r"].ToString(); 
      // lastname.Text= Session["id_p"] .ToString();
      // lblmsg.Text= Session["id_t"].ToString();
      // tell.Text= Session["d_r"].ToString();
      // mob.Text= Session["t_r"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Random r = new Random();
        Int64 c_r = r.Next(900000000) +100000000;
        lblmsg0.Text = db.run("insert into rezerv(code_r,ruz,id_p,id_t,date_r,time_r,name,lname,tell,mob,vizit,cancel) values('"+c_r+"',"+Session["r"] .ToString()+","+Session["id_p"].ToString()+ "," + Session["id_t"].ToString() + ",'" + Session["d_r"].ToString() + "','" + Session["t_r"].ToString() + "','"+name.Text +"','"+lastname.Text +"','"+tell.Text +"','"+mob.Text +"',0,0)");
        lblmsg.Text ="کد رهگیری :"+ c_r.ToString();
        Button1.Enabled = false;        
    }
}