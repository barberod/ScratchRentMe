using System;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Route
    {
        public Type UserControlType { get; set; }
        public string PanelName { get; set; }
        public Dictionary<string, object> Args { get; set; }

        public Route(Type userControlType, string panelName = "bodyPanel", Dictionary<string, object> args = null)
        {
            UserControlType = userControlType;
            PanelName = panelName;
            Args = args;
        }
    }
}
