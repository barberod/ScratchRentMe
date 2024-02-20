using System.Collections.Generic;

namespace ScratchRentMe.Model
{
    public class Session
    {
        public User CurrentUser { get; set; }
        public string CurrentRoute { get; set; }
        public Dictionary<string, PanelState> PanelStates { get; set; }

        public Session(User currentUser = null, string currentRoute = "login")
        {
            this.CurrentUser = currentUser;
            this.CurrentRoute = currentRoute;
        }
    }
}
