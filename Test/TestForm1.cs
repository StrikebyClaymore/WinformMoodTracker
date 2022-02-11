using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveObjects
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private Timer backGroundTimer;
        private PictureBox[] objs = new PictureBox[5];
        private int moveSpeedX = 2;
        private int[] directionsX = new int[5]{1,1,1,1,1};

        private bool spin = false;
        private int backOffset = 0;

        public MainForm()
        {
            InitializeComponent();

            AddImages();

            Paint += OnPaint;
            DoubleBuffered = true;

            Animate();
            hScrollBar1.Value = moveSpeedX;
        }


        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawBackground(g);
        }

        private void Animate()
        {
            timer = new Timer()
            {
                Interval = 1,
            };
            timer.Tick += TimerTick;
            timer.Start();

            backGroundTimer = new Timer()
            {
                Interval = 1,
            };
            backGroundTimer.Tick += BackGroundTimerTick;
            backGroundTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            for (int i = 0; i < objs.Length; i++)
            {
                var obj = objs[i];
                if (obj.Location.X < 0 || obj.Location.X > Width - obj.Size.Width)
                {
                    directionsX[i] *= -1;
                }
                obj.Location = new Point(obj.Location.X + directionsX[i] * moveSpeedX, obj.Location.Y);
            }
        }

        private void BackGroundTimerTick(object sender, EventArgs e)
        {
            backOffset += 8;
            if (backOffset >= 64)
            {
                backOffset = 0;
                spin = !spin;
            }

            Invalidate();
        }

        private void AddImages()
        {
            for (int i = 0; i < 5; i++)
            {
                var bmp = new Bitmap(@"C:\Users\CGO\Documents\Code\C#\MoveObjects\resources\images\image.png");
                var image = new PictureBox
                {
                    Image = bmp,
                    Size = bmp.Size,
                    Location = new Point(0, (i+1) * 64),
                    BackColor = Color.Transparent
                };
                objs[i] = image;
                Controls.Add(image);
            }
        }

        private void DrawBackground(Graphics g)
        {
            //Debug.WriteLine("SPAM");
            for (int i = 0; i < (int) Width + backOffset / 64; i++)
            {
                var brush = !spin ? new SolidBrush(Color.LightGray) : new SolidBrush(Color.White);
                if (spin && i % 2 == 0)
                    brush.Color = Color.LightGray;
                else if (i % 2 == 0)
                {
                    brush.Color = Color.White;
                }
                
                
                var p = new Point(i * 64 - backOffset, 0);
                var s = new Size(64, Height);
                g.FillRectangle(brush, new Rectangle(p, s));
            }

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            moveSpeedX = hScrollBar1.Value;
        }
    }
}
