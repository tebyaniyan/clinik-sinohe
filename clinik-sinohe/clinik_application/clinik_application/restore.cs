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
    public partial class restore : Form
    {
        public restore()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = openFileDialog1.FileName;

        }
        database db = new database();
        private void button2_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand();
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=clinik-sinohe;Integrated Security=True");

            //cmd = new SqlCommand("RESTORE DATABASE [clinik-sinohe] FROM  DISK = N'" + textBox1.Text + "' WITH  FILE = 1,  NOUNLOAD,  STATS = 10", con);
            ////try
            ////{
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    System.Windows.Forms.MessageBox.Show("اطلاعات ثبت شد");

            //}

            //catch
            //{
            //    System.Windows.Forms.MessageBox.Show("خطا در ثبت اطلاعات");
            //}
            if (textboxyello.textboxyelloo(panel1, Color.Yellow))
            {
                db.run("RESTORE DATABASE [clinik-sinohe] FROM  DISK = N'" + textBox1.Text + "' WITH  FILE = 1,  NOUNLOAD,  STATS = 10 ");
            }

        }
    }
}
