using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //= "okokookok";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "salam choni bashi   سلام ";
        Label1.BackColor = System.Drawing.Color.Yellow;
        Button1.Width =100;

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        l2.Text += DropDownList1.SelectedItem;
        //Response.Write("<br/>")+;
    }
}
