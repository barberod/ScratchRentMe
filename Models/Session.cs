using ScratchRentMe.Services;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Session
    {
        public User User { get; set; }
        public Dictionary<string, Route> Routes { get; set; } = RouteService.InitializeGroup();
        public Dictionary<string, PanelState> PanelStates { get; set; } = PanelService.InitializeGroup();

        public Session()
        {
            Routes["header"] = RouteService.Routes["blue"];
            Routes["toast"] = RouteService.Routes["blue"];
            Routes["sidebar"] = RouteService.Routes["blue"];
            Routes["footer"] = RouteService.Routes["blue"];
            Routes["accent"] = RouteService.Routes["blue"];
            Routes["body"] = RouteService.Routes["blue"];

            PanelStates["header"] = PanelService.PanelStates["default"];
            PanelStates["toast"] = PanelService.PanelStates["default"];
            PanelStates["sidebar"] = PanelService.PanelStates["inactive"];
            PanelStates["footer"] = PanelService.PanelStates["default"];
            PanelStates["accent"] = PanelService.PanelStates["default"];
            PanelStates["body"] = PanelService.PanelStates["body"];
        }
    }
}
