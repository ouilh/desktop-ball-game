using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace mini_game2
{
    public partial class lvl_2 : Form
    {
        control co = new control();
        int speed = 0;
        int gravity = 0;
        int i = 0;
        WindowsMediaPlayer player5 = new WindowsMediaPlayer();
        WindowsMediaPlayer player6 = new WindowsMediaPlayer();
        WindowsMediaPlayer player7 = new WindowsMediaPlayer();
        




        public lvl_2()
        {
            InitializeComponent();
        }

        private void timergame(object sender, EventArgs e)
        {
            coints c = new coints();

            pictureBox5.Top += gravity;
            if (pictureBox8.Left == 58)
            {


                pictureBox8.Top += (gravity - 5);
            }
            //pictureBox5.Left += speed;
            pictureBox2.Left -= speed;
            pictureBox6.Left -= speed;
            pictureBox7.Left -= speed;
            pictureBox4.Left -= speed;
            pictureBox3.Left -= speed;
            pictureBox9.Left -= speed;
            if (pictureBox2.Left > -6)
            {
                pictureBox5.Left = 58;
                pictureBox2.Left = -6;
                pictureBox3.Left = 1120;
                pictureBox4.Left = 1120;
                pictureBox7.Left = 776;
                pictureBox6.Left = 342;
                pictureBox9.Left = 1800;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox5.Left = 58;
            }
            if (pictureBox8.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox8.Left = 58;
            }
            if (pictureBox5.Top < 400)
            {
                gravity = 20;
            }
            if (pictureBox8.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox8.Top = 671;
            }
            if (pictureBox8.Top < 400 && pictureBox8.Left == 58)
            {
                gravity = 20;
            }

            if (pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox5.Top = 671;
            }
            if(pictureBox5.Bounds.IntersectsWith(pictureBox3.Bounds)|| pictureBox5.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                speed = 0;
                pictureBox5.Left =pictureBox4.Left -115;
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox6.Top = -100;
                 i+= 1;
                c.COINT = i;
                     
                    label3.Text = c.ToString();
               
            }
            if (pictureBox5.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                i += 1;
                pictureBox7.Top = -100;
 
                c.COINT = i;
                
                  label3.Text = c.ToString();
                

            }
            if( pictureBox8.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                player7.URL = ("zdaf.mp3");
                player7.controls.play();
                pictureBox4.Left = 1500;
                pictureBox4.Top = -500;

            }
            if (pictureBox8.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                timer1.Stop();
                panel1.Show();
               
                player5.URL = ("lvl 2.mp3");
                player5.controls.play();
                
            }
            if(pictureBox8.Bounds.IntersectsWith(pictureBox3.Bounds)&& pictureBox8.Top > 500)
            {
                pictureBox8.Top = 500;
            }

        }

        private void keygameisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Q)
            {
                speed = -20;
            }
            coints c = new coints();
            
            if(e.KeyCode==Keys.Space && int.Parse(label3.Text)==2 )
            {
               
                pictureBox8.Top = 667;
                pictureBox8.Left = 58;
                pictureBox5.Hide();
                c.COINT = 0;
                label3.Text =  c.COINT.ToString();

            }
        }

        private void keygameisup(object sender, KeyEventArgs e)
        {
            var n = Keys.Z;

            if (co.UP == "z" || co.UP == "Z")
            {
                n = Keys.Z;
            }
            else if (co.UP == "e" || co.UP == "E")
            {
                n = Keys.E;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode==n)
            {
                gravity = -20;
            }
            if(e.KeyCode==Keys.Right || e.KeyCode == Keys.D)
            {
                speed = 20;
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
               
        }

        private void lvl_2_Load(object sender, EventArgs e)
        {
            coints c1 = new coints();
            c1.COINT = i;
            label3.Text = c1.ToString();
            pictureBox8.Top = -100;
            pictureBox8.Left = 100;
            pictureBox9.Left = 1800;
            panel1.Hide();
            player5.URL = ("space.mp3");
            player5.controls.play();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
