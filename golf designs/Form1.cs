using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace golf_designs
{
    public partial class Form1 : Form
    {
        SoundPlayer Putting = new SoundPlayer(Properties.Resources.puttSound);
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {


            Pen GreenPen = new Pen(Color.Green, 30);
            Pen GrayPen = new Pen(Color.Gray, 30);
            Pen RedPen = new Pen(Color.Red, 30);
            SolidBrush GreenBrush = new SolidBrush(Color.LightGreen);
            Graphics g = this.CreateGraphics();
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            SolidBrush GrayBrush = new SolidBrush(Color.Gray);

          
            g.Clear(Color.Green);
            g.DrawEllipse(GreenPen, 100, 75, 200, 200);
            g.FillEllipse(GreenBrush, 50, 75, 150, 200);
            g.FillRectangle(WhiteBrush, 90, 70, 10, 90);
            g.FillRectangle(GreenBrush, 120, 150, 400, 50);
            g.FillEllipse(BlackBrush, 85, 150, 20, 20);
            g.DrawPie(RedPen, 100, 50, 50, 50, 160, 45);
            Thread.Sleep(2000);
            Putting.Play();
            Thread.Sleep(700);

            int y = 470;
            int y2 = 480;
            while (y > 440)
            {
         
                g.FillRectangle(BlackBrush, y, 155, 20, 30);
                Thread.Sleep(10);
                g.FillRectangle(GreenBrush, y2, 155, 20, 30);
                Thread.Sleep(10);
                y = y - 5;
                y2 = y2 - 5;


            }

            int x = 430;
            int x2 = 450;

            while (x > 85)

            {

                g.FillEllipse(GrayBrush, x, 155, 10, 10);
                Thread.Sleep(10);
                g.FillEllipse(GreenBrush, x2, 155, 10, 10);
                Thread.Sleep(10);
                x = x - 20;
                x2 = x2 - 20;
            }
            g.FillEllipse(BlackBrush, 85, 150, 20, 20);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 0);
            Pen YellowPen = new Pen(Color.Yellow, 10);
            Pen GreenPen = new Pen(Color.Green, 15);
            Pen DarkgreenPen = new Pen(Color.DarkGreen, 15);
            SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Aerial", 16, FontStyle.Bold);
            Pen whitePen = new Pen(Color.White, 0);


            g.Clear(Color.Blue);
            g.FillEllipse(YellowBrush, 240, 60, 150, 150);
            g.DrawString("Welcome to summer", drawFont, WhiteBrush, 200, 300);
            g.DrawLine(YellowPen, 180, 50, 250, 100);
            g.DrawLine(YellowPen, 380, 100, 450, 50);
            g.DrawLine(YellowPen, 180, 220, 250, 170);
            g.DrawLine(YellowPen, 380, 170, 450, 220);
            g.DrawLine(YellowPen, 315, 0, 315, 70);
            g.DrawLine(YellowPen, 315, 200, 315, 280);

            for (int i = 0; i <= 650; i = i + 5)

            {

                g.DrawLine(GreenPen, i, 375, i, 340);

            }
            for (int i = 0; i <= 650; i = i + 30)

            {

                g.DrawLine(DarkgreenPen, i, 375, i, 330);



            }
        }
    }
}
