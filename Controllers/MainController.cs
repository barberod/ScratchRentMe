using ScratchRentMe.Models;

namespace ScratchRentMe.Controllers
{
    public class MainController
    {
        private readonly MainForm mainForm;

        public Session Session { get; set; }

        public MainController(Session session)
        {
            Session = session;
            mainForm = new MainForm(Session);
        }

        public MainForm ShowMainForm() {
            return mainForm;
        }
    }
}
