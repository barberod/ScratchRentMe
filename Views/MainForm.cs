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

            AffectPanel("header");
            AffectPanel("toast");
            AffectPanel("sidebar");
            AffectPanel("footer");
            AffectPanel("accent");
            AffectPanel("body");
        }

        private void AffectPanel(string key)
        {
            Panel panel = Controls[key + "Panel"] as Panel;

            if (panel != null && Session.Routes.ContainsKey(key))
            {
                RouteService.ApplyRoute(panel, Session.Routes[key]);
            }

            if (panel != null && Session.PanelStates.ContainsKey(key))
            {
                PanelService.ApplyState(panel, Session.PanelStates[key]);
            }
        }
    }
}
