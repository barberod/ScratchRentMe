using ScratchRentMe.Services;
using System;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Route
    {
        public Type UserControlType { get; set; }
        public PanelStyle PanelStyle { get; set; }
        public object Target { get; set; }
        public Dictionary<string, object> Args { get; set; }

        public Route(Type userControlType, PanelStyle panelStyle = null, object target = null, Dictionary<string, object> args = null)
        {
            UserControlType = userControlType;
            PanelStyle = panelStyle ?? PanelService.PanelStates["default"];
            Target = target;
            Args = args ?? new Dictionary<string, object>();
        }
    }
}