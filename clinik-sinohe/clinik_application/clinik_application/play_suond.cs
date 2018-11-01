using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
namespace clinik-sinohe_application
{
    public static  class play_suond
    {
        public static bool play = true;
        public static void play_s(string path)
        {
            if (play)
            {
                try
                {
                    SoundPlayer p = new SoundPlayer(path);
                    p.Play();
                }
                catch { }         
            }
        }
    }
}
