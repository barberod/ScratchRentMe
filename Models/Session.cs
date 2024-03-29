﻿using ScratchRentMe.Services;
using System.Collections.Generic;

namespace ScratchRentMe.Models
{
    public class Session
    {
        public User User { get; set; }
        public Dictionary<string, Route> Routes { get; set; }
        public MainForm MainForm { get; set; }

        public Session()
        {
            Routes = new Dictionary<string, Route>
            {
                { "header", RouteService.Routes["header"] },
                { "toast", RouteService.Routes["blank"] },
                { "sidebar", RouteService.Routes["mainmenu"] },
                { "footer", RouteService.Routes["footer"] },
                { "accent", RouteService.Routes["accent"] },
                { "body", RouteService.Routes["mockperson"] }
            };

            Routes["header"].Target = new User();
            Routes["body"].Target = new Person();

            MainForm = new MainForm(this);
        }
    }
}
