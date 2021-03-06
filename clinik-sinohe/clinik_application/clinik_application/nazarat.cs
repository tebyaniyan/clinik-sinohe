﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace clinik-sinohe_application
{
    public partial class nazarat : Form
    {
        public nazarat()
        {
            InitializeComponent();
            managecolor.loadcolors(this);
        }

        database db = new database();
        DataTable dt = new DataTable();
        private void textheaders()
        {
            dataGridView1.Columns[1].HeaderText = "کد ";
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].HeaderText = "متن  ";
            dataGridView1.Columns[2].Width = 420;
            dataGridView1.Columns[3].HeaderText = "تاریخ ارسال";
            dataGridView1.Columns[3].Width = 110;

            managecolor.cdg(dataGridView1);
        }
        private void search()
        {
            if (radioButton2.Checked)
                dt = db.get("select * from nazarat where readed=0" );
            else if (radioButton4.Checked)
                dt = db.get("select * from nazarat where date like'"+m1.Text+"'");
            else if (radioButton3.Checked)
                dt = db.get("select * from nazarat");
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Visible = true;
                groupBox2.Visible = false;
                dataGridView1.DataSource = dt;
                textheaders();
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;

            }
            else
                dataGridView1.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textboxyello.textboxyelloo(groupBox1, Color.Yellow))
            {
                search();
            }
          
        }


        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                m1.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                m1.Enabled = false;
            }
        }
        date_shamsi ds = new date_shamsi();
        private void radioButton4_CheckedChanged_2(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                m1.Enabled = true;
                m1.Focus();
                m1.Text  = ds.DateShamsi();
            }
        }
        string id = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

               if (dataGridView1.CurrentCell.Value.ToString().Trim() == "نمایش")
                {
                    dataGridView1.Visible = false;
                    groupBox2.Visible = true;
                    id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    t1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    t2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    db.run("update nazarat set readed=1 where id="+id,false);
               }

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                dataGridView1.Visible = true;
                groupBox2.Visible = false;
        }





  
    }
}
