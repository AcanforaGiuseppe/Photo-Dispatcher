/*
© Giuseppe Acanfora - PHOTODISPATCHER 2024. Tutti i diritti riservati.
*/
using System;
using System.Windows.Forms;

namespace PhotoDispatcherView
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SettingsForm());
        }

    }
}