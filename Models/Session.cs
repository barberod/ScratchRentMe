using ScratchRentMe.Services;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Session
    {
        public User User { get; set; }
        public Dictionary<string, Route> Routes { get; set; } = RouteService.InitializeGroup();

        public Session()
        {
            Routes["header"] = RouteService.Routes["blue"];
            Routes["toast"] = RouteService.Routes["blue"];
            Routes["sidebar"] = RouteService.Routes["mainmenu"];
            Routes["footer"] = RouteService.Routes["blue"];
            Routes["accent"] = RouteService.Routes["blue"];
            Routes["body"] = RouteService.Routes["dummy"];
        }
    }
}
