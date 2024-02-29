using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_game2
{
    public partial class setting : Form
    {
        control co = new control();
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            textBox1.Text = co.UP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            co.UP = textBox1.Text;
            this.Hide();
            
            
        }
    }
}
