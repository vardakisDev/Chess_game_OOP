using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skaki.lib
{
    //white player implements pawn interface
    class Player 
    {
        private bool isBlack;
        private int time = 1800;
        private Point currentPoint;
        public bool moving;
        public Timer timerWhite;
        


        public Player(bool isBlack)
        {
            this.isBlack = isBlack;
            timerWhite = new Timer();
            timerWhite.Interval = 1000;
            timerWhite.Tick += new EventHandler(timer_tick);
        }



        public void Mouse_down(object sender, MouseEventArgs e)
        { 
            currentPoint =  e.Location;
            this.moving = true;
            timerWhite.Enabled = true;
        }

        public Point Mouse_move(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                PictureBox box = sender as PictureBox;
                return new Point(box.Left + e.X - currentPoint.X, box.Top + e.Y - currentPoint.Y);

            }
            return (sender as PictureBox).Location;
           
        }

        public void Mouse_up(object sender, MouseEventArgs e)
        {
            this.moving = false;
            timerWhite.Enabled = false;
        }

        public void timer_tick(Object myObject,
                                            EventArgs myEventArgs)
        {
            Label target;
            if (isBlack)
            {
                 target = (Label)Application.OpenForms["Form2"].Controls.Find("label6", false).FirstOrDefault();
            }
            else { 
                 target = (Label)Application.OpenForms["Form2"].Controls.Find("label8", false).FirstOrDefault(); 
            }

            if (time > 0)
            {
                time--;
                    target.Text =  time/ 60 + ":" + ((time % 60) >= 10 ? (time % 60).ToString() : "0" + time % 60);
                
            }
            else
            {
                MessageBox.Show("Player Run out of time");
                target.Text = "0";
            }
        }

        
    }
}
