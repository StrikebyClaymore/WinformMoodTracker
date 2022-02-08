using System;
using System.Windows.Forms;

namespace MoodTracker.Forms
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            //FormsController.OpenForm(Program.mainForm, Program.statiscticForm);
        }

        private void EditMoods_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.MainForm, Program.ChoiceForm);
        }
    }
}
