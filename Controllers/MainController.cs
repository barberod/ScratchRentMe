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

            session.Routes["header"].Target = new User();

            session.Routes.Add("body", RouteService.Routes["mockperson"]);
            session.Routes["body"].Target = new Person();

            mainForm = new MainForm(Session);
        }

        public MainForm ShowMainForm() {
            return mainForm;
        }
    }
}
