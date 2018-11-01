using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace clinik-sinohe_application
{
    public static  class managecolor
    {
       static public  void loadcolors(Control ctrl )
        {
            if (ctrl is Form || ctrl is MenuStrip  )
            {
                ctrl.BackColor = rabet.c1;
                ctrl.ForeColor = rabet.c3;
            }

            foreach (Control item in ctrl.Controls)
            {
                if (item is TabPage || item is GroupBox || item is ToolStripMenuItem || item is DomainUpDown)
                    item.BackColor = rabet.c2;
                if (item is Panel && item.Tag != null && item.Tag.ToString() == "2")
                    item.BackColor = rabet.c1;
                else if (item is Panel)
                    item.BackColor = rabet.c2;
            }


            foreach (Control item in ctrl.Controls)
                 if (item is GroupBox || item is Panel || item is TabControl || item is MenuStrip || item is DataGridView)
                    loadcolors(item);

        }
       static public void cdg(Control ctrl)
       {
           if (ctrl is DataGridView)
           {
               DataGridView dg=(DataGridView) ctrl ;
               dg.BackgroundColor = rabet.c2;
               dg.GridColor = rabet.c1;
               for (int i = 0; i < dg.Columns.Count; i++)
               {

                       dg.Columns[i].DefaultCellStyle.BackColor = rabet.c2;
               }


               for (int i = 0; i < dg.Rows.Count; i++)
               {
                   for (int j = 0; j < dg.Rows[i].Cells.Count; j++)
                   {
                       Color r = dg.Columns[j].DefaultCellStyle.BackColor;

                       if(i%2==0)
                           dg.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(Math.Abs(rabet.c2.R - 40), Math.Abs(rabet.c2.G - 55), Math.Abs(rabet.c2.B - 40));
                       else
                               dg.Rows[i].Cells[j].Style.BackColor = rabet.c2;
                   }
               }
               dg.Rows[0].Cells[0].Selected = false;
               dg.Rows[dg.Rows.Count-1].Cells[0].Selected=true;
           }
       
       }
    }
}
