using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyanCat
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Stream str = Properties.Resources.nyan_beat;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Thread.Sleep(2700);
                str = Properties.Resources.nyan_loop;
                snd = new System.Media.SoundPlayer(str);
                
                snd.PlayLooping();
            }).Start();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());

            

           
        }
    }
}
