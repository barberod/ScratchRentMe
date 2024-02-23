using ScratchRentMe.Models;
using ScratchRentMe.UserControls;
using ScratchRentMe.UserControls.Accent;
using ScratchRentMe.UserControls.Body;
using ScratchRentMe.UserControls.Footer;
using ScratchRentMe.UserControls.Header;
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
            ["header"] = new Route(
                typeof(HeaderUserControl),
                PanelService.PanelStates["header"]
            ),

            ["mainmenu"] = new Route(typeof(MainMenuUserControl)),

            ["products"] = new Route(typeof(ExampleBodyUserControl)),

            ["dummy"] = new Route(
                typeof(DummyUserControl),
                PanelService.PanelStates["body"],
                new Dictionary<string, object> { ["dummy"] = new Dummy() }
            ),

            ["accent"] = new Route(typeof(AccentUserControl)),
            ["footer"] = new Route(typeof(FooterUserControl)),
            ["blank"] = new Route(typeof(BlankUserControl)),
        };

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

            // Make every user control fill the panel it is in
            userControl.Dock = System.Windows.Forms.DockStyle.Fill;

            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            PanelService.ApplyState(panel, route.PanelState);
            return panel;
        }
    }
}
