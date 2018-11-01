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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textboxyello.textboxyelloo(panel2, Color.Yellow))
            {
                label5.Text = "";
                database db = new database();
                DataTable dt = new DataTable();
                dt = db.get("select username,password,usertype from [user] where username like'" + textBox3.Text + "' and  password like'" + textBox4.Text + "'");
                if (dt.Rows.Count != 0)
                {
                    play_suond.play_s("sounds/Speech On.wav");
                    rabet.username = dt.Rows[0][0].ToString();
                    rabet.usertype = dt.Rows[0][2].ToString();
                    this.Close();
                }
                else
                    label5.Text = "نام کاربری یا رمز عبور اشتباه است";
            }
            
        }
        int pic27 = 1;
        int jolo = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic27 <= 40)
            {
                pictureBox27.Location = new Point(pictureBox27.Location.X + jolo , pictureBox27.Location.Y);
                pic27++;
            }
            else
            {
                pic27 = 1;
                jolo *= -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ایا برای خروج مطمئن هستید؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
