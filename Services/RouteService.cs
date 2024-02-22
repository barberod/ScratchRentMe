using ScratchRentMe.Models;
using ScratchRentMe.UserControls;
using ScratchRentMe.UserControls.Body;
using ScratchRentMe.UserControls.Sidebar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.Services
{
    public static class RouteService
    {
        public static Dictionary<string, Route> Routes { get; } = new Dictionary<string, Route>
        {
            ["mainmenu"] = new Route(typeof(MainMenuUserControl)),

            ["products"] = new Route(typeof(ExampleBodyUserControl)),

            ["login"] = new Route(typeof(ExampleUserControl)),

            ["dummy"] = new Route(
                typeof(DummyUserControl),
                PanelService.PanelStates["body"],
                new Dictionary<string, object> { ["dummy"] = new Dummy() }
            ),

            ["example"] = new Route(typeof(ExampleUserControl)),
            ["tiny"] = new Route(typeof(TinyUserControl)),
            ["blue"] = new Route(typeof(BlueUserControl)),
        };

        public static string[] keys = { "header", "toast", "sidebar", "footer", "accent", "body" };

        public static Dictionary<string, Route> InitializeGroup(params string[] keys)
        {
            var dictionary = new Dictionary<string, Route>();
            foreach (var key in keys)
            {
                dictionary[key] = null;
            }
            return dictionary;
        }

        public static Panel ApplyRoute(Panel panel, Route route)
        {
            if (route == null)
            {
                return panel;
            }

            Type userControlType = route.UserControlType;
            UserControl userControl;

            if (route.Args != null)
            {
                userControl = (UserControl)Activator.CreateInstance(userControlType, route.Args);
            }
            else
            {
                userControl = (UserControl)Activator.CreateInstance(userControlType);
            }

            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            PanelService.ApplyState(panel, route.PanelState);
            return panel;
        }
    }
}
