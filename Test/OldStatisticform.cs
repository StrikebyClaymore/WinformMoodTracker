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
        private const int XStep = 80;

        private List<Control> moods;
        private Point[] moodPoints = new Point[5];
        private Color[] moodColors = new Color[5] {Color.Moccasin, Color.LightGreen, Color.Plum, Color.PowderBlue, Color.DarkGray};
        private Point[] _points;
        private Control[] dates;
        private Control emptyDate;
        private bool showed = false;
        private int scrollOffsetX;

        private readonly Point datesOffset = new Point(32, 32);
        private readonly Color polygonColor = Color.FromArgb(50, 30, 80, 250);

        public StatisticForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Shown += OnShown;
            //Paint += OnPaint;
            DrawBox.Paint += OnDrawBoxPaint;
            DrawBox.Scroll += OnDrawBoxScroll;
        }

        private void OnShown(object sender, EventArgs e)
        {
            AddMoods();
            AddDates();
            AddPoints();
            showed = true;
        }

        /*private void OnPaint(object sender, PaintEventArgs e)
        {
            if (!showed)
                return;
            using (Graphics g = e.Graphics)
            {
                PictureBox pic = moods[3] as PictureBox;
                g.DrawImage(pic.Image, pic.Location.X, pic.Location.Y);
            };

        }*/

        private void OnDrawBoxPaint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);
            if (!showed)
                return;
            using (Graphics g = e.Graphics)
            {
                PaintBackround(g);
                PaintGraphic(g);
            };

            /*for (int i = 0; i < moods.Count; i++)
            {
                Control m = moods[i];
                m.Refresh();
                //m.Location = new Point(moodPoints[i].X + scrollOffsetX, m.Location.Y);
            }*/
        }

        private void AddMoods()
        {
            moods = new List<Control>();
            foreach (Control c in MoodsBox.Controls)
                moods.Add(c);
            moods = moods.OrderBy(control => control.Location.Y).ToList();

            for (int i = 0; i < moods.Count; i++)
            {
                PictureBox currMood = moods[i] as PictureBox;
                PictureBox mood = new PictureBox
                {
                    Name = currMood.Name,
                    BackColor = Color.Transparent,
                    Image = currMood.Image,
                    Size = currMood.Size,
                    Location = new Point(currMood.Location.X + MoodsBox.Location.X, currMood.Location.Y + MoodsBox.Location.Y),
                };
                moodPoints[i] = mood.Location;//new Point(mood.Location.X + mood.Size.Width / 2, mood.Location.Y + mood.Size.Height / 2);
                moods[i] = mood;
                DrawBox.Controls.Add(mood);
                mood.BringToFront();
            }
            Controls.Remove(MoodsBox);
        }

        private void AddDates()
        {
            dates = new Control[Program.Database.Data.Count];
            Label label;
            for (int i = 0; i < Program.Database.Data.Count + 1; i++)
            {
                if (i == Program.Database.Data.Count)
                {
                    emptyDate = new Label
                    {
                        AutoSize = true,
                        Location = new Point(moodPoints[0].X + XStep * (i + 1), moodPoints[4].Y + datesOffset.Y),
                    };
                    DrawBox.Controls.Add(emptyDate);
                    break;
                }
                DayData dayData = Program.Database.Data[i];
                //int moodInt = MoodToInt(dayData.Mood);
                label = new Label
                {
                    Text = dayData.Date.Day.ToString(),
                    AutoSize = true,
                    Location = new Point(moodPoints[0].X + XStep * (i + 1), moodPoints[4].Y + datesOffset.Y),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point),
                    BackColor = Color.Transparent  // moods[4].BackColor
            };
                dates[i] = label;
                DrawBox.Controls.Add(label);
            }
        }

        private void PaintBackround(Graphics g)
        {
            Brush brush;
            Point start = new Point(0, 0);
            Size size;
            int distY = DistanceBetweenPoints(moods[0].Location, moods[1].Location).Y - moods[0].Size.Height;
            Size defaultSize = new Size(Width, moods[1].Location.Y - moods[0].Location.Y);

            for (int i = 0; i < moods.Count; i++)
            {
                Control mood = moods[i];
                brush = new SolidBrush(moodColors[i]);
                start.Y = moods[i].Location.Y - (distY / 2);
                size = defaultSize;

                if (i == 0)
                {
                    start.Y = 0;
                    size.Height = moods[1].Location.Y - (distY / 2);
                }
                else if (i == moods.Count - 1)
                    size.Height = Height - mood.Location.Y - (distY / 2);

                Rectangle rect = new Rectangle(start, size);
                g.FillRectangle(brush, rect);
            }
        }

        private Point DistanceBetweenPoints(Point p0, Point p1) => new Point(Math.Abs(p0.X - p1.X), Math.Abs(p0.Y - p1.Y));

        private void AddPoints()
        {
            List<Point> points = new List<Point>();

            for (int i = 0; i < Program.Database.Data.Count; i++)
            {
                DayData dayData = Program.Database.Data[i];
                string day = dayData.Date.Day.ToString();
                string mood = dayData.Mood;
                int moodInt = MoodToInt(mood);
                Point point = new Point(moodPoints[moodInt].X + XStep * (i + 1), moodPoints[moodInt].Y);
                points.Add(point);
            }

            _points = points.ToArray();
        }

        private void PaintGraphic(Graphics g)
        {
            Pen linesPen = new Pen(Color.Black, 3);
            for (int i = 1; i < _points.Length; i++)
            {
                Point p1 = _points[i - 1];
                Point p2 = _points[i];
                Point start = new Point(p1.X - scrollOffsetX, p1.Y);
                Point end = new Point(p2.X - scrollOffsetX, p2.Y);
                g.DrawLine(linesPen, start, end);
            }

            Brush polygonPen = new SolidBrush(polygonColor);
            Point[] polygon = new Point[_points.Length + 2];
            polygon[0] = new Point(_points[0].X - scrollOffsetX, Height);
            polygon[polygon.Length - 1] = new Point(_points[_points.Length - 1].X - scrollOffsetX, Height);
            for (int i = 0; i < _points.Length; i++)
                polygon[i + 1] = new Point(_points[i].X - scrollOffsetX, _points[i].Y);
            g.FillPolygon(polygonPen, polygon);
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

        private void OnDrawBoxScroll(object sender, EventArgs e)
        {
            scrollOffsetX = DrawBox.HorizontalScroll.Value;
            
            for (int i = 0; i < moods.Count; i++)
            {
                Control mood = moods[i];
                Point pos = moodPoints[i];
                mood.Location = new Point(pos.X, mood.Location.Y);
                mood.Invalidate();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.StatisticForm, Program.MainForm);
        }

    }
}
