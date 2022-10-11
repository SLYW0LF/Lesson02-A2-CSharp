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

namespace Lesson02_A2_CSharp
{
    public partial class Form1 : Form
    {
        private int counter;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void setRandBackgroundColor()
        {
            Color randColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            BackColor = randColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* myTimer = new System.Timers.Timer(1500);
             myTimer.Elapsed += onTimerElapsed;
             myTimer.Enabled = true;
             myTimer.AutoReset = true;*/
            counter = 2 + rand.Next(8);
            timer1.Interval = 1000;

            button1.Visible = false;

            label1.Visible = true;
            label2.Text = counter.ToString();
            label2.Visible = true;
            button2.Visible = true;

            setRandBackgroundColor();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            counter--;

            if(counter == 0)
            {
                timer1.Stop();
                setRandBackgroundColor();

                counter = 2 + rand.Next(8);
                timer1.Start();
            }

            label2.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
        }
    }
}







