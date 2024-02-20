using ScratchRentMe.Model;
using System.Windows.Forms;

namespace ScratchRentMe.Controller
{
    public class SessionController
    {
        public Session CurrentSession { get; set; }

        public SessionController(Session session)
        {
            CurrentSession = session;
        }
    }
}

