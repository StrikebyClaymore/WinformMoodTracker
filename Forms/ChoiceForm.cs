using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace MoodTracker.Forms
{
    public partial class ChoiceForm : BaseForm
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void SetDate()
        {
            if (Program.CurrentData.Date.ToString() == DateTime.Now.Date.ToString("dd/MM/yyyy"))
            {
                string[] date = DateTime.Now.Date.ToString("M").Split(' ');
                string time = DateTime.Now.ToString("hh/mm").Replace('.', ':');
                DateText.Text = "Сегодня, " + date[1] + " " + date[0] + ", " + time;
            }
            else
            {
                //Program.date = Program.currentData.Date;
                string[] date = Program.CurrentData.Date.ToString().Split('.');
                date[1] = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0])).ToString("M").Split(' ')[0];
                DateText.Text = date[0] + " " + date[1] + " " + date[2];

            }
        }

        private void OpenDialog_Shown(Object sender, EventArgs e)
        {
            if (!Visible)
                return;
            SetDate();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.ChoiceForm, Program.MainForm);
        }

        private void ChoiseMoodButton_Click(object sender, EventArgs e) 
        {
            Button b = sender as Button;
            string mood = b.Name.Split("Button")[0];
            //string date = DateTime.Now.ToString("dd/MM/yyyy");

            Program.CurrentData.Mood = mood;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.ChoiceForm, Program.EditForm);
        }

        private void Date_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.ChoiceForm, Program.OpenDateForm);
        }

        private void SetNextDay_Click(object sender, EventArgs e)
        {
            /*var split = date.Split(".");
            date = (int.Parse(split[0]) + 1).ToString() + "." + split[1] + "." + split[2];
            currentData = database.AddData();*/
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.Database.AddData();
            FormsController.OpenForm(Program.ChoiceForm, Program.MainForm);
        }
    }
}
