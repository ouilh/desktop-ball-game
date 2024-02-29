using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;



namespace mini_game2
{
    public partial class Form1 : Form
    {
        
        int speed = 0;
        int gravity = 0;
        
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        WindowsMediaPlayer player3 = new WindowsMediaPlayer();
        control co = new control();
        public Form1()
        {
            InitializeComponent();
        }
        void endgame()
        {
            panel1.Show();
            timer1.Stop();
            player3.URL = ("lose.mp3");
            player.controls.stop();
            player3.controls.play();

        }
        private void timergame(object sender, EventArgs e)
        {
            pictureBox1.Top += gravity;
            pictureBox5.Left -= speed;
            pictureBox3.Left -= speed;
            pictureBox4.Left -= speed;
            pictureBox6.Left -= speed;
            pictureBox7.Left -= speed;
            pictureBox8.Left -= speed;
            
            
            
            if (pictureBox6.Left > -6)
            {
                pictureBox6.Left = -6;
                pictureBox5.Left = 455;
                pictureBox3.Left = 231;
                pictureBox4.Left = 890;
                pictureBox7.Left = 962;
                

            }
            if (pictureBox1.Top < 400)
            {
                gravity = 20; 
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox1.Top = 651;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox1.Left = 58;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                endgame();
            }
            
                
            
            if (pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                panel2.Show();
                timer1.Stop();
                player.controls.stop();
                player2.URL = ("lvl1.mp3");
                player2.controls.play();
            }
           
            
           
        }

        private void keyisdown(object sender, KeyEventArgs e)
           
        {
            var n = Keys.Z;
            
            if (co.UP == "z" || co.UP =="Z")
            {
                 n = Keys.Z;
            }
            else if (co.UP == "e" || co.UP =="E")
            {
                 n = Keys.E;
            }


            if (e.KeyCode == Keys.Up  || e.KeyCode==n)
            {
                gravity = -20;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Q)
            {
                speed = -20;
                
            }
            
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                speed = 20;
               
            }
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            panel1.Hide();
            panel2.Hide();
            button11.Hide();
          //  co.UP = "z";
            





            pictureBox8.Left = 1900;

           
            player.URL = ("Hollow Knight OST - The White Lady.mp3");
            player.controls.play();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player3.controls.stop();
            this.Hide();
            lvl_2 l2 = new lvl_2();
            l2.Show();
            player.controls.play();
            
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
                player.controls.stop();
               
                button6.Hide();
                button11.Show();
            
          
            
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player.controls.play();
            button11.Hide();
            button6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            panel3.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            setting s = new setting();
            s.Show();
            co.UP = "z";
        }
    }
}
