using ScratchRentMe.Model;
using ScratchRentMe.Service;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.Controller
{
    public class MainController
    {
        public Session CurrentSession { get; set; }

        public MainController(Session session)
        {
            CurrentSession = session;
            session.PanelStates = DeterminePanelStates();
        }

        public void ShowMainForm() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(CurrentSession));
        }

        public Dictionary<string, PanelState> DeterminePanelStates()
        {
            var panelStateData = new Dictionary<string, PanelState>();

            panelStateData["header"] = GetHeaderPanelState();
            panelStateData["toast"] = GetToastPanelState();
            panelStateData["sidebar"] = GetSidebarPanelState();
            panelStateData["footer"] = GetFooterPanelState();
            panelStateData["accent"] = GetAccentPanelState();

            return panelStateData;
        }

        public PanelState GetHeaderPanelState()
        {
            if (CurrentSession.CurrentRoute == "login") {
                PanelState HeaderPanelState = PanelService.GetInactivePanelState();
                return HeaderPanelState;
            }
            return PanelService.GetDefaultPanelState();
        }

        public PanelState GetToastPanelState()
        {
            if (CurrentSession.CurrentRoute == "login")
            {
                PanelState ToastPanelState = PanelService.GetDefaultPanelState();
                return ToastPanelState;
            }
            return PanelService.GetInactivePanelState();
        }

        public PanelState GetSidebarPanelState()
        {
            if (CurrentSession.CurrentRoute == "login")
            {
                PanelState ToastPanelState = PanelService.GetDefaultPanelState();
                return ToastPanelState;
            }
            return PanelService.GetInactivePanelState();
        }

        public PanelState GetFooterPanelState()
        {
            if (CurrentSession.CurrentRoute == "login")
            {
                PanelState ToastPanelState = PanelService.GetDefaultPanelState();
                return ToastPanelState;
            }
            return PanelService.GetInactivePanelState();
        }

        public PanelState GetAccentPanelState()
        {
            if (CurrentSession.CurrentRoute == "login")
            {
                PanelState ToastPanelState = PanelService.GetDefaultPanelState();
                return ToastPanelState;
            }
            return PanelService.GetInactivePanelState();
        }

        public PanelState GetBodyPanelState()
        {
            if (CurrentSession.CurrentRoute == "login")
            {
                PanelState ToastPanelState = PanelService.GetDefaultPanelState();
                return ToastPanelState;
            }
            return PanelService.GetInactivePanelState();
        }
    }
}
