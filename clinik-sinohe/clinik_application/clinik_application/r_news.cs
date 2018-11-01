using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clinik-sinohe_application
{
    public partial class r_news : Form
    {
        public r_news()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
        }

        private void r_news_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleartext.clear(panel1);
        }
        database db = new database();
        date_shamsi ds = new date_shamsi();
        private void button2_Click(object sender, EventArgs e)
        {
            if (textboxyello.textboxyelloo(panel1, Color.Yellow))
            {
                db.run("insert into news (title,matn,date_n,hide)values('"+t1.Text+"','"+t2.Text+"','"+ds.DateShamsi()+"',0)");
                
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }
    }
}
