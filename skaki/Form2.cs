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
        
        //white player
        Player white_player;
        //black player
        Player black_player;

        public Form2()
        {   
            InitializeComponent();
            //iniate both players
            white_player  = new Player(false);
            black_player = new Player(true);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.player1;
            label5.Text = Form1.player2;
            Game newGame = new Game(Form1.player1, Form1.player2);
            newGame.saveToDB();
            timer1.Start();
            
        }
        private void Black_MouseDown(object sender, MouseEventArgs e)
        {
            black_player.Mouse_down(sender, e);
            
        }

        private void Black_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as PictureBox).Location = black_player.Mouse_move(sender, e);
        }

        private void Black_MouseUp(object sender, MouseEventArgs e)
        {
            black_player.Mouse_up(sender, e);
            black_player.timerOfPlayer.Enabled = false;
            white_player.timerOfPlayer.Enabled = true;

        }

        private void White_MouseDown(object sender, MouseEventArgs e)
        {
            white_player.Mouse_down(sender,e);

            
        }

        private void White_MouseMove(object sender, MouseEventArgs e)
        { 
            (sender as PictureBox).Location = white_player.Mouse_move(sender, e);
        }

        private void White_MouseUp(object sender, MouseEventArgs e)
        {
            white_player.Mouse_up(sender, e);
            white_player.timerOfPlayer.Enabled = false;
            black_player.timerOfPlayer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
