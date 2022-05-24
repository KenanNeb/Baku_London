using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baku_London
{
    public partial class Form1 : Form
    {
        Timer Timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }
       
        public void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = "Baku";
            label1.Text = DateTime.Now.ToLongTimeString();
        }
        public void TimerLndn_Tick(object sender, EventArgs e)
        {
            this.Text = "London";
            label1.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }    
        
        private void btn_London_MouseClick(object sender, MouseEventArgs e)
        {
            Timer.Stop();
            Timer.Tick += TimerLndn_Tick;
            Timer.Interval = 1000;
            pictureBox_Baku.Image = Properties.Resources.London;

            Timer.Start();
            this.Text = "London";
            btn_London.BackColor = Color.DarkTurquoise;
            btn_London.BackColor = Color.DarkMagenta;
        }

        private void btn_Baku_MouseClick(object sender, MouseEventArgs e)
        {
            Timer.Stop();
            Timer.Tick += Timer_Tick;
            Timer.Interval = 1000;

            pictureBox_Baku.Image = Properties.Resources.Baku;

            Timer.Start();
            this.Text = "Baku";
            btn_Baku.BackColor = Color.DarkTurquoise;
            btn_Baku.BackColor = Color.Red;
        }
    }
}
       
