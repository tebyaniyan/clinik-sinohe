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
            Random r = new Random();
            Int64 c = r.Next(900000000) + 100000000;
            lblmsg0.Text = "کد رهگیری :" + c.ToString();
            lblmsg.Text=db.run("insert into soalat (code_r,soal, date) values('"+c.ToString()+"','"+c_r.Text+"','"+dsh.DateShamsi()+"') ");
            Button1.Enabled = false; 
        }
        else
            lblmsg.Text = "متن خود را وارد کنید";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (c_.Text.Trim() != "")
        {
            SqlDataReader sr = db.getdatar("select * from soalat where code_r like'" + c_.Text + "' ");
            if (sr.HasRows)
            {
                sr.Read();
                // global::System.Windows.Forms.MessageBox.Show("Test");
                if (sr[3].ToString() != "" )
                {
                    soal.Text = sr[2].ToString(); soal.Enabled = true;
                    javab.Text = sr[3].ToString(); javab.Enabled = true;


                }
                else
                    lblmsg1.Text = "هنوز به سوال شما پاسخی نداده شده است";

            }
            else
                lblmsg1.Text = "کد رهگیری اشتباه است";

        }
        else
            lblmsg1.Text = "کد رهگیری را وارد کنید";
    }
}