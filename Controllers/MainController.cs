using ScratchRentMe.Models;

namespace ScratchRentMe.Controllers
{
    public class MainController
    {
        public Session Session { get; set; }

        public MainController(Session session)
        {
            Session = session;
        }

        public MainForm ShowMainForm() {
            return Session.MainForm;
        }
    }
}
