using ScratchRentMe.Model;
using ScratchRentMe.Service;
using System.Windows.Forms;

namespace ScratchRentMe
{
    public partial class MainForm : Form
    {
        public Session CurrentSession { get; set; }

        public MainForm(Session session)
        {
            CurrentSession = session;
            InitializeComponent();
            ApplyAllPanelStates();
        }

        public void ApplyAllPanelStates()
        {
            PanelService.ApplyState(this.headerPanel, CurrentSession.PanelStates["header"]);
            PanelService.ApplyState(this.toastPanel, CurrentSession.PanelStates["toast"]);
            PanelService.ApplyState(this.sidebarPanel, CurrentSession.PanelStates["sidebar"]);
            PanelService.ApplyState(this.footerPanel, CurrentSession.PanelStates["footer"]);
            PanelService.ApplyState(this.accentPanel, CurrentSession.PanelStates["accent"]);
        }
    }
}
