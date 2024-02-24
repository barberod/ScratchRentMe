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
            ["accent"] = new Route(typeof(AccentUserControl)),

            ["blank"] = new Route(typeof(BlankUserControl)),

            ["footer"] = new Route(typeof(FooterUserControl)),

            ["header"] = new Route(typeof(HeaderUserControl), PanelService.PanelStyles["header"]),

            ["mainmenu"] = new Route(typeof(MainMenuUserControl)),

            ["mockperson"] = new Route(typeof(MockPersonUserControl), PanelService.PanelStyles["body"]),

            ["products"] = new Route(typeof(ExampleBodyUserControl)),
        };

        public static Panel ApplyRoute(Session session, Panel panel, Route route)
        {
            if (route == null)
            {
                return panel;
            }

            Type userControlType = route.UserControlType;
            UserControl userControl;

            // route.Args is never null because the Route constructor initializes it
            userControl = (UserControl)Activator.CreateInstance(userControlType, session, route.Target, route.Args);

            // Make every user control fill the panel it is in
            userControl.Dock = DockStyle.Fill;

            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            PanelService.ApplyStyles(panel, route);
            return panel;
        }
    }
}
