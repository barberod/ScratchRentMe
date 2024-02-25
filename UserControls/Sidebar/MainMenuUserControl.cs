using ScratchRentMe.Controllers;
using ScratchRentMe.Models;
using ScratchRentMe.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Sidebar
{
    public partial class MainMenuUserControl : UserControl
    {
        public Session Session { get; set; }

        public MainMenuUserControl(Session session, object target = null, Dictionary<string, object> args = null)
        {
            Session = session;
            InitializeComponent();
        }

        private void rentalsButton_Click(object sender, System.EventArgs e)
        {
            Session.Routes.Remove("body");
            Session.Routes.Add("body", RouteService.Routes["mockperson"]);
            Session.Routes["body"].Target = new Person();

            Session.MainForm.RefreshForm();
        }

        private void productsButton_Click(object sender, System.EventArgs e)
        {
            Session.Routes.Remove("body");
            Session.Routes.Add("body", RouteService.Routes["products"]);

            Session.MainForm.RefreshForm();
        }
    }
}
