using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace clinik-sinohe_application
{
    class database
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=clinik-sinohe;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds;
        string message="";
        public string run(string command)
        {
            cmd = new SqlCommand(command,con);
            try
            {
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            System.Windows.Forms.MessageBox.Show("اطلاعات ثبت شد");
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("خطا در ثبت اطلاعات");
            }
            return message;
        
        }
        public string run(string command,bool showmsg)
        {
            cmd = new SqlCommand(command, con);
            try
            {
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            }

            catch
            {
            }
            return message;

        }
        public DataTable  get(string command)
        {
            dt = new DataTable();
            da = new SqlDataAdapter(command,con);
            try
            {
                da.Fill(dt);
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("خطا در نمایش اطلاعات");
            }

            return dt;
        }
        public DataSet  getdataset(string command)
        {
            ds = new DataSet();
            da = new SqlDataAdapter(command, con);
            try
            {
                da.Fill(ds,"c");
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("خطا در نمایش اطلاعات");
            }

            return ds;
        }
    }
}
