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
    public partial class ruzkar : Form
    {
        public ruzkar()
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

                ds = db.getdataset("select id,name from ruzha");
                ruzha.DataBindings.Clear();
                ruzha.Items.Clear();
                ruzha.DataSource = null;
                ruzha.DataBindings.Add(new Binding("datasource", ds, "c"));
                ruzha.DisplayMember = "name";
                ruzha.ValueMember = "id";
            }
            catch { }
            processed = false;

        }
        private void textheaders()
        {

            dataGridView1.Columns[1].HeaderText = "کد نظام پزشکی";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderText = "نام پزشک ";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "روز";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "ساعت شروع ";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].HeaderText = "ساعت پایان";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].HeaderText = "ظرفیت";
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Visible = false;
            managecolor.cdg(dataGridView1); 
        }
        bool processed = false;
        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!processed)
            {
                dt = db.get("select p.code_n,p.name+' '+p.lname as nm,r.name,rr.start_t,rr.end_t,rr.zarfiyat,rr.id from ruz rr,pezeshk p,ruzha r where rr.id_p=p.id and rr.ruz=r.id and id_p= " + pezeshk.SelectedValue);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = dt;
                    textheaders();
                }
                else
                    dataGridView1.Visible = false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.Value.ToString().Trim() == "حذف")
                {
                    if (MessageBox.Show("ایا روزکار  مورد نظر حذف شود؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.run("delete from ruz where id=" + dataGridView1.CurrentRow.Cells[7].Value.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(textboxyello.textboxyelloo(groupBox4,Color.Yellow))
            {
                dt = db.get("select id from ruz where id_p=" + pezeshk.SelectedValue+"  and ruz="+ruzha.SelectedValue);
                if (dt.Rows.Count == 0)
                {
                    dt = db.get("select id_t from pezeshk where id=" + pezeshk.SelectedValue);
                    db.run("insert into ruz(id_p,ruz,id_t,start_t,end_t,zarfiyat)values(" + pezeshk.SelectedValue + "," + ruzha.SelectedValue + "," + dt.Rows[0][0].ToString() + ",'" + t2.Text + "','" + t3.Text + "'," + t1.Text + ")");
                    model_SelectedIndexChanged(sender, e);
                }
                else
                    MessageBox.Show("این روز قبلا ثبت شده است");

            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleartext.clear(groupBox4);
        }



    }
}
