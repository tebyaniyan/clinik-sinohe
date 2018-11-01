using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Data.SqlClient ;
using System.Data;
using System.Drawing;

/// <summary>
/// Summary description for d_base
/// </summary>
public class d_base
{
    public  string cpath="";
    public d_base()
    {

    }
    SqlCommand cmd;
    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=clinik-sinohe;Integrated Security=True");
    SqlDataAdapter da = new SqlDataAdapter();
    DataTable dt = new DataTable();
    DataSet ds;
    string message = "";
    public void conect()
    {
        con.Open();
    }
    public void Dconect()
    {
        con.Close();
    }
    public string run(string command)
    {
        cmd = new SqlCommand(command, con);
        //try
        //{
        //MessageBox.Show(command);
        if (con.State == ConnectionState.Closed)
            con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
       message ="اطلاعات ثبت شد";

        //}

        //catch
        //{
        //    System.Windows.Forms.MessageBox.Show("خطا در ثبت اطلاعات");


        //    //System.Windows.Forms.MessageBox.Show(command );
        //}
        return message;

    }

    public string run(string command, bool showmessage)
    {
        cmd = new SqlCommand(command, con);
        try
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            if (showmessage)
                message = "اطلاعات ثبت شد";
        }

        catch
        {
            if (showmessage)
                message = "خطا در ثبت اطلاعات";
               // System.Windows.Forms.MessageBox.Show("خطا در ثبت اطلاعات");
        }
        return message;

    }
    public string run_ncd(string command)
    {
        cmd = new SqlCommand(command, con);
        try
        {
            cmd.ExecuteNonQuery();
            message = "اطلاعات ثبت شد";
        }
        catch
        {
            message = "خطا در ثبت اطلاعات";
        }
        return message;
    }
    public DataTable get(string command)
    {
        dt = new DataTable();
        da = new SqlDataAdapter(command, con);
        //try
        //{
        da.Fill(dt);
        //}
        //catch
        //{
        //    System.Windows.Forms.MessageBox.Show("خطا در نمایش اطلاعات");
        //}
        return dt;
    }
    //public Image getdatareader(string command)
    //{
    //    Image img_result = null;
    //    SqlDataReader d;
    //    SqlCommand cmd = new SqlCommand(command, con);
    //    //try
    //    //{
    //    con.Open();
    //    d = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
    //    if (d.Read())
    //    {
    //        MessageBox.Show("yes");
    //        byte[] bytes = (byte[])d.GetValue(1);
    //        //byte[] bytes = memStream1.GetBuffer();
    //        File.WriteAllBytes("c:\\ok.jpg", bytes);
    //        MessageBox.Show(bytes.Length.ToString());
    //        MemoryStream ms = new MemoryStream(bytes);
    //        img_result = new Bitmap(Image.FromStream(ms));
    //    }
    //    else
    //        MessageBox.Show("no");
    //    con.Close();
    //    //}
    //    //catch
    //    //{
    //    //    System.Windows.Forms.MessageBox.Show("خطا در نمایش اطلاعات");
    //    //}
    //    return img_result;
    //}
    public DataSet getdataset(string command)
    {
        ds = new DataSet();
        SqlDataAdapter da2 = new SqlDataAdapter(command, con);
        //MessageBox.Show(command);
        //try
        //{
        da2.Fill(ds, "c");
        //}

        //catch
        //{
        //    System.Windows.Forms.MessageBox.Show("خطا در نمایش اطلاعات");
        //}

        return ds;
    }
    public SqlDataReader getdatar(string command)
    {
        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand(command,con );
        
        //MessageBox.Show(command);
        //try
        //{
        if(con.State !=ConnectionState.Open )
        con.Open();
        dr = cmd.ExecuteReader();
       // con.Close();
        //}

        //catch
        //{
        //    System.Windows.Forms.MessageBox.Show("خطا در نمایش اطلاعات");
        //}

        return dr;
    }
}
