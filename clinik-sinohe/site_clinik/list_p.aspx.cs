using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    d_base db = new d_base();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = db.getdatar("select t.sharh as 'تخصص' ,p.name as 'نام ',p.lname as 'نام خانوادگی', p.code_n as 'شماره نظام پزشکی'  from pezeshk p , takhassos t  where p.id_t=t.id  ");
        GridView1.DataBind();
        db.Dconect();

        GridView2.DataSource = db.getdatar("select t.sharh as 'تخصص' ,p.name as 'نام ',p.lname as 'نام خانوادگی', r.name  as ' روز حضور'  from pezeshk p , takhassos t, ruzha r,ruz rr   where rr.id_t=t.id  and rr.id_p=p.id and r.id=rr.ruz ");
        GridView2.DataBind();
        db.Dconect();
    }
}