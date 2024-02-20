using ScratchRentMe.Controllers;
using ScratchRentMe.Models;
using System;
using System.Windows.Forms;

namespace ScratchRentMe
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

            MainController mainController = new MainController(new Session());
            
            Application.Run(mainController.ShowMainForm());
        }
    }
}
