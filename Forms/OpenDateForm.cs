using System;
using System.Windows.Forms;

namespace MoodTracker.Forms
{
    public partial class OpenDateForm : BaseForm
    {
        private bool _dateIsSet = false;

        public OpenDateForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.OpenDateForm, Program.ChoiceForm);
        }

        private void OpenDialog_Shown(Object sender, EventArgs e)
        {
            SetData();
        }

        private void SetData()
        {
            if (_dateIsSet)
                return;
            _dateIsSet = true;

            DateGrid.Controls.Clear();

            string[] date = Program.Database.SelectedDate.ToString().Split('.');
            date[1] = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0])).ToString("MMMM").Split(' ')[0];
            CurrentDate.Text = date[1] + " " + date[2];

            for (int i = 0; i < Program.Database.Data.Count; i++)
            {
                DayData data = Program.Database.GetData(i);
                int day = int.Parse(data.Date.ToString().Split(".")[0]) - 1;

                Button button = new Button()
                {
                    AutoSize = true,
                    Text = (day + 1).ToString(),
                    Cursor = Cursors.Hand
                };

                /*if (data.Date == Program.date)
                    button.BackColor = Color.SkyBlue;*/

                button.Click += new EventHandler(Data_Click);

                int column = day % DateGrid.ColumnCount;
                int row = (day - column) / DateGrid.ColumnCount;

                DateGrid.Controls.Add(button, column, row);
            }

            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            for (int i = 0; i < daysInMonth; i++)
            {
                int column = i % DateGrid.ColumnCount;
                int row = (i - column) / DateGrid.ColumnCount;
                // int idx = row * DateGrid.ColumnCount + column;

                if (!(DateGrid.GetControlFromPosition(column, row) is null))
                    continue;

                Button button = new Button()
                {
                    AutoSize = true,
                    Text = (i + 1).ToString(),
                    //Cursor = Cursors.Hand,
                    Enabled = false
                };
                button.Click += new EventHandler(Data_Click);

                DateGrid.Controls.Add(button, column, row);
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Program.CurrentData = Program.Database.GetData(button.Text);
            FormsController.OpenForm(Program.OpenDateForm, Program.ChoiceForm);
        }


        private void CurrentDate_Click(object sender, EventArgs e)
        {
        }

        private void Next_Click(object sender, EventArgs e)
        {
            _dateIsSet = false;
            if (Program.Database.SelectDate(1))
                SetData();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            _dateIsSet = false;
            if (Program.Database.SelectDate(-1))
                SetData();
        }
    }
}
