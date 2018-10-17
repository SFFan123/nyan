using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nyanCat
{
    public partial class Form1 : Form
    {

        int geschwindigkeit = 1;

        int index = 0;

        Random r = new Random(153456);

        static int catsCount = 0;
        static List<Image> images = new List<Image>();


        public Form1()
        {
            InitializeComponent();

            if (catsCount == 0)
            {

                #region rechts

                images.Add(Properties.Resources.nyan);
                images.Add(Properties.Resources.america);

                images.Add(Properties.Resources.balloon);

                images.Add(Properties.Resources.bday);
                images.Add(Properties.Resources.daft);
                images.Add(Properties.Resources.dub);
                images.Add(Properties.Resources.easter);
                images.Add(Properties.Resources.fiesta);
                images.Add(Properties.Resources.gb);
                images.Add(Properties.Resources.grumpy);
                images.Add(Properties.Resources.j5);
                images.Add(Properties.Resources.jamaicnyan);
                images.Add(Properties.Resources.jazz);
                images.Add(Properties.Resources.melon);
                images.Add(Properties.Resources.mexinyan);
                images.Add(Properties.Resources.mummy);
                images.Add(Properties.Resources.newyear);
                images.Add(Properties.Resources.nyancoin);
                images.Add(Properties.Resources.nyaninja);
                images.Add(Properties.Resources.paddy);
                images.Add(Properties.Resources.pikanyan);
                images.Add(Properties.Resources.pirate);
                images.Add(Properties.Resources.pumpkin);
                images.Add(Properties.Resources.retro);
                images.Add(Properties.Resources.sad);
                images.Add(Properties.Resources.tacnayn);
                images.Add(Properties.Resources.technyancolor);
                images.Add(Properties.Resources.vday);
                images.Add(Properties.Resources.xmas);
                images.Add(Properties.Resources.zombie);

                #endregion

                #region links

                images.Add(Properties.Resources.nyan1);
                images.Add(Properties.Resources.america1);

                images.Add(Properties.Resources.balloon1);

                images.Add(Properties.Resources.bday1);
                images.Add(Properties.Resources.daft1);
                images.Add(Properties.Resources.dub1);
                images.Add(Properties.Resources.easter1);
                images.Add(Properties.Resources.fiesta1);
                images.Add(Properties.Resources.gb1);
                images.Add(Properties.Resources.grumpy1);
                images.Add(Properties.Resources.j51);
                images.Add(Properties.Resources.jamaicnyan1);
                images.Add(Properties.Resources.jazz1);
                images.Add(Properties.Resources.melon1);
                images.Add(Properties.Resources.mexinyan1);
                images.Add(Properties.Resources.mummy1);
                images.Add(Properties.Resources.newyear1);
                images.Add(Properties.Resources.nyancoin1);
                images.Add(Properties.Resources.nyaninja1);
                images.Add(Properties.Resources.paddy1);
                images.Add(Properties.Resources.pikanyan1);
                images.Add(Properties.Resources.pirate1);
                images.Add(Properties.Resources.pumpkin1);
                images.Add(Properties.Resources.retro1);
                images.Add(Properties.Resources.sad1);
                images.Add(Properties.Resources.tacnayn1);
                images.Add(Properties.Resources.technyancolor1);
                images.Add(Properties.Resources.vday1);
                images.Add(Properties.Resources.xmas1);
                images.Add(Properties.Resources.zombie1);

                #endregion

                #region unten

                images.Add(Properties.Resources.nyan2);
                images.Add(Properties.Resources.america2);

                images.Add(Properties.Resources.balloon);

                images.Add(Properties.Resources.bday2);
                images.Add(Properties.Resources.daft2);
                images.Add(Properties.Resources.dub2);
                images.Add(Properties.Resources.easter2);
                images.Add(Properties.Resources.fiesta2);
                images.Add(Properties.Resources.gb2);
                images.Add(Properties.Resources.grumpy2);
                images.Add(Properties.Resources.j52);
                images.Add(Properties.Resources.jamaicnyan2);
                images.Add(Properties.Resources.jazz2);
                images.Add(Properties.Resources.melon2);
                images.Add(Properties.Resources.mexinyan2);
                images.Add(Properties.Resources.mummy2);
                images.Add(Properties.Resources.newyear2);
                images.Add(Properties.Resources.nyancoin2);
                images.Add(Properties.Resources.nyaninja2);
                images.Add(Properties.Resources.paddy2);
                images.Add(Properties.Resources.pikanyan2);
                images.Add(Properties.Resources.pirate2);
                images.Add(Properties.Resources.pumpkin2);
                images.Add(Properties.Resources.retro2);
                images.Add(Properties.Resources.sad2);
                images.Add(Properties.Resources.tacnayn2);
                images.Add(Properties.Resources.technyancolor2);
                images.Add(Properties.Resources.vday2);
                images.Add(Properties.Resources.xmas2);
                images.Add(Properties.Resources.zombie2);

                #endregion

                #region oben

                images.Add(Properties.Resources.nyan3);
                images.Add(Properties.Resources.america3);

                images.Add(Properties.Resources.balloon);

                images.Add(Properties.Resources.bday3);
                images.Add(Properties.Resources.daft3);
                images.Add(Properties.Resources.dub3);
                images.Add(Properties.Resources.easter3);
                images.Add(Properties.Resources.fiesta3);
                images.Add(Properties.Resources.gb3);
                images.Add(Properties.Resources.grumpy3);
                images.Add(Properties.Resources.j53);
                images.Add(Properties.Resources.jamaicnyan3);
                images.Add(Properties.Resources.jazz3);
                images.Add(Properties.Resources.melon3);
                images.Add(Properties.Resources.mexinyan3);
                images.Add(Properties.Resources.mummy3);
                images.Add(Properties.Resources.newyear3);
                images.Add(Properties.Resources.nyancoin3);
                images.Add(Properties.Resources.nyaninja3);
                images.Add(Properties.Resources.paddy3);
                images.Add(Properties.Resources.pikanyan3);
                images.Add(Properties.Resources.pirate3);
                images.Add(Properties.Resources.pumpkin3);
                images.Add(Properties.Resources.retro3);
                images.Add(Properties.Resources.sad3);
                images.Add(Properties.Resources.tacnayn3);
                images.Add(Properties.Resources.technyancolor3);
                images.Add(Properties.Resources.vday3);
                images.Add(Properties.Resources.xmas3);
                images.Add(Properties.Resources.zombie3);

                #endregion

                // sonstiges
                images.Add(Properties.Resources.wtf);

            }

            catsCount++;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            setStart();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(new Random(12378956).Next(0, Screen.PrimaryScreen.WorkingArea.Width), new Random(32423423).Next(0, Screen.PrimaryScreen.WorkingArea.Height));

            //timer1.Start();           

        }

        private int getGeschwindigkeit()
        {
            return new Random().Next(7, 21);
        }


        private void setStart()
        {

            // Random Bild (jew 31 Bilder + 1)
            index = new Random().Next(0, images.Count);
            pictureBox1.Image = images[index];

            geschwindigkeit = getGeschwindigkeit();


            if (index < 30 || index == (images.Count - 1))
            {
                // Rechts
                this.Location = new Point(0 - this.Width, r.Next(0, (Screen.PrimaryScreen.WorkingArea.Height - this.Height)));

            }
            else if (index >= 30 && index < 60)
            {
                // Links
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width, r.Next(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height));

            }
            else if (index >= 60 && index < 90)
            {
                // Unten
                this.Location = new Point(r.Next(0, Screen.PrimaryScreen.WorkingArea.Width - this.Width), 0 - this.Height);

            }
            else if (index >= 90 && index < 120)
            {
                // Oben
                this.Location = new Point(r.Next(0, Screen.PrimaryScreen.WorkingArea.Width - this.Width), Screen.PrimaryScreen.WorkingArea.Height);

            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (index < 30 || index == (images.Count - 1))
            {
                // Rechts
                this.Location = new Point((Location.X + geschwindigkeit), Location.Y);

                if (this.Location.X > Screen.PrimaryScreen.WorkingArea.Width)
                    setStart();

            }
            else if (index >= 30 && index < 60)
            {
                // Links
                this.Location = new Point((Location.X - geschwindigkeit), Location.Y);

                if (this.Location.X < (0 - this.Width))
                    setStart();

            }
            else if (index >= 60 && index < 90)
            {
                // Unten
                this.Location = new Point(Location.X, (Location.Y + geschwindigkeit));

                if (this.Location.Y > Screen.PrimaryScreen.WorkingArea.Height)
                    setStart();

            }
            else if (index >= 90 && index < 120)
            {
                // Oben
                this.Location = new Point(Location.X, (Location.Y - geschwindigkeit));

                if (this.Location.Y < (0 - this.Height))
                    setStart();

            }
            
        }


        private void mouseClicked(object sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (catsCount < 8)
                {

                    try
                    {

                        createNewWindow();

                        // new Thread(createNewWindow).Start();

                        /*
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            new Form1().ShowDialog();

                        }).Start();
                        */
                    }
                    catch (Exception)
                    {
                    }
                    
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
            catsCount--;
            this.Dispose();
        }


        private void createNewWindow()
        {
            Form1 newCat = new Form1();
            newCat.Show();  // Dialog();
        }


        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Index: " + index);
        }

    }
}
