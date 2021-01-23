using skaki.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace skaki
{
    public partial class Form2 : Form
    {
        int time1 = 1800;
        int time2 = 1800;
        //white player
        Player player1;
        //black player
        Player player2;

        public Form2()
        {   
            InitializeComponent();
            //iniate both players
            player1  = new Player(true);
            player2 = new Player(false);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.player1;
            label5.Text = Form1.player2;
            timer1.Start();
            
        }
        private void Black_MouseDown(object sender, MouseEventArgs e)
        {
            player2.Mouse_down(sender, e);
            player2.timerWhite.Enabled = false;
            player1.timerWhite.Enabled = true;
        }

        private void Black_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as PictureBox).Location = player2.Mouse_move(sender, e);
        }

        private void Black_MouseUp(object sender, MouseEventArgs e)
        {
            player2.Mouse_up(sender, e);
 
        }

        private void White_MouseDown(object sender, MouseEventArgs e)
        {
            player1.Mouse_down(sender,e);
            player1.timerWhite.Enabled = false;
            player2.timerWhite.Enabled = true;
        }

        private void White_MouseMove(object sender, MouseEventArgs e)
        { 
            (sender as PictureBox).Location = player1.Mouse_move(sender, e);
        }

        private void White_MouseUp(object sender, MouseEventArgs e)
        {
            player1.moving = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString();
        }



  
    }
}
