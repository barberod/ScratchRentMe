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

        public static Dictionary<string, Route> InitializeGroup(params string[] keys)
        {
            var dictionary = new Dictionary<string, Route>();
            foreach (var key in PanelService.keys)
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

            panel.Controls.Clear();

            Type userControlType = route.UserControlType;
            UserControl userControlInstance = (UserControl)Activator.CreateInstance(userControlType);
            panel.Controls.Add(userControlInstance);

            return panel;
        }
    }
}
