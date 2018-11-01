using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    d_base db = new d_base();
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton3.Checked = false;
        RadioButton2.Checked = false;
        DropDownList1.Enabled = true ;
        lastname.Enabled = false;
        DropDownList2.Enabled = false;
        DropDownList1.DataSource = db.getdatar("select * from takhassos");
        DropDownList1.DataTextField = "sharh";
        DropDownList1.DataValueField  = "id";
        DropDownList1.DataBind();
        db.Dconect();
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
       RadioButton1.Checked = false;
       RadioButton3.Checked = false;
        lastname.Enabled = true ;
        DropDownList1.Enabled = false;
        DropDownList2.Enabled = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        Session.Add("type_s", "");
        Session.Add("code_s", "");
        if (RadioButton1.Checked && DropDownList1.Text.Trim() != "")
        {
             
            Session["type_s"] = "1";
            Session["code_s"] = DropDownList1.SelectedValue .ToString();
            Response.Redirect("view_nobat.aspx");

        }
        else if (RadioButton2.Checked && lastname.Text.Trim() != "")
        {
            Session["type_s"] = "2";
            Session["code_s"] = lastname.Text ;
            Response.Redirect("view_nobat.aspx");

        }
        else if (RadioButton3.Checked && DropDownList2.Text.Trim() != "")
            {

                Session["type_s"] = "2";
                Session["code_s"] = DropDownList2.SelectedValue.ToString();
                Response.Redirect("view_nobat.aspx");

            }
        else
            lblmsg.Text  = "اطلاعات را کامل وارد کنید";

    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        DropDownList2.Enabled = true;
        lastname.Enabled = false;
        DropDownList1.Enabled = false;
        DropDownList2.DataSource = db.getdatar("select code_n,name+' ' +lname as nm  from pezeshk");
        DropDownList2.DataTextField = "nm";
        DropDownList2.DataValueField = "code_n";
        DropDownList2.DataBind();
        db.Dconect();
    }
}