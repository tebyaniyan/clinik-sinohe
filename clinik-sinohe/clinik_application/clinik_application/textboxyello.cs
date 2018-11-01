using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace clinik-sinohe_application
{
     public static class textboxyello
    {
       static  public bool  textboxyelloo(Control CTRL,Color c)
        {
            bool check = true;
           foreach (Control item in CTRL.Controls )
            {
                if (item is TextBox || item is ComboBox || item is MaskedTextBox )
                    if (item.Text.Trim() == "" && item.Enabled && (item.Tag ==null ))
                    {
                        item.BackColor = c;
                        check = false;
                    }
                    else
                    {
                        item.BackColor =Color.White;
                        if (item.Tag != null && item.Tag.ToString() == "22" && item.Enabled)
                        {
                            double  test = 0;
                            try
                            {
                                test = Convert.ToDouble(item.Text.Trim());
                            }
                            catch 
                            {
                                item.BackColor = c;
                                check = false;
                            }                
                        }
                    }
           }
           return check;
        }
    }
}
