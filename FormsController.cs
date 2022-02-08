using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MoodTracker
{
    public static class FormsController
    {
        public static void OpenForm(Form from, Form to)
        {
            to.Location = from.Location;
            to.Show();
            from.Hide();
        }
    }
}
