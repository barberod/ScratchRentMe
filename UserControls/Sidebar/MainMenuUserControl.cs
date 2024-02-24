using ScratchRentMe.Controllers;
using ScratchRentMe.Models;
using ScratchRentMe.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Sidebar
{
    public partial class MainMenuUserControl : UserControl
    {
        private MainController _mainController;

        public Session Session { get; set; }

        public MainMenuUserControl(Session session = null, object target = null, Dictionary<string, object> args = null)
        {
           
            Session = session;
            // _mainController = new MainController(session);
            InitializeComponent();
            
        }

        private void rentalsButton_Click(object sender, System.EventArgs e)
        {
            /*
            Session.Routes.Remove("body");
            Session.Routes.Add("body", RouteService.Routes["mockperson"]);
            Session.Routes["body"].Target = new Person();

            _mainController.ShowMainForm();
            */
        }

        private void productsButton_Click(object sender, System.EventArgs e)
        {
            /*
            Session.Routes.Remove("body");
            Session.Routes.Add("body", RouteService.Routes["products"]);

            _mainController.ShowMainForm();
            */
        }
    }
}
