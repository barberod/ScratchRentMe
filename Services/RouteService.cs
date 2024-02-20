using ScratchRentMe.Models;
using ScratchRentMe.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.Services
{
    public static class RouteService
    {
        public static Dictionary<string, Route> Routes { get; } = new Dictionary<string, Route>
        {
            ["login"] = new Route(typeof(ExampleUserControl)),
            ["dummy"] = new Route(typeof(DummyUserControl)),
            ["example"] = new Route(typeof(ExampleUserControl)),
            ["tiny"] = new Route(typeof(TinyUserControl)),
            ["blue"] = new Route(typeof(BlueUserControl)),
        };

        public static Dictionary<string, Route> RouteGroup { get; } = new Dictionary<string, Route>
        {
            ["header"]      =   Routes["tiny"],
            ["toast"]       =   Routes["tiny"],
            ["sidebar"]     =   Routes["tiny"],
            ["footer"]      =   Routes["tiny"],
            ["accent"]      =   Routes["tiny"],
            ["body"]        =   Routes["login"],
        };

        public static Panel ApplyRoute(Panel panel, Route route)
        {
            panel.Controls.Clear();

            Type userControlType = route.UserControlType;
            UserControl userControlInstance = (UserControl)Activator.CreateInstance(userControlType);
            panel.Controls.Add(userControlInstance);

            return panel;
        }
    }
}
