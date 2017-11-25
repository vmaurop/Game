using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationGame
{
    public partial class Form2 : Form
    {
        string message;
        Random r;  //Random numbers of coordinates, which mosquito moved
        int hitcounter,time;
        public Form2()
        {
            InitializeComponent();
        }


        public Form2(string s)
        {
            message = s;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = message;
            r = new Random();
            time = 30;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hitcounter++;
            label2.Text = hitcounter.ToString()+"hits!";  //countinh the hits...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            r.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = r.Next(this.Width-pictureBox1.Width);    //coordinates x random
            int y = r.Next(this.Height-pictureBox1.Height);  //-- y random
            pictureBox1.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            label3.Text = time.ToString();
            if(time == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                label2.Enabled = false;
                MessageBox.Show("Game over "+hitcounter);
                Form1 t = new Form1();
                t.Show();
                this.Close();

            }
        }

      
    }
}
