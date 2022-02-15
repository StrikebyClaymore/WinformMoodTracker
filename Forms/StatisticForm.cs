using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoodTracker.Forms
{
    public partial class StatisticForm : BaseForm
    {

        private abstract class DrawObj
        {
            public int x, y;
            public readonly int w, h;

            public DrawObj(Point location, Size size)
            {
                x = location.X;
                y = location.Y;
                w = size.Width;
                h = size.Height;
            }

            public virtual void Draw(Graphics g) { }
        }

        private class MyImage : DrawObj
        {
            private readonly Image image;

            public MyImage(PictureBox pb) : base(pb.Location, pb.Size)
            {
                image = pb.Image;
            }

            public override void Draw(Graphics g) => g.DrawImage(image, x, y, w, h);
        }

        private class MyRectangle : DrawObj
        {
            private readonly Brush brush;

            public MyRectangle(Panel p) : base(p.Location, p.Size)
            {
                brush = new SolidBrush(p.BackColor);
            }

            public override void Draw(Graphics g) => g.FillRectangle(brush, x, y, w, h);
        }

        private class MyLabel : DrawObj
        {
            private readonly string text;
            private readonly Font font;
            private readonly Brush brush;
            public readonly int startX;

            public MyLabel(Label l) : base(l.Location, l.Size)
            {
                text = l.Text;
                font = l.Font;
                brush = new SolidBrush(l.ForeColor);
                startX = l.Location.X;
            }

            public override void Draw(Graphics g) => g.DrawString(text, font, brush, x - font.Size, Program.StatisticForm.Height - Program.StatisticForm.ScrollBar.Height - h * 3);
        }

        private List<MyRectangle> panels;
        private List<MyImage> pictures;
        private List<MyLabel> dates = new List<MyLabel>();
        private Point[] polygon;

        private const int DateStepX = 64;
        //private readonly Point datesOffset = new Point(96, 0);
        private int maxPosX;
        private readonly Pen linePen = new Pen(Color.Black, 3);
        private readonly SolidBrush polygonBrush = new SolidBrush(Color.FromArgb(100, 60, 50, 250));


        public StatisticForm()
        {
            InitializeComponent();

            DoubleBuffered = true;
            Paint += OnPaint;

            MoveObjectsToForm();
        }

        protected override void OnVisibleChanged(object sender, EventArgs e)
        {
            base.OnVisibleChanged(sender, e);
            if (Visible)
            {
                dates.Clear();

                for (int i = 0; i < Program.Database.Data.Count; i++)
                {
                    DayData dayData = Program.Database.Data[i];
                    int moodInt = MoodToInt(dayData.Mood);
                    Label label = new Label
                    {
                        Text = dayData.Date.Day.ToString(),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point),
                        BackColor = Color.Transparent
                    };
                    label.Location = new Point(pictures[moodInt].x + DateStepX * (i + 2), pictures[moodInt].y + pictures[moodInt].h / 2 - label.Height / 2);
                    dates.Add(new MyLabel(label));
                }

                if (dates[dates.Count - 1].x - Width - DateStepX <= 0)
                ScrollBar.Enabled = false;
                    
                ScrollBar.Maximum = dates[dates.Count - 1].x - Width + DateStepX;
                maxPosX = dates[dates.Count - 1].x;
            }
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (MyLabel date in dates)
                date.x = date.startX - ScrollBar.Value;
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (MyRectangle pan in panels)
                pan.Draw(g);
            DrawGraphic(g);
            foreach (MyLabel date in dates)
                date.Draw(g);
            foreach (MyImage img in pictures)
                img.Draw(g);
        }

        private void DrawGraphic(Graphics g)
        {
            polygon = new Point[dates.Count + 2];

            for (int i = 1; i < dates.Count; i++)
            {
                MyLabel d1 = dates[i-1];
                MyLabel d2 = dates[i];
                polygon[i+1] = new Point(d2.x, d2.y);
                g.DrawLine(linePen, d1.x, d1.y, d2.x, d2.y);
            }

            polygon[1] = new Point(dates[0].x, dates[0].y);
            polygon[0] = new Point(polygon[1].X, Height);
            polygon[polygon.Length - 1] = new Point(polygon[polygon.Length - 2].X, Height);

            g.FillPolygon(polygonBrush, polygon);
        }

        private void MoveObjectsToList(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                MoveObjectsToList(c.Controls);

                if (c is PictureBox pic)
                    pictures.Add(new MyImage(pic));
                else if (c is Panel pan && !(c is TableLayoutPanel))
                    panels.Add(new MyRectangle(pan));
            }
        }

        private void MoveObjectsToForm()
        {
            panels = new List<MyRectangle>();
            pictures = new List<MyImage>();

            MoveObjectsToList(Controls);

            for (int i = 0; i < panels.Count; i++)
            {
                MyRectangle pan = panels[i];
                MyImage pic = pictures[i];
                pictures[i].x = pic.x;
                pictures[i].y = pan.y + pan.h / 2 - pic.h / 2;

            }

            CloseButton.Parent = this;

            Controls.Remove(tableLayoutPanel1);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.StatisticForm, Program.MainForm);
        }

        private int MoodToInt(string mood)
        {
            int moodInt = 0;
            switch (mood)
            {
                case "Rad":
                    moodInt = 0;
                    break;
                case "Good":
                    moodInt = 1;
                    break;
                case "Neutral":
                    moodInt = 2;
                    break;
                case "Bad":
                    moodInt = 3;
                    break;
                case "Awful":
                    moodInt = 4;
                    break;
            }
            return moodInt;
        }

    }
}
