using ScratchRentMe.Services;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Session
    {
        public User User { get; set; }
        public Dictionary<string, Route> Routes { get; set; } = RouteService.RouteGroup;
        public Dictionary<string, PanelState> PanelStates { get; set; }

        public Session()
        {
            Routes["accent"] = RouteService.Routes["blue"];
        }
    }
}
