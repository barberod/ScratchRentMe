using ScratchRentMe.Models;
using ScratchRentMe.Services;
using System.Windows.Forms;

namespace ScratchRentMe
{
    public partial class MainForm : Form
    {
        public Session Session { get; set; }

        public MainForm(Session session)
        {
            Session = session;
            InitializeComponent();
            SetupForm();
        }

        public void SetupForm()
        {
            AffectPanel("header");
            AffectPanel("toast");
            AffectPanel("sidebar");
            AffectPanel("footer");
            AffectPanel("accent");
            AffectPanel("body");
        }

        public void RefreshForm()
        {
            Invalidate();
            Refresh();

            AffectPanel("toast");
            AffectPanel("sidebar");
            AffectPanel("body");
        }

        private void AffectPanel(string key)
        {
            if (Controls[key + "Panel"] is Panel panel && Session.Routes.ContainsKey(key))
            {
                RouteService.ApplyRoute(Session, panel, Session.Routes[key]);
            }
        }
    }
}
