using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skaki
{
    public partial class Form1 : Form
    {
        public static string player1;
        public static string player2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("fill out both names");
            }
            else
            {
                player1 = textBox1.Text;
                player2 = textBox2.Text;
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
        }
    }

}
