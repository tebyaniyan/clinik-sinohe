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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
        }
        date_shamsi dt_sh = new date_shamsi();
        private void loadingitems()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = menuStrip1.ForeColor;
                foreach (ToolStripItem item2 in item.DropDownItems)
                {
                    item2.BackColor = menuStrip1.BackColor;
                    item2.ForeColor = menuStrip1.ForeColor;
                }
            }
            label1.BackColor = label2.BackColor = label3.BackColor = menuStrip1.BackColor;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = menuStrip1.ForeColor;
            label3.Text = dt_sh.time();
            label1.Text = dt_sh.DateShamsi() + "  " + dt_sh.today(dt_sh.today());

            while (this.Opacity < 1)
            {
                this.Opacity += 0.001;
                for (int i = 0; i < 300000; i++) ;
                Application.DoEvents();
            }

            menuStrip1.Enabled = false;
            panel1.Enabled = false;
            login f = new login();
            formshow(f);
 
        }
        private void formshow(Form f)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            f.MdiParent = this;
            f.Show();
            f.Focus();
            play_suond.play_s("sounds/Windows Minimize.wav");
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا برای خروج مطمئن هستید؟", "تایید خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = dt_sh.time();
            label1.Text = dt_sh.DateShamsi() + "  " + dt_sh.today(dt_sh.today());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingitems();
        }

        private void ایجادفایلپشتبانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            back_up f = new back_up();
            formshow(f);
        }

        private void فراخوانیفایلپشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restore f = new restore();
            formshow(f);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا برای خروج مطمئن هستید؟", "تایید خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes)
                Application.Exit();
        }
      public bool minimizef = false;
      private void pictureBox2_Click(object sender, EventArgs e)
      {
          
          this.WindowState = FormWindowState.Normal;
          while (this.Location.Y < 700)
          {
              this.Location = new Point(this.Location.X, this.Location.Y + 1);
              Application.DoEvents();
              for (int i = 0; i < 70000; i++) ;
          }
          this.WindowState = FormWindowState.Minimized;
          //for (int i = 0; i < Application.OpenForms.Count; i++)
          //{
          //    Application.OpenForms[i].WindowState = FormWindowState.Minimized;              
          //}
          Application.DoEvents();
          minimizef = true;
      }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pp=(PictureBox)sender;
            pp.Size = new Size(pp.Size.Width + 5, pp.Size.Height + 5);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pp = (PictureBox)sender;
            pp.Size = new Size(pp.Size.Width + 5, pp.Size.Height + 5);
        }

        private void p1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pp = (PictureBox)sender;
            pp.Size = new Size(pp.Size.Width + 5, pp.Size.Height + 5);
        }

        private void p2_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pp = (PictureBox)sender;
            pp.Size = new Size(pp.Size.Width + 5, pp.Size.Height + 5);
        }

        private void p1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pp = (PictureBox)sender;
            pp.Size = new Size(pp.Size.Width - 5, pp.Size.Height - 5);
        }

        private void p2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pp = (PictureBox)sender;
            pp.Size = new Size(pp.Size.Width - 5, pp.Size.Height - 5);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pp = (PictureBox)sender;
            pp.Size = new Size(pp.Size.Width - 5, pp.Size.Height - 5);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pp = (PictureBox)sender;
            pp.Size = new Size(pp.Size.Width - 5, pp.Size.Height - 5);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (minimizef)
            {
                this.WindowState = FormWindowState.Normal;
                while (this.Location.Y > 20)
                {
                    this.Location = new Point(this.Location.X, this.Location.Y - 7);
                    Application.DoEvents();
                    for (int i = 0; i < 500000; i++) ;
                }
                this.Location = new Point(0, 0);
                minimizef = false;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (!minimizef)
                {

                    play_suond.play_s("sounds/Speech Off.wav");
                    while (this.Opacity >0)
                    {
                        this.Opacity -= 0.001;
                        for (int i = 0; i < 250000; i++) ;
                        Application.DoEvents();
                    }
                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rabet.username != "")
            {
                label4.Text = rabet.username;
                
                panel1.Enabled = true;
                menuStrip1.Enabled = true;
                if (rabet.username == "karbar1")
                {
                    mpezeshk.Enabled = false;
                    mnazarat.Enabled = false;
                    msoalat.Enabled = false;
                    mnews.Enabled = false;
                    mlnobat.Enabled = false;
                    mbackup.Enabled = false;
                    mrestore.Enabled = false;
                }
                timer2.Enabled = false;            
            }
        }

        private void نمایشنظراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nazarat f = new nazarat();
            formshow(f);
        }

        private void نمایشسوالاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soalat f = new soalat();
            formshow(f);
        }

        private void ثبتپزشکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rabet.p_view = false;
            pezeshk f = new pezeshk();
            formshow(f);
        }

        private void جستجویپزشکانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rabet.p_view = true;
            pezeshk f = new pezeshk();
            formshow(f);
        }

        private void ثبتروزهایکاریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ruzkar f = new ruzkar();
            formshow(f);
        }

        private void ثبتخبرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r_news f = new r_news();
            formshow(f);
        }

        private void نمایشاخبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            news f = new news();
            formshow(f);
        }

        private void p1_Click(object sender, EventArgs e)
        {
            nobatdehi f = new nobatdehi();
            formshow(f);
        }

       private void نوبتدهیToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nobatdehi f = new nobatdehi();
            formshow(f);
        }

       private void لغونوبتهاازلیستآخروقتToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("با انجام این کار همه نوبت های امروز لغو میشوند\nاین کار را در آخر وقت جهت لغو همه نوبت های روز انجام دهید مراجعه کنندگان و کسانی که مراجعه نکرده اند از لیست رزرو ها حذف میشوند  ", "  ویزیت   ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               database db = new database();
               db.run("delete from rezerv where ruz="+dt_sh.today());           
           }
       }


    }
}
