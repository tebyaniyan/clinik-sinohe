using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace clinik-sinohe_application
{
    public partial class nobatdehi : Form
    {
        public nobatdehi()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
        }
        database db = new database();
        DataTable dt = new DataTable();
        private void loadmodels()
        {
            processed = true;
            try
            {
                DataSet ds = new DataSet();
                ds = db.getdataset("select id,name+' '+lname as nm from pezeshk");
                pezeshk.DataBindings.Clear();
                pezeshk.Items.Clear();
                pezeshk.DataSource = null;
                pezeshk.DataBindings.Add(new Binding("datasource", ds, "c"));
                pezeshk.DisplayMember = "nm";
                pezeshk.ValueMember = "id";

           }
            catch { }
            processed = false;

        }
        private void textheaders()
        {

            dataGridView1.Columns[1].HeaderText = "کد رزرو";
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].HeaderText = "کد رهگیری ";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "نام";
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].HeaderText = "روز";
            dataGridView1.Columns[5].Width = 90;
            dataGridView1.Columns[6].HeaderText = "ساعت";
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.Columns[7].HeaderText = "تلفن";
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].HeaderText = "آدرس";
            dataGridView1.Columns[8].Width = 190;
            managecolor.cdg(dataGridView1); 
        }
        private void textheaders2()
        {
            dataGridView2.Columns[1].HeaderText = "کد رزرو";
            dataGridView2.Columns[1].Width = 90;
            dataGridView2.Columns[2].HeaderText = "کد رهگیری ";
            dataGridView2.Columns[2].Width = 120;
            dataGridView2.Columns[3].HeaderText = "نام";
            dataGridView2.Columns[3].Width = 90;
            dataGridView2.Columns[4].HeaderText = "نام خانوادگی";
            dataGridView2.Columns[4].Width = 120;
            dataGridView2.Columns[5].HeaderText = "روز";
            dataGridView2.Columns[5].Width = 90;
            dataGridView2.Columns[6].HeaderText = "ساعت";
            dataGridView2.Columns[6].Width = 90;
            dataGridView2.Columns[7].HeaderText = "تلفن";
            dataGridView2.Columns[7].Width = 120;
            dataGridView2.Columns[8].HeaderText = "آدرس";
            dataGridView2.Columns[8].Width = 190;
            managecolor.cdg(dataGridView2);
        }
        bool processed = false;
        date_shamsi dsh = new date_shamsi();
        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dsh.today().ToString());
            //MessageBox.Show(pezeshk.SelectedValue.ToString());
            if (!processed)
            {
                dt = db.get("select id,code_r,name,lname,date_r,time_r,tell,mob from rezerv  where  vizit=0 and cancel=0 and hozur=0 and id_p=" + pezeshk.SelectedValue + " and ruz=" + dsh.today());
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;
                    textheaders();
                }
                else
                    dataGridView1.Visible = false;

                dt = db.get("select id,code_r,name,lname,date_r,time_r,tell,mob from rezerv  where  vizit=0 and cancel=0 and hozur=1 and id_p=" + pezeshk.SelectedValue + " and ruz=" + dsh.today());
                if (dt.Rows.Count > 0)
                {
                    dataGridView2.Visible = true;
                    dataGridView2.DataSource = dt;
                    textheaders2();
                }
                else
                    dataGridView2.Visible = false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.Value.ToString().Trim() == "حضور")
                {
                    if (MessageBox.Show("  ایا " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[4].Value.ToString() + " حضور دارد؟  ", "  حضور  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.run("update rezerv set hozur=1  where id=" + dataGridView1.CurrentRow.Cells[1].Value.ToString());
                        model_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch { }
          }
        private void ruzkar_Load(object sender, EventArgs e)
        {
            loadmodels();
        }
        private void t2_TextChanged(object sender, EventArgs e)
        {
            managecolor.cdg(dataGridView1);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (dataGridView1.Rows[i].Cells[2].Value.ToString() == t2.Text)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                           dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gold;  
                        }
                    }
                }
                catch { }           
            }
        }


        private void t2_Enter(object sender, EventArgs e)
        {
            t2.Clear();
        }

        private void t2_Leave(object sender, EventArgs e)
        {
            t2.Text = "کد رهگیری را وارد کنید";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentCell.Value.ToString().Trim() == "ویزیت شد")
                {
                    if (MessageBox.Show("  ایا " + dataGridView2.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView2.CurrentRow.Cells[4].Value.ToString() + " ویزیت شد؟  ", "  ویزیت   ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.run("update rezerv set vizit=1  where id=" + dataGridView2.CurrentRow.Cells[1].Value.ToString());
                        model_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch { }
        }


    }
}
