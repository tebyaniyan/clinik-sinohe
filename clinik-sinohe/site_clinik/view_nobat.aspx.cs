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
    SqlDataReader dr,dr2,dr3;
    public int nearruz = 0, today = 0, zarfiyat = 0, start = 0, id_p = 0,id_t=0;
    public string date_r="",time_r=""; 
    protected void Page_Load(object sender, EventArgs e)
    {
        if ( Session["type_s"] == null )
            Response.Redirect("select type nobat.aspx");
        else
        {
            if (Session["type_s"].ToString() == "1")
            {
                id_t =int.Parse( Session["code_s"].ToString());
                dr = db.getdatar("select sharh from takhassos where id =" + id_t );
                if (dr.HasRows)
                {
                    dr.Read();
                    Label13.Text = dr["sharh"].ToString();
                }
                db.Dconect();
//---------------------------------------------------------------------------------------
              
                today = dsh.today();
                dr = null;
                dr = db.getdatar("select * from ruz r,takhassos t where  r.id_t=t.id  and  t.id = " + Session["code_s"].ToString() );
            
                if (dr.HasRows)
                {
                    db.Dconect();
                    nearruz = today;

                    for (int i = 0; i < 6; i++)
                    {
                        if (nearruz < 7)
                            nearruz++;
                        else
                            nearruz = 1;
                        dr3 = db.getdatar("select * from ruz r,takhassos t where  r.id_t=t.id  and r.ruz="+nearruz+" and t.id = " + Session["code_s"].ToString());
                        if (dr3.HasRows)
                        {
                            dr3.Read();
                            id_p = int.Parse(dr3[1].ToString());
                            nearruz = int.Parse(dr3[2].ToString());
                            zarfiyat = int.Parse(dr3[6].ToString());
                            start = int.Parse(dr3[4].ToString());
                            db.Dconect();
                            break;
                        }
                        db.Dconect();
                        
                    }



                    //while (dr.Read())
                    //{
                    //    if (int.Parse(dr[2].ToString()) < nearruz && int.Parse(dr[2].ToString()) > today)
                    //    {
                    //        id_p = int.Parse(dr[1].ToString());
                    //        nearruz = int.Parse(dr[2].ToString());
                    //        zarfiyat = int.Parse(dr[6].ToString());
                    //        start = int.Parse(dr[4].ToString());
                    //    }
                    //}
                    //db.Dconect();
                    dr2 = db.getdatar("select count(*) as sm from rezerv r,pezeshk p where  r.id_p=p.id and r.ruz=" + nearruz + "  and r.vizit=0 and r.cancel=0 and p.id=" + id_p );
                    if (dr2.HasRows)
                    {
                        dr2.Read();
                        int rezerv = int.Parse(dr2[0].ToString());
                        db.Dconect();
                        if (rezerv < zarfiyat)
                        {
                            date_r = ((rezerv * 10 + start * 60) / 60).ToString();
                            time_r=((float)(rezerv * 10 + 9 * 60) % 60).ToString();
                            Label9.Text = dsh.today(nearruz) + "  ساعت : " + date_r  + ":" + time_r ;
                            dr = db.getdatar("select p.name ,p.lname from pezeshk p where  p.id=" + id_p);
                            if (dr.HasRows)
                            {
                                dr.Read();
                                Label12.Text = dr[0].ToString() + " " + dr[1].ToString();
                            }
                            db.Dconect();
                        }
                        else
                        {
                            lblmsg.Text = "نوبت دهی برای شما در این روز امکان پذیر نیست";
                            Label9.Text = "  نوبت های پزشک مورد نظر برای روز  " + dsh.today(nearruz) + "      پر شده است لطفا بعدا اقدام فرمایید";
                            Label10.Visible = false;
                            Label12.Visible = false;
                            Button1.Enabled = false;
                        }
                    }
                }
                else
                    lblmsg.Text = "نوبت دهی برای این تخصص فعلا امکان پذیر نیست";
            }
//=======================================================================================
            else if (Session["type_s"].ToString() == "2")
            {
                dr = db.getdatar("select t.sharh,p.name ,p.lname from takhassos t,pezeshk p where  t.id=p.id_t  and  p.code_n like '" + Session["code_s"].ToString() + "'");
                if (dr.HasRows)
                {
                    dr.Read();
                    Label13.Text = dr[0].ToString();
                    Label12.Text = dr[1].ToString() + " " + dr[2].ToString();
                }
                db.Dconect();

               // int nearruz = 0, today = 0, zarfiyat = 0, start = 0; ;
                today = dsh.today();
                dr = null;
                dr = db.getdatar("select r.*,p.id from ruz r,pezeshk p where  r.id_p=p.id  and  p.code_n like '" + Session["code_s"].ToString() + "'");

                if (dr.HasRows)
                {
                    db.Dconect();
                    nearruz = today;

                    for (int i = 0; i < 6; i++)
                    {
                        if (nearruz < 7)
                            nearruz++;
                        else
                            nearruz = 1;
                        dr3 = db.getdatar("select r.*,p.id from ruz r,pezeshk p where  r.id_p=p.id  and  r.ruz=" + nearruz + "  and   p.code_n like '" + Session["code_s"].ToString() + "'");
                        if (dr3.HasRows)
                        {
                            dr3.Read();
                            id_p = int.Parse(dr3[1].ToString());
                            nearruz = int.Parse(dr3[2].ToString());
                            zarfiyat = int.Parse(dr3[6].ToString());
                            start = int.Parse(dr3[4].ToString());
                            db.Dconect();
                            break;
                        }
                        db.Dconect();

                    }
                    dr2 = db.getdatar("select count(*) as sm from rezerv r,pezeshk p where  r.id_p=p.id and r.ruz=" + nearruz + "  and r.vizit=0 and r.cancel=0 and p.code_n like '" + Session["code_s"].ToString() + "'");
                    if (dr2.HasRows)
                    {
                        dr2.Read();
                        int rezerv = int.Parse(dr2[0].ToString());
                        if (rezerv < zarfiyat)
                        {
                            date_r = ((rezerv * 10 + start * 60) / 60).ToString();
                            time_r = ((float)(rezerv * 10 + 9 * 60) % 60).ToString();
                            Label9.Text = dsh.today(nearruz ) + "  ساعت : " + date_r + ":" + time_r;
                        }
                        else
                        {
                            lblmsg.Text = "نوبت دهی برای شما در این روز امکان پذیر نیست";
                            Label9.Text = "  نوبت های پزشک مورد نظر برای روز  " + dsh.today(nearruz ) + "      پر شده است لطفا بعدا اقدام فرمایید";
                            //Label10.Visible = false;
                            //Label12.Visible = false;
                            Button1.Enabled = false;
                        }

                    }
                    db.Dconect();
                }
                else
                    lblmsg.Text = "نوبت دهی برای این پزشک فعلا امکان پذیر نیست";

            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("main.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (lblmsg.Text.Trim() == "")
        {
            Session["r"] = nearruz.ToString();
            Session["id_p"] = id_p.ToString();
            Session["id_t"] = id_t.ToString();
            Session["d_r"] = dsh.today(nearruz ) ;
            Session["t_r"] = date_r.ToString()+":"+time_r.ToString() ;
            Response.Redirect("nobat.aspx");
        }
    }
}