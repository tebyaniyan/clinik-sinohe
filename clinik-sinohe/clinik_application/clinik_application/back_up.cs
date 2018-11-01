using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clinik-sinohe_application
{
    public partial class back_up : Form
    {
        public back_up()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                textBox1.Text = saveFileDialog1.FileName;            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textboxyello.textboxyelloo(panel1, Color.Yellow))
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=clinik-sinohe;Integrated Security=True");
                DataTable dt = new DataTable();

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "back_up";
                cmd.Parameters.Add("masir", SqlDbType.NVarChar, 0).Value = textBox1.Text;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("فایل پشتیبان ایجاد شد");
                }
                catch
                {
                    MessageBox.Show(" خطا در ایجاد فایل پشتیبان");
                }
            }
 
        }

 
    }
}
