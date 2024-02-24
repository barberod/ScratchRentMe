using ScratchRentMe.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Services
{
    public static class PanelService
    {
        public static Dictionary<string, PanelStyle> PanelStates { get; } = new Dictionary<string, PanelStyle>
        {
            ["default"] = new PanelStyle(
                    (Color)StyleService.Styles["backcolor:default"],
                    (BorderStyle)StyleService.Styles["borderstyle:default"],
                    (Color)StyleService.Styles["forecolor:default"]
                ),

            ["inactive"] = new PanelStyle(
                    (Color)StyleService.Styles["backcolor:inactive"],
                    (BorderStyle)StyleService.Styles["borderstyle:inactive"],
                    (Color)StyleService.Styles["forecolor:inactive"]
                ),

            ["body"] = new PanelStyle(
                    (Color)StyleService.Styles["backcolor:body"],
                    (BorderStyle)StyleService.Styles["borderstyle:body"],
                    (Color)StyleService.Styles["forecolor:body"]
                ),

            ["header"] = new PanelStyle(
                    (Color)StyleService.Styles["custom:dark"],
                    (BorderStyle)StyleService.Styles["borderstyle:default"],
                    (Color)StyleService.Styles["forecolor:default"]
                )
        };

        public static Panel ApplyStyles(Panel panel, Route route)
        {
            if (route == null)
            {
                return panel;
            }

            panel.BackColor = route.PanelStyle.BackColor;
            panel.BorderStyle = route.PanelStyle.BorderStyle;
            panel.ForeColor = route.PanelStyle.ForeColor;

            return panel;
        }
    }
}
