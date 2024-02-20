using ScratchRentMe.Models;
using ScratchRentMe.Services;

namespace ScratchRentMe.Controllers
{
    public class MainController
    {
        private readonly MainForm mainForm;

        public Session Session { get; set; }

        public MainController(Session session)
        {
            Session = session;
            Session.PanelStates = PanelService.PanelStateGroup;
            mainForm = new MainForm(Session);
        }

        public MainForm ShowMainForm() {
            return mainForm;
        }
    }
}
