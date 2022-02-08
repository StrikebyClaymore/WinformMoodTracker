using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MoodTracker.Forms
{
    public partial class EditForm : BaseForm
    {
        public RichTextBox TextBox;

        public EditForm()
        {
            InitializeComponent();
            TextBox = Note;
        }

        private void Note_TextChanged(object sender, EventArgs e)
        {
            string text = TextBox.Text;
            Program.CurrentData.Note = text;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormsController.OpenForm(Program.EditForm, Program.ChoiceForm);
        }

        private void OpenDialog_Shown(Object sender, EventArgs e)
        {
            if (!Visible)
                return;
            TextBox.Text = Program.CurrentData.Note;
        }
    }
}
