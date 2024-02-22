using ScratchRentMe.Services;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Session
    {
        public User User { get; set; }
        public Dictionary<string, Route> Routes { get; set; }

        public Session()
        {
            Routes = new Dictionary<string, Route>
            {
                { "header", RouteService.Routes["blue"] },
                { "toast", RouteService.Routes["blue"] },
                { "sidebar", RouteService.Routes["mainmenu"] },
                { "footer", RouteService.Routes["blue"] },
                { "accent", RouteService.Routes["blue"] },
                { "body", RouteService.Routes["dummy"] }
            };
        }
    }
}
