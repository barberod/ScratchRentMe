using ScratchRentMe.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Services
{
    public static class PanelService
    {
        public static string[] keys = { "header", "toast", "sidebar", "footer", "accent", "body" };

        public static Dictionary<string, PanelState> InitializeGroup(params string[] keys)
        {
            var dictionary = new Dictionary<string, PanelState>();
            foreach (var key in keys)
            {
                dictionary[key] = null;
            }
            return dictionary;
        }

        public static Dictionary<string, PanelState> PanelStates { get; } = new Dictionary<string, PanelState>
        {
            ["default"] = DefaultState(),
            ["inactive"] = InactiveState(),
            ["body"] = BodyState()
        };

        public static Panel ApplyState(Panel panel, PanelState panelState)
        {
            if (panelState == null)
            {
                return panel;
            }

            panel.BackColor = (Color)panelState.Args["BackColor"];
            panel.BorderStyle = (BorderStyle)panelState.Args["BorderStyle"];
            panel.ForeColor = (Color)panelState.Args["ForeColor"];
            panel.Enabled = (bool)panelState.Args["Enabled"];

            return panel;
        }

        public static PanelState BodyState()
        {
            var state = DefaultState();
            state.Args["BackColor"] = StyleService.Styles["backcolor:body"];
            state.Args["ForeColor"] = StyleService.Styles["forecolor:body"];
            return state;
        }

        public static PanelState DefaultState()
        {
            var state = new PanelState
            {
                Args = new Dictionary<string, object>
            {
                { "BackColor", StyleService.Styles["backcolor:default"] },
                { "BorderStyle", StyleService.Styles["borderstyle:default"] },
                { "ForeColor", StyleService.Styles["forecolor:default"] },
                { "Enabled", StyleService.Styles["enablement:default"] }
            }
            };
            return state;
        }

        public static PanelState InactiveState()
        {
            var state = new PanelState
            {
                Args = new Dictionary<string, object>
            {
                { "BackColor", StyleService.Styles["backcolor:inactive"] },
                { "BorderStyle", StyleService.Styles["borderstyle:inactive"] },
                { "ForeColor", StyleService.Styles["forecolor:inactive"] },
                { "Enabled", StyleService.Styles["enablement:inactive"] }
            }
            };
            return state;
        }
    }
}
