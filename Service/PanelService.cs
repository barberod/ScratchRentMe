using ScratchRentMe.Model;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Service
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

        public static Panel ApplyState(Panel panelBefore, PanelState newPanelState)
        {
            Panel panelAfter = panelBefore;

            panelAfter.BackColor = newPanelState.BackColor;
            panelAfter.BorderStyle = newPanelState.BorderStyle;
            panelAfter.ForeColor = newPanelState.ForeColor;
            panelAfter.Enabled = newPanelState.Enabled;
            panelAfter.Visible = newPanelState.Visible;

            return panelAfter;
        }

        public static PanelState GetDefaultPanelState()
        {
            PanelState DefaultPanelState = new PanelState();
            DefaultPanelState.BackColor = PanelService.DefaultBackColor;
            DefaultPanelState.BorderStyle = PanelService.DefaultBorderStyle;
            DefaultPanelState.ForeColor = PanelService.DefaultForeColor;
            DefaultPanelState.Enabled = PanelService.DefaultEnablement;
            DefaultPanelState.Visible = PanelService.DefaultVisibility;
            return DefaultPanelState;
        }
        public static PanelState GetInactivePanelState()
        {
            PanelState InactivePanelState = new PanelState();
            InactivePanelState.BackColor = PanelService.InactiveBackColor;
            InactivePanelState.BorderStyle = PanelService.InactiveBorderStyle;
            InactivePanelState.ForeColor = PanelService.InactiveForeColor;
            InactivePanelState.Enabled = PanelService.InactiveEnablement;
            InactivePanelState.Visible = PanelService.InactiveVisibility;
            return InactivePanelState;
        }
    }
}
