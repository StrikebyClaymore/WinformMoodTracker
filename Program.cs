using System;
using System.Diagnostics;
using System.Windows.Forms;
using MoodTracker.Forms;

namespace MoodTracker
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static MainForm MainForm = new MainForm();

        public static ChoiceForm ChoiceForm = new ChoiceForm();
        public static EditForm EditForm = new EditForm();
        public static OpenDateForm OpenDateForm = new OpenDateForm();

        public static Date Date = new Date(DateTime.Now.ToString("dd/MM/yyyy"));

        public static readonly Database Database = new Database();
        public static DayData CurrentData;

        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Initialize();
        }

        private static void Initialize()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            
            CurrentData = Database.CreateData(Date);

            StartApplication();
        }

        private static void StartApplication()
        {
            Form startForm;
            if (CurrentData.Mood is null)
                startForm = ChoiceForm;
            else
                startForm = MainForm;

            //startForm = choiceForm; // Test

            startForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(startForm);
            startForm.StartPosition = FormStartPosition.Manual;
        }

        private static void DayChanged(object sender, EventArgs e)
        {
            //if (Visible)
            //    currentData = database.AddData();
            // смена текущей даты при смене дня
            // много тонких моментов про логику, как лучше сделать чтобы это работало
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            Database.SaveData();
        }
    }
}
