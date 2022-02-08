using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MoodTracker.Forms
{
    public class BaseForm : Form
    {
        private bool _onExit = false;

        public BaseForm()
        {
            VisibleChanged += OnVisibleChanged;
            FormClosing += OnClosing;
        }

        protected virtual void OnVisibleChanged(Object sender, EventArgs e)
        {
            //Debug.WriteLine(Visible);
        }

        protected virtual void OnClosing(object sender, CancelEventArgs e)
        {
            if (_onExit)
                return;
            _onExit = true;
            foreach (BaseForm form in Application.OpenForms)
                form.Close();
        }
    }
}
