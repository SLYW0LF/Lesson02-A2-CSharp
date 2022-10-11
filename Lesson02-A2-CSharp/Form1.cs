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
        private System.Timers.Timer myTimer;
        private Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void onTimerElapsed(Object source, ElapsedEventArgs e)
        {
            setRandBackgroundColor();

        }

        private void setRandBackgroundColor()
        {
            Color randColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            BackColor = randColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTimer = new System.Timers.Timer(1500);
            myTimer.Elapsed += onTimerElapsed;
            myTimer.Enabled = true;
            myTimer.AutoReset = true;

            button1.Visible = false;

            setRandBackgroundColor();

        }
    }
}







