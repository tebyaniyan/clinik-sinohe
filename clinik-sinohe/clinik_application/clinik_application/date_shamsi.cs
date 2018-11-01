using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace clinik-sinohe_application
{
    class date_shamsi
    {
        public string DateShamsi()
        {
        //    int T;
            string S;
            //T = ValDayMiladi();
            //S = ValDaySal(T - 226900);
            PersianCalendar p = new PersianCalendar();
            S = p.GetYear(System.DateTime.Now) + "/" + p.GetMonth(System.DateTime.Now) + "/" + p.GetDayOfMonth(System.DateTime.Now) ;
            return S;
        }
        public int today()
        {
            string today = "";
            int t = 0;
            today = System.DateTime.Now.DayOfWeek.ToString();
            switch (today)
            {
                case "Saturday":
                    t = 1; break;
                case "Sunday":
                    t = 2; break;
                case "Monday":
                    t = 3; break;
                case "Tuesday":
                    t = 4; break;
                case "Wednesday":
                    t = 5; break;
                case "Thursday":
                    t = 6; break;
                case "Friday":
                    t = 7; break;
            }

            return t ;
        }
        public string today(int today)
        {
            string t = "";
            switch (today)
            {
                case 1:
                    t = "شنبه"; break;
                case 2:
                    t = "یکشنبه"; break;
                case 3:
                    t = "دوشنبه"; break;
                case 4:
                    t = "سه شنبه"; break;
                case 5:
                    t = "چهارشنبه"; break;
                case 6:
                    t = "پنجشنبه"; break;
                case 7:
                    t = "جمعه"; break;
            }
            return t;
        }
        public string time()
        {
            return DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }




        private int ValDayMiladi()
        {
            int [] x = new int [3];
            byte[] v = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };
            byte i;
            int  sum = 0;
            x[0] = int.Parse (DateTime.Now.Year.ToString());
            x[1] = int.Parse(DateTime.Now.Month.ToString());
            x[2] = int.Parse(DateTime.Now.Day.ToString());

            if (x[1] == 1)
            {
                sum = x[2];
                x[2] = 0;
            }
            else
                for (i = 0; i <= x[1] - 2; i++)
                {
                    sum = sum + v[i];
                }

            int result = 0;
            result = x[0] * 365 + x[0] / 4 + 1 + sum + x[2];
            return result;

        }
        private string ValDaySal(int Digit)
        {
            int x, y, z, a;

            string str;
            x = Digit;
            y = (int )(((float)(4 * x)) / ((float)((4 * 365) + 1)));
            z = (int )(((float)(y * 365)) + ((float)(y / 4)));
            a = x - z;
            str = TarikhShamsi(a);
            if (a == 0)
                y=y-1;
          
            return y.ToString() + "/" + str;

        }
        private string TarikhShamsi(int b)
        {
            int[] v = { 31, 62, 93, 124, 155, 186, 216, 246, 276, 306, 336, 365 };
            int Mon, Day, i;
            if (b == 366 || b == 0)
            {
                Mon = 12;
                Day = 30;
            }
            else
            {
                Mon = 1;
                Day = b;
                for (i = 10; i > 0; i--)
                {
                    if (b > v[i])
                        if (b != v[i + 1])
                        {
                            Mon = i + 2;
                            Day = b - v[i];
                            break;
                        }
                        else
                        {
                            Mon = i + 2;
                            Day = v[i + 1] - v[i];
                            break;
                        }
                }

            }
            string mmmm="",dddd="";

            if (Mon < 10)
                mmmm = "0" + Mon.ToString();
            else
                mmmm = Mon.ToString();

            if (Day < 10)
                dddd = "0" + Day.ToString();
            else
                dddd = Day.ToString();

            return mmmm + "/" + dddd ;
        }
    }
}
