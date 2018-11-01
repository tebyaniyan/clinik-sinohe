using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace clinik-sinohe_application
{
    public static class cleartext
    {
        static public void clear(Control CTRL)
        {
            foreach (Control item in CTRL.Controls)
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                    item.BackColor = Color.White;
                }
            foreach (Control item in CTRL.Controls)
                if (item is GroupBox || item is Panel || item is TabControl || item is MenuStrip)
                   clear (item);
        }
    }
}
