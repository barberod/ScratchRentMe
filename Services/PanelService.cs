using ScratchRentMe.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Services
{
    public static class PanelService
    {
        public static Color DefaultBackColor = SystemColors.Control;
        public static BorderStyle DefaultBorderStyle = BorderStyle.None;
        public static Color DefaultForeColor = SystemColors.ControlText;
        public static bool DefaultEnablement = true;
        public static bool DefaultVisibility = true;

        public static Color InactiveBackColor = Color.LightGray;
        public static BorderStyle InactiveBorderStyle = BorderStyle.None;
        public static Color InactiveForeColor = Color.DimGray;
        public static bool InactiveEnablement = false;
        public static bool InactiveVisibility = true;

        public static Color BodyBackColor = Color.WhiteSmoke;
        public static BorderStyle BodyBorderStyle = BorderStyle.Fixed3D;
        public static Color BodyForeColor = Color.Black;

        public static Size BodySize = new Size(755, 412);
        public static Size BodyMinimumSize = new Size(360, 220);

        public static Dictionary<string, PanelState> PanelStates { get; } = new Dictionary<string, PanelState>
        {
            ["default"] = DefaultState(),
            ["inactive"] = InactiveState(),
            ["body"] = BodyState()
        };

        public static Dictionary<string, PanelState> PanelStateGroup { get; } = new Dictionary<string, PanelState>
        {
            ["header"] = PanelStates["default"],
            ["toast"] = PanelStates["default"],
            ["sidebar"] = PanelStates["default"],
            ["footer"] = PanelStates["default"],
            ["accent"] = PanelStates["default"],
            ["body"] = PanelStates["body"],
        };

        public static Panel ApplyState(Panel panel, PanelState newPanelState)
        {
            panel.BackColor = newPanelState.BackColor;
            panel.BorderStyle = newPanelState.BorderStyle;
            panel.ForeColor = newPanelState.ForeColor;
            panel.Enabled = newPanelState.Enabled;
            panel.Visible = newPanelState.Visible;

            return panel;
        }

        public static PanelState BodyState()
        {
            var state = DefaultState();
            state.BackColor = BodyBackColor;
            state.BorderStyle = BodyBorderStyle;
            state.ForeColor = BodyForeColor;
            return state;
        }

        public static PanelState DefaultState()
        {
            PanelState DefaultPanelState = new PanelState
            {
                BackColor = DefaultBackColor,
                BorderStyle = DefaultBorderStyle,
                ForeColor = DefaultForeColor,
                Enabled = DefaultEnablement,
                Visible = DefaultVisibility
            };
            return DefaultPanelState;
        }

        public static PanelState InactiveState()
        {
            PanelState InactivePanelState = new PanelState
            {
                BackColor = InactiveBackColor,
                BorderStyle = InactiveBorderStyle,
                ForeColor = InactiveForeColor,
                Enabled = InactiveEnablement,
                Visible = InactiveVisibility
            };
            return InactivePanelState;
        }
    }
}
