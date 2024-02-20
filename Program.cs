using ScratchRentMe.Controller;
using ScratchRentMe.Model;
using System;

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
            Session appSession = new Session();

            MainController mainController = new MainController(appSession);
            mainController.ShowMainForm();
        }
    }
}
