using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.OleDb;
namespace clinik-sinohe_application
{
    public partial class pezeshk : Form
    {
        public pezeshk()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
       }

        private void textheaders()
        {
            dataGridView1.Columns[2].HeaderText = "کد نطام پزشکی";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "تخصص";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "نام ";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].HeaderText = "کد ملی";
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].HeaderText = " تلفن";
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].HeaderText = " آدرس";
            dataGridView1.Columns[8].Width = 250;
            managecolor.cdg(dataGridView1);
        }
        bool update = false;
        string id = "";
        database db = new database();
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textboxyello.textboxyelloo(panel1, Color.Yellow))
            {

                if (update)
                {
                    db.run("update pezeshk set name='" + t1.Text + "' ,lname='" + t2.Text + "' , tell= '" + t4.Text + "' ,  address= '" +t5.Text  + "',code_melli='"+t3.Text+"',code_n='"+t6.Text+"',id_t="+takhassos.SelectedValue.ToString()+"  where id=" + id);
                    update = false;
                    panel2.Visible = true;
                    search();

                }
                else
                {
                    dt = db.get("select *  from pezeshk where name like'" + t1.Text + "' and lname like'" + t2.Text + "'");
                    if (dt.Rows.Count <= 0)
                    {
                        db.run("insert into pezeshk(code_n,id_t,name,lname,code_melli,tell,address) values('"+t6.Text+"',"+takhassos.SelectedValue.ToString()+",'" + t1.Text + "','" + t2.Text + "','"+t3.Text+"','" + t4.Text + "','" + t5.Text + "')");
                    }
                    else
                        MessageBox.Show("این پزشک قبلا ثبت شده است");
                }
            }
            else
                MessageBox.Show("اطلاعات را کامل وارد کنید");
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox9.Enabled = true;
                textBox9.Focus();
                textBox10.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox9.Enabled = false; ;
                textBox10.Enabled = true;
                textBox10.Focus();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox9.Enabled = false;
                textBox10.Enabled = false;
            }
        }
        private void search()
        {
            if (radioButton1.Checked)
                dt = db.get("select p.code_n,t.sharh,p.name,p.lname,p.code_melli,p.tell,p.address,p.id from pezeshk p, takhassos t where t.id=p.id_t and code_n like'" + textBox9.Text+"'");
            else if (radioButton2.Checked)
                dt = db.get("select p.code_n,t.sharh,p.name,p.lname,p.code_melli,p.tell,p.address,p.id from pezeshk p, takhassos t where t.id=p.id_t and  lname like '" + textBox10.Text + "%'");
            else if (radioButton3.Checked)
                dt = db.get("select p.code_n,t.sharh,p.name,p.lname,p.code_melli,p.tell,p.address,p.id from pezeshk p, takhassos t where t.id=p.id_t");
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = dt;
                textheaders();
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            }
            else
                dataGridView1.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textboxyello.textboxyelloo(groupBox4, Color.Yellow))
            {
                search();
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "لغو")
            {
                cleartext.clear(this);
                update = false;
            }
            else
                panel2.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridView1.CurrentCell.Value.ToString().Trim() == "حذف")
                {
                    if (MessageBox.Show("ایا پزشک  مورد نظر حذف شود؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.run("delete from pezeshk where id=" + dataGridView1.CurrentRow.Cells[9].Value.ToString());
                    }
                    search();

                }
                if (dataGridView1.CurrentCell.Value.ToString().Trim() == "ویرایش")
                {
                    panel2.Visible = false;
                    id = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    takhassos.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    t1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    t2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    t3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    t4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    t5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    t6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    button2.Text = "لغو";
                    update = true;
                }
            }
            catch { }

        }

        private void pezeshk_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (rabet.p_view)
            {
                panel2.Visible = true;
                this.Text = "جستجوی پزشکان";
            }
            else
            {
                panel2.Visible = false;
                this.Text = "ثبت پزشک";
            }
            ds = db.getdataset("select id,sharh from takhassos ");
            takhassos.DataBindings.Clear();
            takhassos.DataSource = null;
            takhassos.Items.Clear();
            takhassos.DataBindings.Add(new Binding("datasource", ds, "c"));
            takhassos.DisplayMember = "sharh";
            takhassos.ValueMember = "id";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
