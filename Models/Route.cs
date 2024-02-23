using ScratchRentMe.Services;
using System;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Route
    {
        public Type UserControlType { get; set; }
        public PanelState PanelState { get; set; }
        public Dictionary<string, object> Args { get; set; }

        public Route(Type userControlType, PanelState panelState = null, Dictionary<string, object> args = null)
        {
            UserControlType = userControlType;
            PanelState = panelState ?? PanelService.PanelStates["default"];
            Args = args ?? new Dictionary<string, object>();
        }
    }
}