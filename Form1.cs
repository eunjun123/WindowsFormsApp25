using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        int i = 0;
        Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            i = 0;
            // 윈폼 타이머 사용
            timer.Interval = 1000; // 1초
            timer.Tick += new EventHandler(timer_Tick);



            timer.Start();
        }

           void timer_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(Color.Blue);

            Rectangle ball = new Rectangle(300-i*35, 115, 20, 20);
            g.FillEllipse(Brushes.White, ball);
            g.DrawEllipse(Pens.DarkGreen, ball);

            Rectangle r = new Rectangle(50, 50, 150, 150);
            g.FillPie(Brushes.Yellow, r, 45-(i*9), 270 + 18*i);
            g.DrawPie(Pens.DarkGreen, r, 45-(i*9), 270 + 18*i);

            Rectangle eye = new Rectangle(110, 75, 15, 15);
            g.FillEllipse(Brushes.Black, eye);

            Rectangle eye_in = new Rectangle(119, 80, 5, 5);
            g.FillEllipse(Brushes.White, eye_in);

            i++;

            if (i > 5)
            {
                timer.Stop();
            }
        }
    }
}
