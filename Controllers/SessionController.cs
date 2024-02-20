using ScratchRentMe.Models;
using System.Windows.Forms;

namespace ScratchRentMe.Controllers
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

